using DesignPatterns.FactoryMethod.Enums;
using DesignPatterns.FactoryMethod.Factories.Interfaces;
using DesignPatterns.FactoryMethod.Services;
using DesignPatterns.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.FactoryMethod.Factories;

public class MotorServiceFactory : IMotorServiceFactory
{
    public IMotorService RetornarFabricacaoDeServiceDeMotor(TipoMotorEnum tipoMotor)
    {
        try
        {
            var dicionarioDeServicesDeMotor = RetornarDicionarioComServicesDeMotor();

            if (dicionarioDeServicesDeMotor.TryGetValue(tipoMotor, out var service)) return service;

            throw new NotImplementedException("Não existe implementação para esse tipo de motor.");
        }
        catch (NotImplementedException notImplementedException)
        {
            Console.WriteLine(notImplementedException.Message);
            throw;
        }
    }

    private static IDictionary<TipoMotorEnum, IMotorService> RetornarDicionarioComServicesDeMotor()
    {
        return new Dictionary<TipoMotorEnum, IMotorService>()
        {
            {TipoMotorEnum.Ferrari, new MotorFerrariService()},
            {TipoMotorEnum.Mercedes, new MotorMercedesService()},
            {TipoMotorEnum.RedBullPowerTrain, new MotorRedBullPowerTrainService()},
            {TipoMotorEnum.Renault, new MotorRenaultService()},
        };
    }
}
