dotnet restore

dotnet build --configuration Debug
dotnet build --configuration Release

dotnet test -c Debug .\test\TauCode.Testing.Tests\TauCode.Testing.Tests.csproj
dotnet test -c Release .\test\TauCode.Testing.Tests\TauCode.Testing.Tests.csproj

nuget pack nuget\TauCode.Testing.nuspec
