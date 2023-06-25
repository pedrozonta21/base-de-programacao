namespace DesignPatterns.Comportamentais.Command.Captadores;

public class CaptadoresService
{
    public void SelecionarOsDoisCaptadores()
    {
        SelecionarCaptadorDoBraco();
        SelecionarCaptadorDaPonte();
    }

    public void SelecionarCaptadorDoBraco() => Console.WriteLine("Captador do braço selecionado");

    public void SelecionarCaptadorDaPonte() => Console.WriteLine("Captador da ponte selecinado");
}