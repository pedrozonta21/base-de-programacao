namespace DesignPatterns.Estruturais.Bridge.Folha;

internal class FolhaReciclavel : ITipoFolha
{
    public string TextoDaFolha { get; set; }

    public ITipoFolha CriarNovaFolha() => new FolhaReciclavel();

    public void Escrever(string texto) => TextoDaFolha = texto;

    public string RetornarTipoDaFolha() => "Reciclável";
}
