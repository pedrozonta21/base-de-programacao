namespace DesignPatterns.Estruturais.Composite;

internal class MaeComposite : Familia
{
    private List<Familia> _filhos;

    public MaeComposite() => _filhos = new();

    public override string CriarNome()
    {
        var nomeDosFilhos = string.Empty;

        _filhos.ForEach(filho =>
        {
            nomeDosFilhos += @$"♥ {filho.CriarNome()} ♥";
        });

        return $"{Nome} é mãe de: ({nomeDosFilhos})";
    }

    public override void AdicionarFilho(Familia filho) => _filhos.Add(filho);

    public override void RemoverFilho(Familia filho) => _filhos.Remove(filho);
}
