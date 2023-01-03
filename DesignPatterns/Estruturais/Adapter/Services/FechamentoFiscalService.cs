using DesignPatterns.Estruturais.Adapter.Services.Interfaces;

namespace DesignPatterns.Estruturais.Adapter.Services;

public class FechamentoFiscalService
{
	private readonly IEnvioDeEmailService _envioDeEmailService;

    public FechamentoFiscalService(IEnvioDeEmailService envioDeEmailService) => _envioDeEmailService = envioDeEmailService;

    public void EnviarEmailDeFechamento()
    {
        _envioDeEmailService.EnviarEmail();
    }
}
