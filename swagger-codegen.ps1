Invoke-WebRequest -OutFile api-swagger.json http://localhost:5000/tools/swagger/v1/swagger.json
java -jar swagger-codegen-cli.jar generate -i api-swagger.json -l typescript-angular -o src/backend