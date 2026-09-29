# hello-world-xunit

Projeto de estudo em C# / .NET com testes unitários usando [xUnit](https://xunit.net/).

## Estrutura

```
MeuPrimeiroTeste.slnx
├── MeuPrimeiroTeste.App     # Aplicação console + HelloWorldService
└── MeuPrimeiroTeste.Tests   # Testes xUnit do HelloWorldService
```

## Pré-requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download)

## Como usar

```bash
# Executar a aplicação
dotnet run --project MeuPrimeiroTeste.App

# Executar os testes
dotnet test
```

## Licença

Distribuído sob a licença MIT. Veja o arquivo [LICENSE](LICENSE).
