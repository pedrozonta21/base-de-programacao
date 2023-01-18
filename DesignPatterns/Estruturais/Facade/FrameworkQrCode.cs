namespace DesignPatterns.Estruturais.Facade;

internal class FrameworkQrCode
{
    public string GerarQrCode(object conteudo) => conteudo.ToString();

    public void LerQrCode(object info) { }

    public bool VAlidarQrCode(object conteudo) => true;
}
