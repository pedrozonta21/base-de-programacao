namespace DesignPatterns.Estruturais.Composite;

internal abstract class Familia
{
    public string Nome { get; set; }

    public abstract string CriarNome();

    public virtual void AdicionarFilho(Familia filho)
    {

    }

    public virtual void RemoverFilho(Familia filho)
    {

    }

    public virtual bool IsGrupoDeFamilia() => true;
}
