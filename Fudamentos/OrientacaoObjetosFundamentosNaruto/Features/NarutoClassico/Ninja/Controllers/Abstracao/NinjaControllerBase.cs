using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Aldeia.Models;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Cargo;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers.Interfaces;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Models;

namespace OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers.Abstracao;

public abstract class NinjaControllerBase : INinjaController
{
    public void AtribuirNovaAldeiaParaNinja(NinjaModel ninja, AldeiaModel aldeia) => ninja.Aldeia = aldeia;

    public void AtribuirNovaAldeiaParaNinja(NinjaModel ninja)
    {
        ninja.Aldeia = new()
        {
            Codigo = 1,
            Nome = "Aldeia da folha"
        };
    }

    public abstract void AtribuirNovoCargoParaNinja(NinjaModel ninja, CargoModel cargo);
}
