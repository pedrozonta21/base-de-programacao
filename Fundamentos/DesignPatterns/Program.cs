using DesignPatterns.FactoryMethod.Enums;
using DesignPatterns.FactoryMethod.Factories;
using DesignPatterns.FactoryMethod.Services;
using DesignPatterns.FactoryMethod.Services.Interfaces;

//Factory Method
ILigarMotorService ligarMotorService = 
    new LigarMotorService
    (
        new MotorServiceFactory(), 
        TipoMotorEnum.Renault
    );

ligarMotorService.LigarMotor();
ligarMotorService.MostrarInformacoesDoMotor();