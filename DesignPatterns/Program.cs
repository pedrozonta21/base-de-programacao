using DesignPatterns.Comportamentais.ChainOfResponsability.Handlers;
using DesignPatterns.Comportamentais.ChainOfResponsability.Model;
using DesignPatterns.Comportamentais.Command;
using DesignPatterns.Comportamentais.Command.Captadores;
using DesignPatterns.Comportamentais.Iterator;
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
using DesignPatterns.Estruturais.Bridge.Caderno;
using DesignPatterns.Estruturais.Bridge.Folha;
using DesignPatterns.Estruturais.Composite;
using DesignPatterns.Estruturais.Decorator.Services;
using DesignPatterns.Estruturais.Facade.Services;
using DesignPatterns.Estruturais.Facade.Services.Interfaces;
using DesignPatterns.Estruturais.Flyweight.ContaBancaria;
using DesignPatterns.Estruturais.Flyweight.Model;
using DesignPatterns.Estruturais.Proxy.Services;

//Factory Method
Console.WriteLine("\n-- Factory Method");
ILigarMotorService ligarMotorService = 
    new LigarMotorService
    (
        new MotorServiceFactory(), 
        TipoMotorEnum.Renault
    );

ligarMotorService.LigarMotor();
ligarMotorService.MostrarInformacoesDoMotor();

// Abstract Factory
Console.WriteLine("\n-- Abstract Factory");
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
Console.WriteLine("\n-- Builder");
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
Console.WriteLine("\n-- Prototype");
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
Console.WriteLine("\n-- Singleton");
var singleton = Singleton.RetornarInstanciaDaClasse();
var singleton2 = Singleton.RetornarInstanciaDaClasse();

Console.WriteLine(ReferenceEquals(singleton, singleton2));

//Adapter
Console.WriteLine("\n-- Adapter");
IEnvioDeEmailService emailServiceAdapter = new AdaptadorDeEmailService();
var fechamentoFiscalService = new FechamentoFiscalService(emailServiceAdapter);

fechamentoFiscalService.EnviarEmailDeFechamento();

//Composite
Console.WriteLine("\n-- Composite");
var pai = new PaiComposite { Nome = "Everaldo"};
var filhoDoEveraldo = new Filho { Nome = "Aroldo" };
var filhoDoEveraldoComFilho = new PaiComposite { Nome = "Júnior" };
var filhoDoJunior = new PaiComposite { Nome = "Marcos" };
var filhaDoJuniorComFilho = new MaeComposite { Nome = "Márcia" };
var filhoDaMarcia = new Filho { Nome = "Bruno" };

pai.AdicionarFilho(filhoDoEveraldoComFilho);
filhoDoEveraldoComFilho.AdicionarFilho(filhoDoJunior);
filhoDoJunior.AdicionarFilho(filhaDoJuniorComFilho);
filhaDoJuniorComFilho.AdicionarFilho(filhoDaMarcia);
pai.AdicionarFilho(filhoDoEveraldo);

Console.WriteLine(pai.CriarNome());

//Bridge
Console.WriteLine("\n-- Bridge");
var cadernoBase = new CadernoBase(new FolhaBranca());
Console.WriteLine(cadernoBase.RetornarTipoDaFolha());
Console.WriteLine(cadernoBase.RetornarTipoDeCapa());
cadernoBase.CriarFolhas(30);
Console.WriteLine(cadernoBase.RetornarQuantidadeDeFolhas());
cadernoBase.Escrever("Pedro", cadernoBase.Folhas.First());
Console.WriteLine(cadernoBase.Folhas.First().TextoDaFolha);

var cadernoCapaMole = new CadernoCapaMole(new FolhaReciclavel());
Console.WriteLine(cadernoCapaMole.RetornarTipoDaFolha());
Console.WriteLine(cadernoCapaMole.RetornarTipoDeCapa());
cadernoCapaMole.CriarFolhas(25);
Console.WriteLine(cadernoCapaMole.RetornarQuantidadeDeFolhas());
cadernoCapaMole.Escrever("Henrique", cadernoCapaMole.Folhas.Last());
Console.WriteLine(cadernoCapaMole.Folhas.Last().TextoDaFolha);

//Decorator
Console.WriteLine("\n-- Decorator");
var clean = new EfeitoCleanService();
var reverb = new EfeitoReverbService(clean);
var drive = new EfeitoDriveService(reverb);
var chorus = new EfeitoChorusService(drive);
//chorus = new EfeitoChorusService(new EfeitoReverbService(clean));
//drive.AtribuirNovaClasseDeEfeito(chorus);

Console.WriteLine(clean.AlterarTimbre());
Console.WriteLine(reverb.AlterarTimbre());
Console.WriteLine(drive.AlterarTimbre());
Console.WriteLine(chorus.AlterarTimbre());

