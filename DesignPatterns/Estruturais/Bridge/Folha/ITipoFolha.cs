namespace DesignPatterns.Estruturais.Bridge.Folha;

internal interface ITipoFolha
{
    string TextoDaFolha { get; set; }
    string RetornarTipoDaFolha();
    ITipoFolha CriarNovaFolha();
    void Escrever(string texto);
}
