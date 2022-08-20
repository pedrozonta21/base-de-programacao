using DesignPatterns.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.FactoryMethod.Services;

public class MotorMercedesService : IMotorService
{
    public void LigarMotor() => Console.WriteLine("Lignado motor Mercedes...");

    public int RetornarConfiabilidade() => 93;

    public int RetornarPotencia() => 90;

    public decimal RetornarPrecoDoMotor() => 989;
}
