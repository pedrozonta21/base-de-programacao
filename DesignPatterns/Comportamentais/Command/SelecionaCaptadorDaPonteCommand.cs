using DesignPatterns.Comportamentais.Command.Captadores;
using DesignPatterns.Comportamentais.Command.Interfaces;

namespace DesignPatterns.Comportamentais.Command;

internal class SelecionaCaptadorDaPonteCommand : ICaptadoresCommand
{
	private readonly CaptadoresService _captadoresService;

    public SelecionaCaptadorDaPonteCommand(CaptadoresService captadoresService) => 
        _captadoresService = captadoresService;

    public void SelecionarCaptador() => 
        _captadoresService.SelecionarCaptadorDaPonte();
}