//Facade
Console.WriteLine("\n-- Facade");
IQrCodeFacadeService facade = new QrCodeFramework1Service();
Console.WriteLine(facade.GerarQrCode(Guid.NewGuid()));

//Flyweight
Console.WriteLine("\n-- Flyweight");

var fabricaFlyweight = new ContaBancariaFlyweightFactory();
var listaDeContas = new List<ContaBancariaModel>() {
    new ContaBancariaModel() { Codigo = 1, Agencia = "12", CodigoBanco = "4", Numero = "1234"},
    new ContaBancariaModel() { Codigo = 2, Agencia = "29", CodigoBanco = "9", Numero = "35468"},
    new ContaBancariaModel() { Codigo = 3, Agencia = "40", CodigoBanco = "11", Numero = "548"},
    new ContaBancariaModel() { Codigo = 4, Agencia = "99", CodigoBanco = "1", Numero = "5234"},
};

listaDeContas.ForEach(fabricaFlyweight.AdicionarContaAoDicionario);

var pagamento1 = new PagamentoModel
{
    ContaBancaria = fabricaFlyweight.RetornarContaBancaria(1),
    Pagador = new()
};
var pagamento2 = new PagamentoModel
{
    ContaBancaria = fabricaFlyweight.RetornarContaBancaria(1),
    Pagador = new()
};
var pagamento3 = new PagamentoModel
{
    ContaBancaria = fabricaFlyweight.RetornarContaBancaria(4),
    Pagador = new()
};

Console.WriteLine(
    $@"Endereço da conta do pagamento 1 na memória: {pagamento1.ContaBancaria.GetHashCode()}");
Console.WriteLine(
    $@"Endereço da conta do pagamento 2 na memória: {pagamento2.ContaBancaria.GetHashCode()}");
Console.WriteLine(
    $@"Endereço da conta do pagamento 3 na memória: {pagamento3.ContaBancaria.GetHashCode()}");

//Proxy
Console.WriteLine("\n-- Proxy");
var gerarArquivoMp3Service = new GerarArquivoMp3Service();
var logCustomizadoService = new LogCustomizadoDeGeracaoDeArquivoService();

var proxyGerarArquivoMp3Service = new ProxyGerarArquivoMp3Service(gerarArquivoMp3Service, logCustomizadoService);
proxyGerarArquivoMp3Service.GerarAquivoMp3("C:/");

//Chain of Responsability
Console.WriteLine("\n-- Chain of Responsability");
var serasaHandler = new ValidaPessoaForaDoSerasaHandler();
var criminalHandler = new ValidaPessoaSemAntecedenteCriminal();
serasaHandler.SetarNovaValidacao(criminalHandler);

bool ValidarPessoa(PessoaHandlerBase pessoaHandler, PessoaModel pessoa) => pessoaHandler.ValidarPessoa(pessoa);

var pessoa1 = new PessoaModel { Cpf = "123", Nome = "Arnaldo" };
Console.WriteLine($@"{pessoa1.Nome} é válida? {ValidarPessoa(serasaHandler, pessoa1)}");

var pessoa2 = new PessoaModel { Cpf = "321", Nome = "Vitor" };
Console.WriteLine($@"{pessoa2.Nome} é válida? {ValidarPessoa(serasaHandler, pessoa2)}");

var pessoa3 = new PessoaModel { Cpf = "1234", Nome = "Ana" };
Console.WriteLine($@"{pessoa3.Nome} é válida? {ValidarPessoa(criminalHandler, pessoa3)}");

//Command
Console.WriteLine("\n-- Command");
var captadoresService = new CaptadoresService();

var selecionaCaptadorDaPonte = new SelecionaCaptadorDaPonteCommand(captadoresService);
var selecionaCaptadorDoBraco = new SelecionaCaptadorDoBracoCommand(captadoresService);
var selecionaDoisCaptadores = new SelecionaDoisCaptadoresCommand(captadoresService);

var guitarraInvoker = new GuitarraInvoker();

guitarraInvoker.ColocarCommand(selecionaCaptadorDaPonte);
guitarraInvoker.TrocarCaptador();
Console.WriteLine();
guitarraInvoker.ColocarCommand(selecionaCaptadorDoBraco);
guitarraInvoker.TrocarCaptador();
Console.WriteLine();
guitarraInvoker.ColocarCommand(selecionaDoisCaptadores);
guitarraInvoker.TrocarCaptador();
Console.WriteLine();

//Iterator
Console.WriteLine("\n-- Iterator");
var listaDeNumeros = new NumerosColletion();
listaDeNumeros.AdicionarNumero(1);
listaDeNumeros.AdicionarNumero(8);
listaDeNumeros.AdicionarNumero(15);
listaDeNumeros.AdicionarNumero(7);

foreach (var elemento in listaDeNumeros)
{
    Console.WriteLine(elemento);
}