using DesignPatterns.Comportamentais.Command.Captadores;
using DesignPatterns.Comportamentais.Command.Interfaces;

namespace DesignPatterns.Comportamentais.Command;

internal class SelecionaCaptadorDoBracoCommand : ICaptadoresCommand
{
    private readonly CaptadoresService _captadoresService;

    public SelecionaCaptadorDoBracoCommand(CaptadoresService captadoresService) => 
        _captadoresService = captadoresService;

    public void SelecionarCaptador() => 
        _captadoresService.SelecionarCaptadorDoBraco();
}
