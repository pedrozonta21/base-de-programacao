namespace DesignPatterns.Criacionais.Prototype.Models;

public class MarcaModel : ICloneable
{
    public int Codigo { get; set; }
    public string Nome { get; set; }

    public object Clone() => MemberwiseClone();
}
