using DesignPatterns.Comportamentais.Command.Interfaces;

namespace DesignPatterns.Comportamentais.Command;

internal class GuitarraInvoker
{
    private ICaptadoresCommand CaptadoresCommand;

    public void ColocarCommand(ICaptadoresCommand captadoresCommand) => 
        CaptadoresCommand = captadoresCommand;

    public void TrocarCaptador() => CaptadoresCommand.SelecionarCaptador();
}
