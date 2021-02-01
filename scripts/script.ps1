Write-Host "Downloading DocFX"
Invoke-WebRequest https://github.com/dotnet/docfx/releases/download/v2.56.6/docfx.zip -o docfx.zip 
Write-Host "Downloading template"
Invoke-WebRequest https://github.com/jbltx/DiscordFX/archive/v0.3.zip -o template.zip
mkdir .\Carrow\Docs\templates
Write-Host "Extracting DocFx"
Expand-Archive docfx.zip -DestinationPath .\docfx -Verbose
Write-Host "Extracting Template"
Expand-Archive template.zip -DestinationPath .\Carrow\Docs\templates -Verbose
#https://github.com/ovasquez/docfx-material/releases/download/0.5.0/material.zip
Move-Item -Path .\Carrow\Docs\templates\DiscordFX-0.3\discordfx -Destination .\Carrow\Docs\templates\discordfx
Write-Host "Building documentation"
.\docfx\docfx.exe .\Carrow\Docs\docfx.json
Write-Host "Compressing Site"
mkdir release
Copy-Item .\Dockerfile .\release\
Copy-Item .\scripts\release.ps1 .\release\
Compress-Archive .\Carrow\Docs\_site -DestinationPath .\release\site.zip -CompressionLevel Optimal
Get-ChildItem .\release