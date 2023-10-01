using DesignPatterns.Comportamentais.Mediator.Interfaces;

namespace DesignPatterns.Comportamentais.Mediator;

public class SemaforoMediator : ISemaforoMediator
{
    private readonly CorAmarelaSemaforoComponent _corAmarelaSemaforoComponent;
    private readonly CorVerdeSemaforoComponent _corVerdeSemaforoComponent;
    private readonly CorVermelhaSemaforoComponent _corVermelhaSemaforoComponent;
    
    public SemaforoMediator(
        CorAmarelaSemaforoComponent corAmarelaSemaforoComponent, 
        CorVerdeSemaforoComponent corVerdeSemaforoComponent, 
        CorVermelhaSemaforoComponent corVermelhaSemaforoComponent)
    {
        _corAmarelaSemaforoComponent = corAmarelaSemaforoComponent;
        _corAmarelaSemaforoComponent.ColocarMediatorParaUso(this);
        _corVerdeSemaforoComponent = corVerdeSemaforoComponent;
        _corVerdeSemaforoComponent.ColocarMediatorParaUso(this);
        _corVermelhaSemaforoComponent = corVermelhaSemaforoComponent;
        _corVermelhaSemaforoComponent.ColocarMediatorParaUso(this);
    }

    public void RealizarAlteracoesAoAcender(object sender)
    {
        switch (sender)
        {
            case CorVermelhaSemaforoComponent:
                _corAmarelaSemaforoComponent.Apagar();
                _corVerdeSemaforoComponent.Apagar();
                break;
            case CorAmarelaSemaforoComponent:
                _corVermelhaSemaforoComponent.Apagar();
                _corVerdeSemaforoComponent.Apagar();
                break;
            case CorVerdeSemaforoComponent:
                _corVermelhaSemaforoComponent.Apagar();
                _corAmarelaSemaforoComponent.Apagar();
                break;
        }
    }
}