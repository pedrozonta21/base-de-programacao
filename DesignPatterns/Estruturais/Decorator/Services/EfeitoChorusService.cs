using DesignPatterns.Estruturais.Decorator.Services.Interfaces;

namespace DesignPatterns.Estruturais.Decorator.Services;

internal class EfeitoChorusService : EfeitoBaseDecoratorService
{
    public EfeitoChorusService(IEfeito efeito) : base(efeito)
    {
    }

    public override string AlterarTimbre() => $"Chorus({base.AlterarTimbre()})";
}
