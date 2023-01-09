using DesignPatterns.Estruturais.Bridge.Folha;

namespace DesignPatterns.Estruturais.Bridge.Caderno;

internal class CadernoCapaMole : CadernoBase
{
    public CadernoCapaMole(ITipoFolha tipoFolha) : base(tipoFolha)
    {
    }

    public override string RetornarTipoDeCapa() => "Capa mole";
}
