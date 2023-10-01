using DesignPatterns.Comportamentais.Mediator.Interfaces;

namespace DesignPatterns.Comportamentais.Mediator;

public class CorAmarelaSemaforoComponent: ICoresSemaforoComponent
{
    public ISemaforoMediator SemaforoMediator { get; set; }
    
    public void ColocarMediatorParaUso(ISemaforoMediator semaforoMediator) => SemaforoMediator = semaforoMediator;
    
    public void Acender()
    {
        Console.WriteLine("Cor amarela acesa.");
        SemaforoMediator.RealizarAlteracoesAoAcender(this);
    }

    public void Apagar() => Console.WriteLine("Cor amarela apagada.");
}