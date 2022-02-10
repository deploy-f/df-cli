#!/bin/sh

curl http://localhost:5000/tools/swagger/v1/swagger.json > api-swagger.json
java -jar swagger-codegen-cli.jar generate -i api-swagger.json -l typescript-angular -o src/backend