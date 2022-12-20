using DesignPatterns.Criacionais.AbstractFactory.Factories.Interfaces;
using DesignPatterns.Criacionais.AbstractFactory.Pilotos.Interfaces;
using DesignPatterns.Criacionais.AbstractFactory.Pilotos.Models;

namespace DesignPatterns.Criacionais.AbstractFactory.Factories;

internal class CriaDuplaDePilotosMercedesFactory : ICriaDuplaDePilotosAbstractFactory
{
    public IPrimeiroPiloto CriarPrimeiroPiloto()
    {
        return new PrimeiroPilotoModel
        {
            AnosDeExperiencia = 14,
            Nome = "Lewis Hamilton"
        };
    }

    public ISegundoPiloto CriarSegundoPiloto()
    {
        return new SegundoPilotoModel
        {
            Nome = "George Russel",
            DeveAjudarPrimeiroPiloto = false
        };
    }
}
