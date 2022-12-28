namespace DesignPatterns.Criacionais.Prototype.Models;

public class AmplificadorModel : ICloneable
{
    public int Codigo { get; set; }
    public string Modelo { get; set; }
    public ushort PolegadaAltoFalante { get; set; }
    public MarcaModel Marca { get; set; }

    public object Clone()
    {
        var amplificador = MemberwiseClone() as AmplificadorModel;
        amplificador.Marca = Marca.Clone() as MarcaModel;
        return amplificador;
    }
}
