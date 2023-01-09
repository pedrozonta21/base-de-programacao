using DesignPatterns.Estruturais.Bridge.Folha;

namespace DesignPatterns.Estruturais.Bridge.Caderno;

internal class CadernoCapaDura : CadernoBase
{
    public CadernoCapaDura(ITipoFolha tipoFolha) : base(tipoFolha)
    {
    }

    public override string RetornarTipoDeCapa() => "Capa dura";
}
