@echo off
msbuild StringInterpolationBridge\StringInterpolationBridge.Net40.csproj /p:Configuration=Release
nuget pack StringInterpolationBridge\StringInterpolationBridge.csproj -Build -Properties Configuration=Release