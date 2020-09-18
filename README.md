# KT-DevOps

To create a .exe file: ```dotnet publish -c Release -r win10-x64```

To run after build: ```Calculator/bin/Release/netcoreapp3.1/Calculator.exe```

To test: ```dotnet test```

## Pipeline 1 - Only test
```
trigger:
- master

pool:
  vmImage: 'ubuntu-latest'

steps:
- script: dotnet test
  displayName: Time to test it!
```

## Pipeline 2 - Test and build
```
trigger:
- master

pool:
  vmImage: 'ubuntu-latest'

steps:
- script: dotnet test
  displayName: Time to test it!

- script: dotnet publish -c Release -r win10-x64
  displayName: Time to publish it! 
```

## Pipeline 3 - Adding stages and jobs
```
trigger:
- master

pool:
  vmImage: 'ubuntu-latest'

stages:
- stage: Test
  jobs: 
  - job: dotnetTestAgent
    steps:
    - script: dotnet test
      displayName: Time to test it!

- stage: Build
  jobs: 
  - job: dotnetBuildAgent
    steps:
    - script: dotnet publish -c Release -r win10-x64
      displayName: Time to publish it!
```

## Pipeline 4 - Adding more jobs
```
trigger:
- master

pool:
  vmImage: 'ubuntu-latest'

stages:
- stage: Test
  jobs: 
  - job: dotnetTestAgent
    steps:
    - script: dotnet test
      displayName: Time to test it!

- stage: Build
  dependsOn: Test
  jobs: 
  - job: buildWindows
    steps:
    - script: dotnet publish -c Release -r win10-x64
      displayName: Time to publish it!
  - job: buildLinux
    steps:
    - script: dotnet publish -c Release -r linux-x64
      displayName: Time to publish it!
```
