namespace DesignPatterns.Estruturais.Proxy.Services.Interfaces;

internal interface ILogCustomizadoParaGeracaoDeArquivoService
{
    void GerarLogAntesDeGerarArquivo() => Console.WriteLine("Log antes de gerar arquivo");
    void GerarLogDepoisDeGerarArquivo() => Console.WriteLine("Log depois de gerar arquivo");
}
