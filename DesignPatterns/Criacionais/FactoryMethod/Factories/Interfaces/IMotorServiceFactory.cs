using DesignPatterns.Criacionais.FactoryMethod.Enums;
using DesignPatterns.Criacionais.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.Criacionais.FactoryMethod.Factories.Interfaces;

public interface IMotorServiceFactory
{
    IMotorService RetornarFabricacaoDeServiceDeMotor(TipoMotorEnum tipoMotor);
}
