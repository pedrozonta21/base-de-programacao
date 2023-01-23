using DesignPatterns.Estruturais.Proxy.Services.Interfaces;

namespace DesignPatterns.Estruturais.Proxy.Services;

internal class ProxyGerarArquivoMp3Service : IGerarArquivoMp3Service
{
    private readonly IGerarArquivoMp3Service _gerarArquivoMp3Service;
    private readonly ILogCustomizadoParaGeracaoDeArquivoService _logCustomizadoParaGeracaoDeArquivoService;

    public ProxyGerarArquivoMp3Service(
        IGerarArquivoMp3Service gerarArquivoMp3Service, 
        ILogCustomizadoParaGeracaoDeArquivoService logCustomizadoParaGeracaoDeArquivoService)
    {
        _gerarArquivoMp3Service = gerarArquivoMp3Service;
        _logCustomizadoParaGeracaoDeArquivoService = logCustomizadoParaGeracaoDeArquivoService;
    }

    public void GerarAquivoMp3(string caminhoParaSalvar)
    {
        _logCustomizadoParaGeracaoDeArquivoService.GerarLogAntesDeGerarArquivo();
        _gerarArquivoMp3Service.GerarAquivoMp3(caminhoParaSalvar);
        _logCustomizadoParaGeracaoDeArquivoService.GerarLogDepoisDeGerarArquivo();
    }
}
