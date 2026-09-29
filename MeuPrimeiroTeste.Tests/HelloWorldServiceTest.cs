using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class HelloWorldServiceTest
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio(string? nome)
    {
        // Arrange
        var service = new HelloWorldService();

        // Act
        var resultado = service.GerarSaudacao(nome);

        // Assert
        Assert.Equal("Olá, Mundo!", resultado);
    }

    [Fact]
    public void GerarSaudacao_DeveIncluirONome_QuandoNomeForInformado()
    {
        // Arrange
        var service = new HelloWorldService();

        // Act
        var resultado = service.GerarSaudacao("Caio");

        // Assert
        Assert.Equal("Hello, Caio!", resultado);
    }
}
