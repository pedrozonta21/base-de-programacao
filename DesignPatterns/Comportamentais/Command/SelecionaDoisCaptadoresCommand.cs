using DesignPatterns.Comportamentais.Command.Captadores;
using DesignPatterns.Comportamentais.Command.Interfaces;

namespace DesignPatterns.Comportamentais.Command;

internal class SelecionaDoisCaptadoresCommand : ICaptadoresCommand
{
    private readonly CaptadoresService _captadoresService;

    public SelecionaDoisCaptadoresCommand(CaptadoresService captadoresService) => 
        _captadoresService = captadoresService;

    public void SelecionarCaptador() => 
        _captadoresService.SelecionarOsDoisCaptadores();
}
