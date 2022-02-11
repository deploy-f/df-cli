# Deployf Cli


## how to build an exe
```
dotnet publish -c Release -r win-x64 -o publish -p:PublishSingleFile=true --self-contained -p:SelfContained=true -p:PublishTrimmed=true
```