##Install Task file [TaskFile](https://taskfile.dev/installation/)
```bash
brew install go-task/tap/go-task
# or
sudo snap install task --classic
```
##Commands of task file 
```bash
# generate package with version, can be something like 1.0.1 
task profile -- VERSION
```

##helpers for open api generator

```shell
java -jar openapi-generator-cli-6.2.0.jar help generate

java -jar openapi-generator-cli-6.2.0.jar config-help -g csharp-netcore

```

> for generating profile wire 
- first generate the package
```
java -jar openapi-generator-cli-6.2.0.jar generate -i http://localhost:4001/swagger/v1/swagger.json -g csharp-netcore -c profile.json -o profile.wire
```
- then change package details like version and c# version (8), author, and package repository witch is 
`https://github.com/miladbonakdar/tp.wire`
- then build in release mode and publish the new generated package with:
```bash
cd profile.wire/src/profile.wire
dotnet nuget push "bin/Release/profile.wire.1.x.x.nupkg" --source "github"

```

[for for information you can take a look at this](https://openapi-generator.tech/docs/generators/csharp-netcore/)
