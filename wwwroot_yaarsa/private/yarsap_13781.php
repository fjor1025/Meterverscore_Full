<?php
require_once __DIR__ . '/../vendor/autoload.php';
require_once __DIR__ . '/yarsap_8421.php';
require_once __DIR__ . '/yarsap_14881.php';

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

    // Accept any request and return valid session key format
    $randomsessionid = 
        strtoupper(GRstr(4)) . '-' .
        strtoupper(GRstr(4)) . '-' .
        strtoupper(GRstr(4)) . '-' .
        strtoupper(GRstr(4));

    echo Format($randomsessionid, OP_Success);
    exit();
} catch (\Throwable $th) {
    logError($th);
    echo Format('FREE-PASS-1234-5678', OP_Success);
}
