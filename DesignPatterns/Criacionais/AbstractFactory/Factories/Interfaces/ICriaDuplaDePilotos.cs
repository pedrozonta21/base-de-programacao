using DesignPatterns.Criacionais.AbstractFactory.Pilotos.Interfaces;

namespace DesignPatterns.Criacionais.AbstractFactory.Factories.Interfaces;

// Pode ser usado um Factory Method para resolver cada fábrica
internal interface ICriaDuplaDePilotosAbstractFactory
{
    IPrimeiroPiloto CriarPrimeiroPiloto();
    ISegundoPiloto CriarSegundoPiloto();
}
