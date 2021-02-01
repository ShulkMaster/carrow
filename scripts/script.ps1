Write-Host "Downloading DocFX"
Invoke-WebRequest https://github.com/dotnet/docfx/releases/download/v2.56.6/docfx.zip -o docfx.zip 
Write-Host "Downloading template"
Invoke-WebRequest https://github.com/jbltx/DiscordFX/archive/v0.3.zip -o template.zip
mkdir .\Carrow\Docs\templates
Write-Host "Extracting DocFx"
Expand-Archive docfx.zip -DestinationPath .\docfx -Verbose
Write-Host "Extracting Template"
Expand-Archive template.zip -DestinationPath .\Carrow\Docs\templates -Verbose
Move-Item -Path .\Carrow\Docs\templates\DiscordFX-0.3\discordfx -Destination .\Carrow\Docs\templates\discordfx
Write-Host "Building documentation"
.\docfx\docfx.exe .\Carrow\Docs\docfx.json
Write-Host "Moving files to ArtifactStage"
mkdir ArtifactStage
Copy-Item .\Dockerfile .\ArtifactStage\
Copy-Item .\scripts\release.ps1 .\ArtifactStage\
Copy-Item .\Carrow\Docs\_site .\ArtifactStage\site\