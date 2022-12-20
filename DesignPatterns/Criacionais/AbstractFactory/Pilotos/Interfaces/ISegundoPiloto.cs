namespace DesignPatterns.Criacionais.AbstractFactory.Pilotos.Interfaces; 

internal interface ISegundoPiloto 
{
    string Nome { get; set; }
    bool DeveAjudarPrimeiroPiloto { get; set; }
}
