namespace DesignPatterns.Estruturais.Composite;

internal class Filho : Familia
{
    public override string CriarNome() => Nome;

    public override bool IsGrupoDeFamilia() => false;
}
