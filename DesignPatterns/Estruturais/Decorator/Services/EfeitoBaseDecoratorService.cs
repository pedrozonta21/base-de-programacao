using DesignPatterns.Estruturais.Decorator.Services.Interfaces;

namespace DesignPatterns.Estruturais.Decorator.Services;

internal class EfeitoBaseDecoratorService : IEfeito
{
    protected IEfeito Efeito;

    public EfeitoBaseDecoratorService(IEfeito efeito) => Efeito = efeito;

    public virtual string AlterarTimbre() => Efeito.AlterarTimbre();

    public void AtribuirNovaClasseDeEfeito(IEfeito efeito) => Efeito = efeito;
}
