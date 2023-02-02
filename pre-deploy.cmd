dotnet restore

dotnet build TauCode.Testing.sln -c Debug
dotnet build TauCode.Testing.sln -c Release

dotnet test TauCode.Testing.sln -c Debug
dotnet test TauCode.Testing.sln -c Release

nuget pack nuget\TauCode.Testing.nuspec