using DesignPatterns.Estruturais.Decorator.Services.Interfaces;

namespace DesignPatterns.Estruturais.Decorator.Services;

internal class EfeitoReverbService : EfeitoBaseDecoratorService
{
    public EfeitoReverbService(IEfeito efeito) : base(efeito)
    {
    }

    public override string AlterarTimbre() => $"Reverb({base.AlterarTimbre()})";
}
