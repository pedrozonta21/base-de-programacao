using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Models;

namespace OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Lider.Models;

public class HokageModel : NinjaModel
{
    public int NumeroOrdinalDoLider { get; set; }
    public string NumeroOrdinalComNomeDoCargo => $"{NumeroOrdinalDoLider} {Cargo?.Nome}";
}
