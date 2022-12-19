using DesignPatterns.Criacionais.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.Criacionais.FactoryMethod.Services;

public class MotorFerrariService : IMotorService
{
    public void LigarMotor() => Console.WriteLine("Ligando motor Ferrari...");

    public int RetornarConfiabilidade() => 78;

    public int RetornarPotencia() => 97;

    public decimal RetornarPrecoDoMotor() => 1000;
}
