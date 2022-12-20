using DesignPatterns.Criacionais.AbstractFactory.Factories.Interfaces;
using DesignPatterns.Criacionais.AbstractFactory.Pilotos.Interfaces;
using DesignPatterns.Criacionais.AbstractFactory.Pilotos.Models;

namespace DesignPatterns.Criacionais.AbstractFactory.Factories;

internal class CriaDuplaDePilotosRedBullFactory : ICriaDuplaDePilotosAbstractFactory
{
    public IPrimeiroPiloto CriarPrimeiroPiloto()
    {
        return new PrimeiroPilotoModel
        {
            AnosDeExperiencia = 6,
            Nome = "Max Verstappen"
        };
    }

    public ISegundoPiloto CriarSegundoPiloto()
    {
        return new SegundoPilotoModel
        {
            Nome = "Sergio Perez",
            DeveAjudarPrimeiroPiloto = true
        };
    }
}
