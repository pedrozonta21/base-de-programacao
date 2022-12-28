namespace DesignPatterns.Criacionais.Prototype.Models;

public class GuitarraModel
{
    public int Codigo { get; set; }
    public int QtdeTrastes { get; set; }
    public string Modelo { get; set; }
    public MarcaModel Marca { get; set; }

    public GuitarraModel ClonarSuperficialmente() => MemberwiseClone() as GuitarraModel;

    public GuitarraModel ClonarProfundamente()
    {
        var guitarra = MemberwiseClone() as GuitarraModel;
        guitarra.Marca = new MarcaModel
        {
            Codigo = Marca.Codigo,
            Nome = Marca.Nome
        };
        return guitarra;
    }
}
