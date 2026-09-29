namespace MeuPrimeiroTeste.App;

public class HelloWorldService
{
    public string GerarSaudacao(string? nome)
    {
        if (string.IsNullOrEmpty(nome))
        {
            return "Olá, Mundo!";
        }

        return $"Hello, {nome}!";
    }
}
