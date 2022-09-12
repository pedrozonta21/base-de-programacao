using ProjetoComFundamentos.Features.Endereco.Services.Interfaces;
using ProjetoComFundamentos.Features.Pessoa.Enums;
using ProjetoComFundamentos.Features.Pessoa.Factories.Interfaces;
using ProjetoComFundamentos.Features.Pessoa.Models;
using ProjetoComFundamentos.Features.Pessoa.Services.Interfaces;

namespace ProjetoComFundamentos.Features.Pessoa.Controllers;

public partial class PessoaController
{
    private readonly IPesquisaDeCidadePorCepService _pesquisaDeCidadePorCepService;
    private readonly IPessoaService _pessoaService;

    public PessoaController(
        IPessoaServiceFactory pessoaServiceFactory,
        TipoPessoaEnum tipoPessoa)
        => _pessoaService = pessoaServiceFactory.FabricarPessoaService(tipoPessoa);

    public PessoaController(
        IPessoaServiceFactory pessoaServiceFactory,
        TipoPessoaEnum tipoPessoa,
        IPesquisaDeCidadePorCepService pesquisaDeCidadePorCepService)
    {
        _pessoaService = pessoaServiceFactory.FabricarPessoaService(tipoPessoa);
        _pesquisaDeCidadePorCepService = pesquisaDeCidadePorCepService;
    }

    public void AtribuirCidadeNaPessoaBuscandoPeloCep(string cep, PessoaModel pessoaModel) 
        => pessoaModel.Endereco = _pesquisaDeCidadePorCepService.RetornarEnderecoPeloCep(cep);

    public PessoaController(IPesquisaDeCidadePorCepService pesquisaDeCidadePorCepService)
        => _pesquisaDeCidadePorCepService = pesquisaDeCidadePorCepService;
}
