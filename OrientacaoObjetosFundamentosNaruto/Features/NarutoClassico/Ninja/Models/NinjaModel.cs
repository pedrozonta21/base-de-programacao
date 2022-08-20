using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Aldeia.Models;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Cargo;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Pessoa.Models;

namespace OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Models;

public class NinjaModel : PessoaModel
{
    public string PoderEspecifico { get; set; }
    public IList<PoderSecundarioModel> PoderesSecundarios { get; set; } = new List<PoderSecundarioModel>();
    public CargoModel Cargo { get; set; }
    public AldeiaModel Aldeia { get; set; }
}
