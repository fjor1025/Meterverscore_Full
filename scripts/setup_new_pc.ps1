# ==============================================================================
# Meterverscore2 Automated Setup Script for New Windows PC / VPS
# Run this script in an Elevated PowerShell (Run as Administrator)
# ==============================================================================

#Requires -RunAsAdministrator
$ErrorActionPreference = "Stop"

Write-Host "==========================================================" -ForegroundColor Cyan
Write-Host " Starting Meterverscore2 Environment Automated Setup...   " -ForegroundColor Cyan
Write-Host "==========================================================" -ForegroundColor Cyan

$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Definition
$BundleRoot = Split-Path -Parent $ScriptDir
if (-not (Test-Path "$BundleRoot\wwwroot_yaarsa")) {
    # If run from unzipped root directly
    if (Test-Path "$ScriptDir\wwwroot_yaarsa") {
        $BundleRoot = $ScriptDir
    } else {
        $BundleRoot = (Get-Location).Path
    }
}

Write-Host "[1/8] Verifying and Enabling IIS with FastCGI & WebSockets..." -ForegroundColor Yellow
$iisFeatures = @(
    "IIS-WebServerRole",
    "IIS-WebServer",
    "IIS-CommonHttpFeatures",
    "IIS-HttpErrors",
    "IIS-HttpRedirect",
    "IIS-ApplicationDevelopment",
    "IIS-WebSockets",
    "IIS-CGI",
    "IIS-NetFxExtensibility45",
    "IIS-ISAPIExtensions",
    "IIS-ISAPIFilter",
    "IIS-ManagementConsole",
    "IIS-RequestFiltering"
)

foreach ($feature in $iisFeatures) {
    $state = (Get-WindowsOptionalFeature -Online -FeatureName $feature -ErrorAction SilentlyContinue).State
    if ($state -ne "Enabled") {
        Write-Host "  Enabling feature: $feature..." -ForegroundColor DarkGray
        Enable-WindowsOptionalFeature -Online -FeatureName $feature -All -NoRestart | Out-Null
    }
}
Write-Host "  IIS and required features are enabled." -ForegroundColor Green

Write-Host "[2/8] Setting up PHP 8.x Environment..." -ForegroundColor Yellow
$phpDir = "C:\PHP"
if (-not (Test-Path "$phpDir\php.exe")) {
    New-Item -ItemType Directory -Path $phpDir -Force | Out-Null
    $phpZip = "$env:TEMP\php8_nts.zip"
    Write-Host "  Downloading PHP 8.3 NTS x64..." -ForegroundColor DarkGray
    Invoke-WebRequest -Uri "https://windows.php.net/downloads/releases/archives/php-8.3.13-nts-Win32-vs16-x64.zip" -OutFile $phpZip -UseBasicParsing
    Expand-Archive -Path $phpZip -DestinationPath $phpDir -Force
    Remove-Item $phpZip -Force
}

# Configure php.ini
$phpIni = "$phpDir\php.ini"
if (-not (Test-Path $phpIni)) {
    if (Test-Path "$phpDir\php.ini-production") {
        Copy-Item "$phpDir\php.ini-production" $phpIni
    } elseif (Test-Path "$phpDir\php.ini-development") {
        Copy-Item "$phpDir\php.ini-development" $phpIni
    }
}

$iniContent = Get-Content $phpIni -Raw
$iniContent = $iniContent -replace ';extension_dir = "ext"', 'extension_dir = "ext"'
$requiredExtensions = @("curl", "fileinfo", "mbstring", "mysqli", "openssl", "pdo_mysql")
foreach ($ext in $requiredExtensions) {
    $iniContent = $iniContent -replace ";extension=$ext", "extension=$ext"
}
$iniContent = $iniContent -replace 'upload_max_filesize = 2M', 'upload_max_filesize = 64M'
$iniContent = $iniContent -replace 'post_max_size = 8M', 'post_max_size = 64M'
Set-Content $phpIni $iniContent
Write-Host "  PHP 8.3 configured with required extensions." -ForegroundColor Green

# Ensure C:\PHP is in PATH
$machinePath = [Environment]::GetEnvironmentVariable("Path", "Machine")
if ($machinePath -notlike "*$phpDir*") {
    [Environment]::SetEnvironmentVariable("Path", "$machinePath;$phpDir", "Machine")
    $env:Path += ";$phpDir"
}

Write-Host "[3/8] Deploying Web Backend to C:\inetpub\wwwroot\yaarsa..." -ForegroundColor Yellow
$yaarsaSource = "$BundleRoot\wwwroot_yaarsa"
$yaarsaDest = "C:\inetpub\wwwroot\yaarsa"
if (-not (Test-Path $yaarsaDest)) {
    New-Item -ItemType Directory -Path $yaarsaDest -Force | Out-Null
}
if (Test-Path $yaarsaSource) {
    Copy-Item -Path "$yaarsaSource\*" -Destination $yaarsaDest -Recurse -Force
}

