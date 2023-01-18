namespace DesignPatterns.Estruturais.Facade.Services.Interfaces;

internal interface IQrCodeFacadeService
{
    string GerarQrCode(object conteudo);
}
