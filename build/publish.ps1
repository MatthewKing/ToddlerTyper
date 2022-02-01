$root = Resolve-Path (Join-Path $PSScriptRoot "..")
$project = "$root/src/ToddlerTyper/ToddlerTyper.csproj"
$output = "$root/artifacts"
dotnet publish $project --output $output --runtime win-x64 --configuration Release --self-contained true -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:EnableCompressionInSingleFile=true -p:IncludeAllContentForSelfExtract=true
