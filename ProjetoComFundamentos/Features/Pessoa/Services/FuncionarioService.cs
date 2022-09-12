using ProjetoComFundamentos.Features.Pessoa.Models;
using ProjetoComFundamentos.Features.Pessoa.Services.Interfaces;

namespace ProjetoComFundamentos.Features.Pessoa.Services;

public class FuncionarioService : IPessoaService
{
    public void AtualizarPessoa(PessoaModel pessoaModel)
    {
        var funcionarioModel = pessoaModel as FuncionarioModel;
        // ...
    }

    public void DesativarPessoa(int codigoPessoa)
    {
        // ...
    }

    public void InserirPessoa(PessoaModel pessoaModel)
    {
        var funcionarioModel = pessoaModel as FuncionarioModel;
        // ...
    }

    public PessoaModel PesquisarPessoa(object[] filtro)
    {
        return new();
    }
}
