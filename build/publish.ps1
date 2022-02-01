# Get repository root.
$root = Resolve-Path (Join-Path $PSScriptRoot "..")

# Find project file.
$project = "$root/src/ToddlerTyper/ToddlerTyper.csproj"

# Set output directory.
$output = "$root/artifacts"

# Generate version number based on the current timestamp.
# Must be of the format [0-255].[0-255].[0-65535]
$timestamp = [DateTimeOffset]::UtcNow
$startOfMonth = New-Object -TypeName System.DateTimeOffset -ArgumentList $timestamp.UtcDateTime.Year, $timestamp.UtcDateTime.Month, 1, 0, 0, 0, 0
$major = $timestamp.UtcDateTime.Year - 2000
$minor = $timestamp.UtcDateTime.Month
$build = 10000 + [Convert]::ToUInt16(($timestamp - $startOfMonth).TotalMinutes)
$version = New-Object -TypeName System.Version -ArgumentList $major, $minor, $build, 0

# Publish the project.
dotnet publish $project --output $output --runtime win-x64 --configuration Release --self-contained true -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:EnableCompressionInSingleFile=true -p:IncludeAllContentForSelfExtract=true -p:Version=$version
