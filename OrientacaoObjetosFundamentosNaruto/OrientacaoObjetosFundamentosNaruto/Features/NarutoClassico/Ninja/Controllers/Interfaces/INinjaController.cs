using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Aldeia.Models;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Cargo;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Models;

namespace OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers.Interfaces;

public interface INinjaController
{
    void AtribuirNovoCargoParaNinja(NinjaModel ninja, CargoModel cargo);
    void AtribuirNovaAldeiaParaNinja(NinjaModel ninja, AldeiaModel aldeia);
}
