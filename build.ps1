[CmdletBinding()]
param (
    [Parameter(Position = 0, ValueFromRemainingArguments = $true)]
    [string[]]$BuildArguments
)

$env:DOTNET_CLI_TELEMETRY_OPTOUT = 1
$env:DOTNET_SVCUTIL_TELEMETRY_OPTOUT = 1
$env:DOTNET_SKIP_FIRST_TIME_EXPERIENCE = 1
$env:DOTNET_NOLOGO = 1
$env:DOTNET_MULTILEVEL_LOOKUP = 0

$BuildProjectFile = "$PSScriptRoot\build\_build.csproj"

dotnet build $BuildProjectFile /nodeReuse:false /p:UseSharedCompilation=false -nologo -clp:NoSummary --verbosity quiet
dotnet run --project $BuildProjectFile --no-build -- $BuildArguments
