using ProjetoComFundamentos.Features.Endereco.Services.Interfaces;
using ProjetoComFundamentos.Features.Pessoa.Models;

namespace ProjetoComFundamentos.Features.Pessoa.Controllers;

public partial class PessoaController
{
    private readonly IPesquisaDeCidadePorCepService _pesquisaDeCidadePorCepService;

    public PessoaController(IPesquisaDeCidadePorCepService pesquisaDeCidadePorCepService) 
        => _pesquisaDeCidadePorCepService = pesquisaDeCidadePorCepService;

    public void AtribuirCidadeNaPessoaBuscandoPeloCep(string cep, PessoaModel pessoaModel) 
        => pessoaModel.Endereco = _pesquisaDeCidadePorCepService.RetornarEnderecoPeloCep(cep);
}
