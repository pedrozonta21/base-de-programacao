using DesignPatterns.FactoryMethod.Enums;
using DesignPatterns.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.FactoryMethod.Factories.Interfaces;

public interface IMotorServiceFactory
{
    IMotorService RetornarFabricacaoDeServiceDeMotor(TipoMotorEnum tipoMotor);
}
