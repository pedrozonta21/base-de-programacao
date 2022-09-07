using ProjetoComFundamentos.Features.Estado.Models;

namespace ProjetoComFundamentos.Features.Cidade.Models;

public class CidadeModel
{
    public uint Codigo { get; set; }
    public string Nome { get; set; }
    public string Ibge { get; set; }

    public EstadoModel Estado { get; set; } = new();
}
