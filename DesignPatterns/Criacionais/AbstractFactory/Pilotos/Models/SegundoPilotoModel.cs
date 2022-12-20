using DesignPatterns.Criacionais.AbstractFactory.Pilotos.Interfaces;

namespace DesignPatterns.Criacionais.AbstractFactory.Pilotos.Models;

internal class SegundoPilotoModel : ISegundoPiloto
{
    public string Nome { get; set; }
    public bool DeveAjudarPrimeiroPiloto { get; set; }
}
