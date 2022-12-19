using DesignPatterns.Criacionais.FactoryMethod.Enums;
using DesignPatterns.Criacionais.FactoryMethod.Factories;
using DesignPatterns.Criacionais.FactoryMethod.Services;
using DesignPatterns.Criacionais.FactoryMethod.Services.Interfaces;

//Factory Method
ILigarMotorService ligarMotorService = 
    new LigarMotorService
    (
        new MotorServiceFactory(), 
        TipoMotorEnum.Renault
    );

ligarMotorService.LigarMotor();
ligarMotorService.MostrarInformacoesDoMotor();