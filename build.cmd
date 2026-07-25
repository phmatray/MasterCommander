@echo off

set DOTNET_CLI_TELEMETRY_OPTOUT=1
set DOTNET_SVCUTIL_TELEMETRY_OPTOUT=1
set DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
set DOTNET_NOLOGO=1
set DOTNET_MULTILEVEL_LOOKUP=0

dotnet build "%~dp0build\_build.csproj" /nodeReuse:false /p:UseSharedCompilation=false -nologo -clp:NoSummary --verbosity quiet
dotnet run --project "%~dp0build\_build.csproj" --no-build -- %*
