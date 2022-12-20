namespace DesignPatterns.Criacionais.AbstractFactory.Pilotos.Interfaces;

internal interface IPrimeiroPiloto
{
    string Nome { get; set; }
    int AnosDeExperiencia { get; set; }
    float RetornarCapacidadeDeLideranca();
    float RetornarHabilidade();
}
