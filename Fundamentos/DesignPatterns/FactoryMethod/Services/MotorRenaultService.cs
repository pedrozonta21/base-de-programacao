using DesignPatterns.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.FactoryMethod.Services;

public class MotorRenaultService : IMotorService
{
    public void LigarMotor() => Console.WriteLine("Ligando motor Renault...");

    public int RetornarConfiabilidade() => 84;

    public int RetornarPotencia() => 88;

    public decimal RetornarPrecoDoMotor() => 950;
}
