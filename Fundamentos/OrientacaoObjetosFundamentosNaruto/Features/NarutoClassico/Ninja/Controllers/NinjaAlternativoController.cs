using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Cargo;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers.Abstracao;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers.Interfaces;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Models;

namespace OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers;

public class NinjaAlternativoController : NinjaControllerBase, INinjaController
{
    public void AtribuirNovoCargoParaNinja(NinjaModel ninja, CargoModel cargo) 
    {
        if (VerificarSeNinjaPossuiMaioridadeParaObterNovoCargo(ninja, cargo)) 
            ninja.Cargo = cargo;
    }

    private static bool VerificarSeNinjaPossuiMaioridadeParaObterNovoCargo(NinjaModel ninja, CargoModel cargo)
    {
        if (ninja.Idade >= 18) return true;

        Console.WriteLine($"{ninja.Nome} não é maior de idade para ser {cargo.Nome}");
        return false;
    }
}
