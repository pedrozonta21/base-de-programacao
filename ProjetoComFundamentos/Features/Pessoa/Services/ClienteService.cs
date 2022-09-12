using ProjetoComFundamentos.Features.Pessoa.Models;
using ProjetoComFundamentos.Features.Pessoa.Services.Interfaces;

namespace ProjetoComFundamentos.Features.Pessoa.Services;

public class ClienteService : IPessoaService
{
    public void AtualizarPessoa(PessoaModel pessoaModel)
    {
        var clienteModel = pessoaModel as ClienteModel;
        // ...
    }

    public void DesativarPessoa(int codigoPessoa)
    {
        // ...
    }

    public void InserirPessoa(PessoaModel pessoaModel)
    {
        var clienteModel = pessoaModel as ClienteModel;
        // ...
    }

    public PessoaModel PesquisarPessoa(object[] filtro)
    {
        return new();
    }
}
