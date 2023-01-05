namespace DesignPatterns.Estruturais.Composite;

internal class PaiComposite : Familia
{
    private List<Familia> _filhos;

    public PaiComposite() => _filhos = new();

    public override string CriarNome()
    {
        var nomeDosFilhos = string.Empty;

        _filhos.ForEach(filho =>
        {
            nomeDosFilhos += @$" {filho.CriarNome()} ";
        });

        return $"{Nome} tem os filhos: ({nomeDosFilhos})";
    }

    public override void AdicionarFilho(Familia filho) => _filhos.Add(filho);

    public override void RemoverFilho(Familia filho) => _filhos.Remove(filho);
}
