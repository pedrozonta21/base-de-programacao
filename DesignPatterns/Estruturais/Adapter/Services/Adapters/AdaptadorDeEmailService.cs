using DesignPatterns.Estruturais.Adapter.Services.Interfaces;

namespace DesignPatterns.Estruturais.Adapter.Services.Adapters;

public class AdaptadorDeEmailService : IEnvioDeEmailService
{
    private readonly EnvioDeEmailService _envioDeEmailService;

    public AdaptadorDeEmailService() => _envioDeEmailService = new EnvioDeEmailService();

    public void EnviarEmail()
    {
        _envioDeEmailService.EnviarEmail("email@emailcom");
    }
}
