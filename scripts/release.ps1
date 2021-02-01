Expand-Archive release.zip -DestinationPath .\release -Verbose
docker run -d -p 4200:80 --name documentator documentor:0.1.1