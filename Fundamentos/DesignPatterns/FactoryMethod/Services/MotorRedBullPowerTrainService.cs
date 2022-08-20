using DesignPatterns.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.FactoryMethod.Services;

public class MotorRedBullPowerTrainService : IMotorService
{
    public void LigarMotor() => Console.WriteLine("Ligando motor RBPT...");

    public int RetornarConfiabilidade() => 88;

    public int RetornarPotencia() => 95;

    public decimal RetornarPrecoDoMotor() => 995;
}
