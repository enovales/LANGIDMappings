#!/usr/bin/env bash

set -eu
set -o pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

TARGET="${1:-build}"

case "$TARGET" in
    clean)
        dotnet clean
        ;;
    restore)
        dotnet restore
        ;;
    build)
        dotnet build
        ;;
    test)
        dotnet test
        ;;
    pack)
        if [ -z "${2:-}" ]; then
            echo "Please specify a version for pack"
            exit 1
        fi
        dotnet pack -p:PackageVersion="$2"
        ;;
    *)
        echo "Unknown target: $TARGET"
        echo "Available targets: clean, restore, build, test, pack <version>"
        exit 1
        ;;
esac
