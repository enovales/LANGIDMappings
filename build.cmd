@echo off
SETLOCAL EnableDelayedExpansion

set "SCRIPT_DIR=%~dp0"

if "%1"=="" (
    echo Running default target: build
    dotnet build
) else if "%1"=="clean" (
    dotnet clean
) else if "%1"=="restore" (
    dotnet restore
) else if "%1"=="test" (
    dotnet test
) else if "%1"=="pack" (
    if "%2"=="" (
        echo Please specify a version for pack
        exit /b 1
    )
    dotnet pack -p:PackageVersion=%2
) else (
    echo Unknown target: %1
    echo Available targets: clean, restore, build, test, pack
    exit /b 1
)
