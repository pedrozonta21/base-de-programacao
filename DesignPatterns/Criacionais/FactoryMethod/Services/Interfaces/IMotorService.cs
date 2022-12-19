namespace DesignPatterns.Criacionais.FactoryMethod.Services.Interfaces;

public interface IMotorService
{
    void LigarMotor();
    int RetornarConfiabilidade();
    decimal RetornarPrecoDoMotor();
    int RetornarPotencia();
}
