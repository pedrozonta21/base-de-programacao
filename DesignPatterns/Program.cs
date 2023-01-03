using DesignPatterns.Criacionais.AbstractFactory.Factories;
using DesignPatterns.Criacionais.AbstractFactory.Factories.Interfaces;
using DesignPatterns.Criacionais.Builder.Produto.Builders;
using DesignPatterns.Criacionais.Builder.Produto.Builders.Interfaces;
using DesignPatterns.Criacionais.FactoryMethod.Enums;
using DesignPatterns.Criacionais.FactoryMethod.Factories;
using DesignPatterns.Criacionais.FactoryMethod.Services;
using DesignPatterns.Criacionais.FactoryMethod.Services.Interfaces;
using DesignPatterns.Criacionais.Prototype.Models;
using DesignPatterns.Criacionais.Singleton;
using DesignPatterns.Estruturais.Adapter.Services;
using DesignPatterns.Estruturais.Adapter.Services.Adapters;
using DesignPatterns.Estruturais.Adapter.Services.Interfaces;

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

//Prototype
var guitarraFender = new GuitarraModel
{
    Codigo = 1,
    Marca = new MarcaModel { Nome = "Fender" },
    Modelo = "Fd 5421SS",
    QtdeTrastes = 22
};

var guitarraTagima = guitarraFender.ClonarSuperficialmente();
guitarraTagima.Marca.Nome = "Tagima";

Console.WriteLine(guitarraTagima.Marca.Nome);
Console.WriteLine(guitarraFender.Marca.Nome);

guitarraTagima = guitarraFender.ClonarProfundamente();
guitarraFender.Marca.Nome = "Fender";

Console.WriteLine(guitarraTagima.Marca.Nome);
Console.WriteLine(guitarraFender.Marca.Nome);

var amplificadorBorne = new AmplificadorModel
{
    Codigo = 1,
    Marca = new MarcaModel { Nome = "Borne" },
    Modelo = "Vorax 1050",
    PolegadaAltoFalante = 10
};

var amplificadorMeteoro = amplificadorBorne.Clone() as AmplificadorModel;
amplificadorMeteoro.Marca.Nome = "Meteoro";

Console.WriteLine(amplificadorBorne.Marca.Nome);
Console.WriteLine(amplificadorMeteoro.Marca.Nome);

//Singleton
var singleton = Singleton.RetornarInstanciaDaClasse();
var singleton2 = Singleton.RetornarInstanciaDaClasse();

Console.WriteLine(ReferenceEquals(singleton, singleton2));

//Adapter
IEnvioDeEmailService emailServiceAdapter = new AdaptadorDeEmailService();
var fechamentoFiscalService = new FechamentoFiscalService(emailServiceAdapter);

fechamentoFiscalService.EnviarEmailDeFechamento();