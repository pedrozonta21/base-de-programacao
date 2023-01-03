namespace DesignPatterns.Estruturais.Adapter.Services;

public class EnvioDeEmailService
{
    // Classe legada
    public void EnviarEmail(string email)
    {
        // Código legado
        Console.WriteLine($"e-mail enviado para {email}");
    }
}