# Grant IIS AppPool permissions
& icacls "$yaarsaDest" /grant "IIS_IUSRS:(OI)(CI)M" /T /Q
& icacls "$yaarsaDest" /grant "IUSR:(OI)(CI)M" /T /Q

Write-Host "[4/8] Configuring IIS FastCGI Handler for PHP..." -ForegroundColor Yellow
$appcmd = "$env:SystemRoot\system32\inetsrv\appcmd.exe"
if (Test-Path $appcmd) {
    # Register FastCGI Application
    & $appcmd set config /section:system.webServer/fastCgi "/+[fullPath='C:\PHP\php-cgi.exe']" /commit:apphost -ErrorAction SilentlyContinue

    # Add Handler Mapping
    & $appcmd set config /section:system.webServer/handlers "/+[name='PHP_via_FastCGI',path='*.php',verb='*',modules='FastCgiModule',scriptProcessor='C:\PHP\php-cgi.exe',resourceType='Unspecified']" /commit:apphost -ErrorAction SilentlyContinue

    # Set default document to index.php
    & $appcmd set config /section:system.webServer/defaultDocument "/+files.[value='index.php']" /commit:apphost -ErrorAction SilentlyContinue
}
Write-Host "  IIS FastCGI configured successfully." -ForegroundColor Green

Write-Host "[5/8] Configuring MySQL Database & Importing Backup..." -ForegroundColor Yellow
$mysqlBin = "C:\Program Files\MySQL\MySQL Server 8.4\bin\mysql.exe"
if (-not (Test-Path $mysqlBin)) {
    $mysqlCmd = Get-Command mysql.exe -ErrorAction SilentlyContinue
    if ($mysqlCmd) { $mysqlBin = $mysqlCmd.Source }
}

if (Test-Path $mysqlBin) {
    $sqlDump = "$BundleRoot\database\clients_backup.sql"
    if (Test-Path $sqlDump) {
        Write-Host "  Creating 'clients' database and importing dump..." -ForegroundColor DarkGray
        & $mysqlBin -u root -proot -e "CREATE DATABASE IF NOT EXISTS clients;"
        & $mysqlBin -u root -proot clients < $sqlDump
        Write-Host "  Database 'clients' imported successfully." -ForegroundColor Green
    }
} else {
    Write-Host "  [!] MySQL command line client not found automatically. Please ensure MySQL is installed with user 'root', password 'root', and import database\clients_backup.sql." -ForegroundColor Yellow
}

Write-Host "[6/8] Setting Up Node.js WebSocket Server under PM2..." -ForegroundColor Yellow
$nodeServerDir = "$yaarsaDest\server"
if (Test-Path $nodeServerDir) {
    Push-Location $nodeServerDir
    if (-not (Get-Command npm -ErrorAction SilentlyContinue)) {
        Write-Host "  [!] Node.js/npm not found in PATH. Please install Node.js LTS and run 'npm install -g pm2'." -ForegroundColor Red
    } else {
        npm install --silent
        if (-not (Get-Command pm2 -ErrorAction SilentlyContinue)) {
            Write-Host "  Installing PM2 globally..." -ForegroundColor DarkGray
            npm install -g pm2 --silent
        }
        pm2 stop websocket-server -ErrorAction SilentlyContinue
        pm2 delete websocket-server -ErrorAction SilentlyContinue
        pm2 start websocket-server.js --name "websocket-server"
        pm2 save
        Write-Host "  WebSocket server running on ports 8080 & 8888 under PM2." -ForegroundColor Green
    }
    Pop-Location
}

Write-Host "[7/8] Configuring Windows Firewall Rules..." -ForegroundColor Yellow
$firewallRules = @(
    @{ Name = "Meterverscore_HTTP_80"; Port = 80 },
    @{ Name = "Meterverscore_WS_8888"; Port = 8888 },
    @{ Name = "Meterverscore_WS_8080"; Port = 8080 },
    @{ Name = "Meterverscore_Auth_3000"; Port = 3000 }
)
foreach ($r in $firewallRules) {
    $exists = netsh advfirewall firewall show rule name="$($r.Name)" 2>$null
    if ($exists -match "No rules match") {
        netsh advfirewall firewall add rule name="$($r.Name)" dir=in action=allow protocol=TCP localport=$($r.Port) | Out-Null
    }
}
Write-Host "  Firewall rules added for ports 80, 8888, 8080, and 3000." -ForegroundColor Green

Write-Host "[8/8] Importing MCore Panel Registry Settings..." -ForegroundColor Yellow
$regFile = "$BundleRoot\registry\btmob_settings.reg"
if (Test-Path $regFile) {
    reg import $regFile
    Write-Host "  Registry settings imported successfully." -ForegroundColor Green
}

Write-Host ""
Write-Host "==========================================================" -ForegroundColor Green
Write-Host " Setup Completed Successfully!                           " -ForegroundColor Green
Write-Host " You can now launch MCore from Meterverscore2\2 MCore.   " -ForegroundColor Green
Write-Host "==========================================================" -ForegroundColor Green
