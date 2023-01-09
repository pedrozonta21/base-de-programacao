namespace DesignPatterns.Estruturais.Bridge.Folha;

internal class FolhaBranca : ITipoFolha
{
    public string TextoDaFolha { get; set; }

    public ITipoFolha CriarNovaFolha() => new FolhaBranca();

    public void Escrever(string texto) => TextoDaFolha = texto;

    public string RetornarTipoDaFolha() => "Branca";
}
