# RandomNumbers
Um exe que gera um número aleatório, junto com a src.

# Comandos para executar:

```
dotnet new console -n RandomNumbers
```
```
dotnet build -c Release
```
```
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
```

## Executar o arquivo executável:

Após a conclusão do passo anterior, você encontrará o arquivo executável na pasta `bin\Release\netcoreapp3.1\win-x64\publish` (ou uma localização semelhante).
Execute o arquivo .exe para rodar o seu programa.
