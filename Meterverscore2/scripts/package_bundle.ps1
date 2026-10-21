# ==============================================================================
# Meterverscore2 Full Package & Export Script
# Creates a portable zip package containing the entire server stack, code,
# database dump, registry configuration, and automated installer.
# ==============================================================================

$ErrorActionPreference = "Stop"

Write-Host "==========================================================" -ForegroundColor Cyan
Write-Host " Packaging Meterverscore2 Full Environment...            " -ForegroundColor Cyan
Write-Host "==========================================================" -ForegroundColor Cyan

$Desktop = [Environment]::GetFolderPath("Desktop")
$ZipDestination = "$Desktop\Meterverscore_FullPackage.zip"
$StagingDir = "$env:TEMP\Meterverscore_Bundle_Staging"

if (Test-Path $StagingDir) {
    Remove-Item $StagingDir -Recurse -Force
}
New-Item -ItemType Directory -Path "$StagingDir\database" -Force | Out-Null
New-Item -ItemType Directory -Path "$StagingDir\registry" -Force | Out-Null
New-Item -ItemType Directory -Path "$StagingDir\scripts" -Force | Out-Null

# 1. Export MySQL Database
Write-Host "[1/5] Dumping MySQL 'clients' database..." -ForegroundColor Yellow
$mysqlDumpBin = "C:\Program Files\MySQL\MySQL Server 8.4\bin\mysqldump.exe"
if (-not (Test-Path $mysqlDumpBin)) {
    $mysqlDumpCmd = Get-Command mysqldump.exe -ErrorAction SilentlyContinue
    if ($mysqlDumpCmd) { $mysqlDumpBin = $mysqlDumpCmd.Source }
}
if (Test-Path $mysqlDumpBin) {
    & $mysqlDumpBin -u root -proot --routines --triggers --events clients > "$StagingDir\database\clients_backup.sql"
    Write-Host "  Database dumped to database\clients_backup.sql" -ForegroundColor Green
} else {
    Write-Host "  [!] mysqldump.exe not found. Skipping live dump." -ForegroundColor Red
}

# 2. Export Registry Settings
Write-Host "[2/5] Exporting MCore Registry Settings..." -ForegroundColor Yellow
reg export "HKCU\Software\BTMOB" "$StagingDir\registry\btmob_settings.reg" /y | Out-Null
Write-Host "  Registry exported to registry\btmob_settings.reg" -ForegroundColor Green

# 3. Copy yaarsa Web Root
Write-Host "[3/5] Copying C:\inetpub\wwwroot\yaarsa..." -ForegroundColor Yellow
$yaarsaSource = "C:\inetpub\wwwroot\yaarsa"
$yaarsaDest = "$StagingDir\wwwroot_yaarsa"
New-Item -ItemType Directory -Path $yaarsaDest -Force | Out-Null
robocopy $yaarsaSource $yaarsaDest /MIR /XD "logs" "errors" /XF "*.log" /R:1 /W:1 /NP /NFL /NDL | Out-Null
Write-Host "  Web backend copied to wwwroot_yaarsa" -ForegroundColor Green

# 4. Copy Meterverscore2 Codebase
Write-Host "[4/5] Copying Meterverscore2 Codebase..." -ForegroundColor Yellow
$mcoreSource = "C:\Users\auwalrg\Documents\Github projects\Meterverscore2"
$mcoreDest = "$StagingDir\Meterverscore2"
New-Item -ItemType Directory -Path $mcoreDest -Force | Out-Null
robocopy $mcoreSource $mcoreDest /MIR /XD ".vs" "obj" /XF "*.log" /R:1 /W:1 /NP /NFL /NDL | Out-Null
Write-Host "  Codebase copied to Meterverscore2" -ForegroundColor Green

# 5. Copy Setup Script
Copy-Item "$mcoreSource\scripts\setup_new_pc.ps1" "$StagingDir\scripts\setup_new_pc.ps1" -Force

# 6. Compress Everything to ZIP
Write-Host "[5/5] Compressing full package to $ZipDestination..." -ForegroundColor Yellow
if (Test-Path $ZipDestination) {
    Remove-Item $ZipDestination -Force
}
Compress-Archive -Path "$StagingDir\*" -DestinationPath $ZipDestination -CompressionLevel Optimal

# Cleanup staging
Remove-Item $StagingDir -Recurse -Force

Write-Host ""
Write-Host "==========================================================" -ForegroundColor Green
Write-Host " Packaging Completed!                                     " -ForegroundColor Green
Write-Host " Package created at: $ZipDestination" -ForegroundColor Green
Write-Host "==========================================================" -ForegroundColor Green
