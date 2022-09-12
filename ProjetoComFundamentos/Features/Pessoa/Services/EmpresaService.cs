using ProjetoComFundamentos.Features.Pessoa.Models;
using ProjetoComFundamentos.Features.Pessoa.Services.Interfaces;

namespace ProjetoComFundamentos.Features.Pessoa.Services;

internal class EmpresaService : IPessoaService
{
    public void AtualizarPessoa(PessoaModel pessoaModel)
    {
        var empresaModel = pessoaModel as EmpresaModel;
        // ...
    }

    public void DesativarPessoa(int codigoPessoa)
    {
        // ...
    }

    public void InserirPessoa(PessoaModel pessoaModel)
    {
        var empresaModel = pessoaModel as EmpresaModel;
        // ...
    }

    public PessoaModel PesquisarPessoa(object[] filtro)
    {
        return new();
    }
}
