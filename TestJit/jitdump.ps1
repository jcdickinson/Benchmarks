param(
    [Parameter(Mandatory=$false,
               HelpMessage="The location of the CoreCLR build.")]
    [ValidateNotNullOrEmpty()]
    [string] $CoreCLRBuild,

    [Parameter(Mandatory=$false,
               Position=0,
               HelpMessage="The output filename of the project.")]
    [ValidateNotNullOrEmpty()]
    [string] $ProjectOutput,

    [Parameter(Mandatory=$true,
               Position=1,
               ParameterSetName="Method",
               ValueFromPipelineByPropertyName=$true,
               HelpMessage="The methods to dump.")]
    [Alias("PSPath")]
    [ValidateNotNullOrEmpty()]
    [string[]] $Method,

    [Parameter(Mandatory=$false,
               HelpMessage="Indicates that ASM output should be diffable.")]
    [switch] $Diffable
)

# Get CoreCLRBuild default value and validate that it exists.

if (-not $CoreCLRBuild) {
    if (Test-Path Env:CORECLR_DEBUG) {
        $CoreCLRBuild = $Env:CORECLR_DEBUG
    } else {
        Write-Error "The CoreCLRBuild parameter is required if the CORECLR_DEBUG environment variable is not set."
        exit -1
    }
}

if (-not (Test-Path $CoreCLRBuild))
{
    Write-Error "The path to the CoreCLR Build $CoreCLRBuild does not exist."
    exit -2
}

# Build the project.

dotnet publish -c Release -r win10-x64
$ExitCode = $LASTEXITCODE

if ($ExitCode -ne 0)
{
    Write-Error "dotnet publish failed."
    exit $ExitCode
}

# Check that the correct build happened.

$RelativeOutput = "bin\Release\netcoreapp2.0\win10-x64"
$ProjectDirectory = Join-Path $PWD $RelativeOutput
$PublishDirectory = Join-Path $ProjectDirectory "publish"
$ProjectBinary = Join-Path $ProjectDirectory $ProjectOutput

if (-not (Test-Path $ProjectBinary))
{
    Write-Error "The project binary $ProjectBinary could not be found."
    exit -3
}

# Replace published CoreCLR with debug CoreCLR

Robocopy /E /NDL /NJH /NJS /NP /NS /NC $CoreCLRBuild $PublishDirectory
Write-Host ""

# Set up CoreCLR environment variables.

$Env:CORE_ROOT=$ProjectDirectory
$Env:CORE_LIBRARIES=$PublishDirectory

if ($Diffable) {
    $Env:COMPlus_JitDiffableDasm=1
} else {
    $Env:COMPlus_JitDiffableDasm=0
}

$Methods = [string]::Join(";",$Method)
$Env:COMPLUS_JitDump = $Methods

$OutputFile = Join-Path $PWD "$ProjectOutput.$(Get-Date -f yyyy-MM-dd.HH-mm-ss).jit"
Push-Location -Path $ProjectDirectory

try
{
    .\publish\corerun $ProjectOutput > $OutputFile
    Write-Host "  ILDump -> $OutputFile"
}
finally
{
    Pop-Location
}