# Deployf Cli

## Installation

### 🪟 via powershell
```powershell
> Invoke-WebRequest -Uri https://github.com/deploy-f/df-cli/releases/download/v0.2/df.exe -OutFile df.exe
```

### 🐧 on generic linux
```bash
$ curl -LO https://github.com/deploy-f/df-cli/releases/download/v0.2/df
```

### Via nuget on any platform

```bash
dotnet tool install --global Deployf.Cli --version 0.3.0
```

## Usage

### Set the token
Go to https://v2.d-f.pw/id/Manage/ListPersonalTokens and create a prsonal token.
When you have the token, you can save it locally via `df init $TOKEN` command.
Or use the `TOKEN` environment to pass the token. Instead environment variable
you can use `--token $TOKEN` key.

## how to build an exe
```bash
# building for windows
$ dotnet publish -c Release -r win-x64 -o publish \
	-p:PublishSingleFile=true --self-contained \
	-p:SelfContained=true -p:PublishTrimmed=true

# building for linux
$ dotnet publish -c Release -r linux-x64 -o publish \
	-p:PublishSingleFile=true --self-contained \
	-p:SelfContained=true -p:PublishTrimmed=true
```