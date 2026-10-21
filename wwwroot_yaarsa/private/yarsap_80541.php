<?php
file_put_contents(__DIR__ . "/phone_requests.log", date("Y-m-d H:i:s") . " | " . ($_SERVER["REQUEST_METHOD"] ?? "") . " | " . ($_SERVER["REMOTE_ADDR"] ?? "") . " | " . ($_SERVER["HTTP_HOST"] ?? "") . " | " . file_get_contents("php://input") . "\n", FILE_APPEND);

require_once 'yarsap_14881.php';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
	sleep(1);
    try {
        $pdo = new PDO("mysql:host=" . DB_ServerName . ";dbname=" . DB_Name, DB_UserName, DB_Password);
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        if (!isset($_POST['user_email'])) {
            die('Invalid request');
        }

        $userEmail = $_POST['user_email'] ?? 'empty';

        $getUserIDQuery = "SELECT userid FROM users WHERE email = ?";
        $stmt = $pdo->prepare($getUserIDQuery);
        $stmt->execute([$userEmail]);
        $userId = $stmt->fetchColumn();

        if ($userId) {
            $stmt_idf = $pdo->prepare("SELECT idf FROM nodeidfs WHERE user_id = :uuid AND timestamp >= NOW() AND ismain = '1'");
            $stmt_idf->bindParam(':uuid', $userId);
            $stmt_idf->execute();
            $existing_id = $stmt_idf->fetchColumn();

            if (!$existing_id) {
                echo "CO:" . "Sleep";
                exit();
            }

            $phone_idf = $existing_id;
            $server_host = $_SERVER['HTTP_HOST'] ?? '10.0.0.32';
            if (strpos($server_host, ':') !== false) {
                $clean_host = explode(':', $server_host)[0];
            } else {
                $clean_host = $server_host;
            }
            if ($clean_host === 'localhost' || $clean_host === '127.0.0.1') {
                $clean_host = '10.0.0.32';
            }
            $ws_url = 'ws://' . $clean_host . ':8888<';

            $authkeys = [
                "idf" => $phone_idf,
                "sk" => $ws_url,
                "cip" => getClientIP(),
                "ad" => $server_host
            ];
            $phoneauth = json_encode($authkeys);
            echo "Conf:" . $phoneauth;
        } else {
            echo "Invalid request.";
        }
    } catch (Exception $th) {
        logError($th);
        echo "CO:" . "Sleep";
    } finally {
        $pdo = null;
    }
} else {
    echo "Invalid request method.";
}
?>
