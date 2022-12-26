using DesignPatterns.Criacionais.AbstractFactory.Factories;
using DesignPatterns.Criacionais.AbstractFactory.Factories.Interfaces;
using DesignPatterns.Criacionais.Builder.Produto.Builders;
using DesignPatterns.Criacionais.Builder.Produto.Builders.Interfaces;
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

// Abstract Factory
CriarDuplaDePilotos(new CriaDuplaDePilotosMercedesFactory());
CriarDuplaDePilotos(new CriaDuplaDePilotosRedBullFactory());

void CriarDuplaDePilotos(ICriaDuplaDePilotosAbstractFactory criaDuplaDePilotosAbstractFactory)
{
    var primeiroPiloto = criaDuplaDePilotosAbstractFactory.CriarPrimeiroPiloto();
    var segundoPiloto = criaDuplaDePilotosAbstractFactory.CriarSegundoPiloto();

    Console.WriteLine($"{primeiroPiloto.Nome} - Liderança: {primeiroPiloto.RetornarCapacidadeDeLideranca()} - Habilidade: {primeiroPiloto.RetornarHabilidade()}");
    Console.WriteLine($"{segundoPiloto.Nome} deve ajudar {primeiroPiloto.Nome}? {segundoPiloto.DeveAjudarPrimeiroPiloto}");
}

//Builder

ConstruirProduto();

void ConstruirProduto()
{
    IProdutoBuilder produtoBuilder = new ProdutoBuilder();
    produtoBuilder.ConstruirDadosBasicosDoProduto();
    produtoBuilder.ConstruirCategoriaDoProduto();
    produtoBuilder.ConstruirImpostosDoProduto();
    var produtoConstruido = produtoBuilder.RetornarProduto();

    Console.WriteLine(produtoConstruido);
}