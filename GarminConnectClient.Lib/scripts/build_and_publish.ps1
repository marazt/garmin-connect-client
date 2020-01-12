# This script uses configuration from NuGet.config file, see https://docs.microsoft.com/cs-cz/nuget/reference/cli-reference/cli-ref-setapikey.
# To add proper API key for source, use command (sample for Nuget.org) `nuget setapikey API_KEY -Source https://www.nuget.org/api/v2/package`.

$Publishing = @(
	@{
		Source="nuget.org"
	}
)

Write-Host "Building project."
dotnet build --configuration Release

Write-Host "Creating NuGet package."
dotnet pack --configuration Release

$releaseDir = "./bin/Release"
$NewestPackage = Get-ChildItem -Path $releaseDir -Filter "*.nupkg" | Sort-Object LastAccessTime -Descending | Select-Object -First 1

foreach ($Target in $Publishing) {
	Write-Host "Publishing NuGet package $($NewestPackage.name) to $($Target.Source)."
	dotnet nuget push "$releaseDir/$($NewestPackage.name)" --source $($Target.Source)
}
