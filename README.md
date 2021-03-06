﻿# Carrow

## Disclaimer
This is a net standard library use for demo purposes alone
none of the code feature in here is meant to be a reference
for any good practice or code style, only for *pipeline devops*
setup in [Azure pipelines](https://azure.microsoft.com/en-us/services/devops/pipelines/).

## Scope
This simple project should be enough to get you started creating
a pipeline for CI/DC integration in your project, we'll cover steps as follow
- Load dependencies from nuget or a custom Azure Artifacts repo
- Build the project for multiple targets
- Test your project
- Collect test result and coverage for further review in Azure test view
- Packaging your DLL as a nuget package
- Publishing a Nuget package to a private Azure Artifacts repo
- Consume the publish package in other project

😉

## Resources
- [XML documentation for C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/)
- [XML documentation Generation](https://docs.microsoft.com/en-us/dotnet/csharp/codedoc)
- [DocFX](https://dotnet.github.io/docfx/)
- [Packaging libraries with dotnet CLI](https://docs.microsoft.com/en-us/nuget/create-packages/creating-a-package-dotnet-cli)
- [Upload coverage task](https://docs.microsoft.com/en-us/azure/devops/pipelines/test/review-code-coverage-results?view=azure-devops)
- [Credentials provider](https://github.com/microsoft/artifacts-credprovider#azure-artifacts-credential-provider)
- [Release pipeline Artifact permission](https://docs.microsoft.com/en-us/azure/devops/artifacts/feeds/feed-permissions?view=azure-devops)
- [Predefined variables in Pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/build/variables?view=azure-devops&tabs=yaml)