namespace DesignPatterns.Comportamentais.Mediator.Interfaces;

public interface ICoresSemaforoComponent
{
    ISemaforoMediator SemaforoMediator { get; set; }
    void ColocarMediatorParaUso(ISemaforoMediator semaforoMediator);
    void Acender();
    void Apagar();
}