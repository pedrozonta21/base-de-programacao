using Newtonsoft.Json;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Aldeia.Models;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Cargo;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Lider.Models;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Controllers.Interfaces;
using OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Ninja.Models;

//Código relacionado à criação do ninja Naruto

CriarNinja();
CriarNinjaAlternativo();

void CriarNinja()
{
    var ninjaNaruto = RetornarNinjaNaruto();
    AtribuirPoderesSecundariosParaNaruto(ninjaNaruto);

    var cargoGenin = RetornarCargoGenin();
    INinjaController ninjaController = new NinjaController();
    ninjaController.AtribuirNovoCargoParaNinja(ninjaNaruto, cargoGenin);

    var cargoShinobi = RetornarCargoShinobi();
    ninjaController.AtribuirNovoCargoParaNinja(ninjaNaruto, cargoShinobi);

    Console.WriteLine(JsonConvert.SerializeObject(ninjaNaruto));
    Console.WriteLine("*-------------------------------------------*");
}

void CriarNinjaAlternativo()
{
    var ninjaNaruto = RetornarNinjaNaruto();
    AtribuirPoderesSecundariosParaNaruto(ninjaNaruto);

    var cargoGenin = RetornarCargoGenin();
    INinjaController ninjaController = new NinjaAlternativoController();
    ninjaController.AtribuirNovoCargoParaNinja(ninjaNaruto, cargoGenin);

    var cargoShinobi = RetornarCargoShinobi();
    ninjaController.AtribuirNovoCargoParaNinja(ninjaNaruto, cargoShinobi);

    Console.WriteLine(JsonConvert.SerializeObject(ninjaNaruto));
    Console.WriteLine("*-------------------------------------------*");
}

NinjaModel RetornarNinjaNaruto() => new()
{
    Codigo = 1,
    Nome = "Naruto Uzumaki",
    DataNascimento = new DateTime(2001, 8, 31),
    PoderEspecifico = "Jutsu clones da sombra",
};

void AtribuirPoderesSecundariosParaNaruto(NinjaModel ninja)
{
    ninja.PoderesSecundarios.Add(new PoderSecundarioModel
    {
        Codigo = 1,
        Poder = "Hazengan"
    });
    ninja.PoderesSecundarios.Add(new PoderSecundarioModel
    {
        Codigo = 2,
        Poder = "Jutsu do dedo secreto da aldeia da folha"
    });
}

CargoModel RetornarCargoGenin() => new()
{
    Codigo = 1,
    Nome = "Genin",
    IdadeMinima = 15
};

CargoModel RetornarCargoShinobi() => new()
{
    Codigo = 2,
    Nome = "Shinobi",
    IdadeMinima = 25
};


//Código relacionado à criação do líder Jiraya

CriarHokage();

void CriarHokage()
{
    var hokageJiraya = CriarHokageJiraya();
    AtribuirPoderesSecundariosParaJiraya(hokageJiraya);

    var cargoSanin = RetornarCargoSannin();
    INinjaController ninjaController = new NinjaController();
    ninjaController.AtribuirNovoCargoParaNinja(hokageJiraya, cargoSanin);

    var aldeiaDaFolha = RetornarAldeiaDaFolha();
    ninjaController.AtribuirNovaAldeiaParaNinja(hokageJiraya, aldeiaDaFolha);
    Console.WriteLine(JsonConvert.SerializeObject(hokageJiraya));
    Console.WriteLine("*-------------------------------------------*");
}

HokageModel CriarHokageJiraya() => new()
{
    Codigo = 2,
    Nome = "Jiraya",
    DataNascimento = new DateTime(1983, 2, 20),
    PoderEspecifico = "Jutsu garganta do sapo",
    NumeroOrdinalDoLider = 5
};

void AtribuirPoderesSecundariosParaJiraya(HokageModel hokage)
{
    hokage.PoderesSecundarios.Add(new PoderSecundarioModel
    {
        Codigo = 1,
        Poder = "Hazengan"
    });
}

CargoModel RetornarCargoSannin() => new()
{
    Codigo = 3,
    Nome = "Hokage - Sannin lendário",
    IdadeMinima = 18
};

AldeiaModel RetornarAldeiaDaFolha()
{
    return new()
    {
        Codigo = 1,
        Nome = "Aldeia da folha"
    };
}