using ProjetoComFundamentos.Features.Pessoa.Models;

namespace ProjetoComFundamentos.Features.Pessoa.Controllers;

public partial class PessoaController
{
    public PessoaModel PesquisarPessoa(object[] filtro) 
        => _pessoaService.PesquisarPessoa(filtro);
}
