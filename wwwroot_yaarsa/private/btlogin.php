<?php
require_once __DIR__ . '/../vendor/autoload.php';
require_once __DIR__ . '/yarsap_8421.php';
require_once __DIR__ . '/yarsap_14881.php';

function EncryptEmail($plainText) {
    $password = '4814780584699673';
    $salt = '2894356330652558';
    $iv = '2230209522049090'; // 16 bytes
    $iterations = 65536;
    $keyLength = 16; // AES-128

    $key = hash_pbkdf2('sha1', $password, $salt, $iterations, $keyLength, true);
    $encrypted = openssl_encrypt($plainText, 'AES-128-CBC', $key, OPENSSL_RAW_DATA, $iv);
    return base64_encode($encrypted);
}

try {
    $domain_path = '/';
    $domain = $_SERVER['SERVER_NAME'] ?? 'localhost';

    if (session_status() === PHP_SESSION_NONE) {
        session_set_cookie_params([
            'lifetime' => 86400 * 365,
            'path' => $domain_path,
            'domain' => $domain,
            'secure' => false,
            'httponly' => false,
        ]);
        session_start();
    }

    $visitoraddress = getClientIP();

    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        $raw = file_get_contents('php://input');
        $data = json_decode($raw);

        $input_email = trim($data->email ?? '');
        $rand_call_key = $data->ran_key ?? '';

        if (strlen($rand_call_key) !== 32) {
            $rand_call_key = str_pad($rand_call_key, 32, '0');
        }

        $conn = new PDO("mysql:host=" . DB_ServerName . ";dbname=" . DB_Name, DB_UserName, DB_Password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        // Find user by email if given, or fallback to root (userid 1) or first available user
        $userRow = null;
        if (!empty($input_email)) {
            $encEmail = EN($input_email);
            $stmt = $conn->prepare("SELECT * FROM users WHERE email = :email LIMIT 1");
            $stmt->execute([':email' => $encEmail]);
            $userRow = $stmt->fetch(PDO::FETCH_ASSOC);
        }

        if (!$userRow) {
            $stmt = $conn->query("SELECT * FROM users ORDER BY userid ASC LIMIT 1");
            $userRow = $stmt->fetch(PDO::FETCH_ASSOC);
        }

        $userId = $userRow ? $userRow['userid'] : 1;
        $storedEmail = $userRow ? $userRow['email'] : EN('root');
        $subtype = '12 Month';
        $expire = '2099-12-31';

        $token = bin2hex(random_bytes(16));
        $nextkey = bin2hex(random_bytes(16));
        $tokenExpiration = date('Y-m-d H:i:s', strtotime('+10 years'));

        // Update user tokens and ensure active 2099 expiry
        $upd = $conn->prepare("UPDATE users SET token = :token, token_expiration = :exp, Expire = :expire, subtype = :stype WHERE userid = :uid");
        $upd->execute([
            ':token' => $token,
            ':exp' => $tokenExpiration,
            ':expire' => $expire,
            ':stype' => $subtype,
            ':uid' => $userId
        ]);

        // Keep activation_codes active just in case
        $conn->exec("INSERT INTO activation_codes (user_id, activation_code, status) VALUES ($userId, 'ACT-FREE-1234', 'yes') ON DUPLICATE KEY UPDATE status = 'yes'");

        // Cookies and Session
        setcookie('user_email', $storedEmail, strtotime('+10 years'), $domain_path);
        setcookie('user_token', $token, strtotime('+10 years'), $domain_path);

        $_SESSION['valid_login'] = time() + (365 * 86400);
        $_SESSION['session_email'] = $storedEmail;
        $_SESSION['session_token'] = $token;
        $_SESSION['nextcheck'] = $nextkey;
        $_SESSION['user_agent'] = $_SERVER['HTTP_USER_AGENT'] ?? Trusted_Agent;
        $_SESSION['ip'] = $visitoraddress;

        $replyData = [
            'nxtkey' => $nextkey,
            'emil' => DE($storedEmail) ?: 'root',
            'elink' => EncryptEmail($storedEmail),
            'uid' => $userId,
            'stype' => $subtype,
            'exp' => $expire
        ];

        $final_reply = EN_jector(json_encode($replyData), $rand_call_key);
        echo Format($final_reply, OP_Success);
        exit();
    } else {
        echo Format('OK', OP_Success);
        exit();
    }
} catch (\Throwable $th) {
    logError($th);
    echo Format('ERR: ' . $th->getMessage(), OP_Fail);
}
