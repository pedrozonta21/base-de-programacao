using DesignPatterns.Estruturais.Decorator.Services.Interfaces;

namespace DesignPatterns.Estruturais.Decorator.Services;

internal class EfeitoCleanService : IEfeito
{
    public string AlterarTimbre() => "Efeito Clean padrão.";
}
