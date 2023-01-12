using DesignPatterns.Estruturais.Decorator.Services.Interfaces;

namespace DesignPatterns.Estruturais.Decorator.Services;

internal class EfeitoDriveService : EfeitoBaseDecoratorService
{
    public EfeitoDriveService(IEfeito efeito) : base(efeito)
    {
    }
    
    public override string AlterarTimbre() => $"Drive({base.AlterarTimbre()})";
}
