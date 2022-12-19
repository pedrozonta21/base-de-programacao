using DesignPatterns.Criacionais.FactoryMethod.Enums;
using DesignPatterns.Criacionais.FactoryMethod.Factories.Interfaces;
using DesignPatterns.Criacionais.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.Criacionais.FactoryMethod.Services;

public class LigarMotorService : ILigarMotorService
{
    private readonly IMotorService _motorService;

    public LigarMotorService(IMotorServiceFactory motorServiceFactory, TipoMotorEnum tipoMotor)
        => _motorService = motorServiceFactory.RetornarFabricacaoDeServiceDeMotor(tipoMotor);

    public void LigarMotor() => _motorService.LigarMotor();

    public void MostrarInformacoesDoMotor()
    {
        Console.WriteLine($"Confiabilidade: {_motorService.RetornarConfiabilidade()}");
        Console.WriteLine($"Potência: {_motorService.RetornarPotencia()}");
        Console.WriteLine($"Preço: {_motorService.RetornarPrecoDoMotor():c2}");
    }
}
