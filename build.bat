@echo off
set SOURCE="https://github.com/Trust-Anchor-Group/AgentApiYaml/blob/main/openapi.yaml?raw=true"
set OUTPUT_DIR="./build"
set JAR_FILE="swagger-codegen-cli.jar"
set JAR_URL="https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.50/swagger-codegen-cli-3.0.50.jar"

:: Check if swagger-codegen-cli.jar exists
if not exist "%JAR_FILE%" (
    echo swagger-codegen-cli.jar not found, downloading...
    PowerShell -Command "& { Invoke-WebRequest -Uri '%JAR_URL%' -OutFile '%JAR_FILE%' }"
)

:: Run Swagger Codegen
java -jar "%JAR_FILE%" generate -i %SOURCE% -l csharp -o "%OUTPUT_DIR%" -c ./config.json

:: Pause the script to view any messages
pause
