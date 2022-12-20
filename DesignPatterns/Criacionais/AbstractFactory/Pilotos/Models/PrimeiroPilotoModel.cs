using DesignPatterns.Criacionais.AbstractFactory.Pilotos.Interfaces;

namespace DesignPatterns.Criacionais.AbstractFactory.Pilotos.Models;

internal class PrimeiroPilotoModel : IPrimeiroPiloto
{
    public string Nome { get; set; }
    public int AnosDeExperiencia { get; set; }

    public float RetornarCapacidadeDeLideranca() => AnosDeExperiencia * 1.10F;

    public float RetornarHabilidade() => RetornarCapacidadeDeLideranca() * 2.5F;
}
