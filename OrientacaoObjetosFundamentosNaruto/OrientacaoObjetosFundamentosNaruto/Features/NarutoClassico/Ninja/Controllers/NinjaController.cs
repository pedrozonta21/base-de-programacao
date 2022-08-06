using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Aldeia.Models;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Cargo;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers.Abstracao;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Models;

namespace OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers;

public class NinjaController : NinjaControllerBase
{
    public override void AtribuirNovoCargoParaNinja(NinjaModel ninja, CargoModel cargo)
    {
        if (VerificarSeNinjaPossuiIdadeParaObterNovoCargo(ninja, cargo)) 
            ninja.Cargo = cargo;
    }

    private static bool VerificarSeNinjaPossuiIdadeParaObterNovoCargo(NinjaModel ninja, CargoModel cargo)
    {
        if (ninja.Idade >= cargo.IdadeMinima) return true;
     
        Console.WriteLine($"{ninja.Nome} não possui idade para ser {cargo.Nome}");
        return false;
    }
}
