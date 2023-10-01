using DesignPatterns.Comportamentais.Mediator.Interfaces;

namespace DesignPatterns.Comportamentais.Mediator;

public class CorVermelhaSemaforoComponent : ICoresSemaforoComponent
{
    public ISemaforoMediator SemaforoMediator { get; set; }
    
    public void ColocarMediatorParaUso(ISemaforoMediator semaforoMediator) => SemaforoMediator = semaforoMediator;
    
    public void Acender()
    {
        Console.WriteLine("Cor vermelha acesa.");
        SemaforoMediator.RealizarAlteracoesAoAcender(this);
    }

    public void Apagar() => Console.WriteLine("Cor vermelha apagada.");
}