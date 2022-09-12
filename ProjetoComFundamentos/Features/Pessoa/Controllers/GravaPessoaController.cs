using ProjetoComFundamentos.Features.Pessoa.Models;

namespace ProjetoComFundamentos.Features.Pessoa.Controllers;

public partial class PessoaController
{
    public void InserirPessoa(PessoaModel pessoaModel) 
        => _pessoaService.InserirPessoa(pessoaModel);

    public void AtualizarPessoa(PessoaModel pessoaModel) 
        => _pessoaService.AtualizarPessoa(pessoaModel);

    public void DesativarPessoa(int codigoPessoa) 
        => _pessoaService.DesativarPessoa(codigoPessoa);
}
