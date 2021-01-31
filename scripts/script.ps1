Write-Host "Downloading DocFX"
Invoke-WebRequest https://github.com/dotnet/docfx/releases/download/v2.56.6/docfx.zip -o docfx.zip 
Write-Host "Downloading template"
Invoke-WebRequest https://github.com/jbltx/DiscordFX/archive/v0.3.zip -o template.zip
mkdir .\Carrow\Docs\templates
Write-Host "Extracting DocFx"
Expand-Archive docfx.zip -DestinationPath .\docfx -Verbose
Write-Host "Extracting Template"
Expand-Archive template.zip -DestinationPath .\Carrow\Docs\templates -Verbose
Move-Item .\Carrow\Docs\templates\DiscordFX-0.3\discordfx\* .\Carrow\Docs\templates\discordfx
.\docfx\docfx.exe .\Carrow\Docs\docfx.json
Write-Host "Compressing Site"
Compress-Archive .\Carrow\Docs\_site\* -DestinationPath .\site.zip -CompressionLevel Optimal