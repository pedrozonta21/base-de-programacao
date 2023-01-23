using DesignPatterns.Estruturais.Proxy.Services.Interfaces;

namespace DesignPatterns.Estruturais.Proxy.Services;

internal class GerarArquivoMp3Service : IGerarArquivoMp3Service
{
    public void GerarAquivoMp3(string caminhoParaSalvar)
    {
        Console.WriteLine("Arquivo Mp3 gerado");
    }
}
