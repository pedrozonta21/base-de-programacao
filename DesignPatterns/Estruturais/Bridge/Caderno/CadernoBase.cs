using DesignPatterns.Estruturais.Bridge.Folha;

namespace DesignPatterns.Estruturais.Bridge.Caderno;

internal class CadernoBase
{
    protected ITipoFolha _tipoFolha;
    public List<ITipoFolha> Folhas;

    public CadernoBase(ITipoFolha tipoFolha) => _tipoFolha = tipoFolha;

    public void AbrirCaderno() 
    { 
        // ...
    }

    public void FecharCaderno()
    {
        // ...
    }

    public void CriarFolhas(int quantidade) 
        => Folhas = Enumerable.Range(1, quantidade).Select(numeroDaFolha => _tipoFolha.CriarNovaFolha()).ToList();

    public int RetornarQuantidadeDeFolhas() => Folhas.Count;

    public void Escrever(string texto, ITipoFolha folha) => folha.Escrever(texto);

    public string RetornarTipoDaFolha() => _tipoFolha.RetornarTipoDaFolha();

    public virtual string RetornarTipoDeCapa() => "Sem capa";
}
