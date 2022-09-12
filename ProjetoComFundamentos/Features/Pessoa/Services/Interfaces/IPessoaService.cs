using ProjetoComFundamentos.Features.Pessoa.Models;

namespace ProjetoComFundamentos.Features.Pessoa.Services.Interfaces;

public interface IPessoaService
{
    void InserirPessoa(PessoaModel pessoaModel);
    void AtualizarPessoa(PessoaModel pessoaModel);
    PessoaModel PesquisarPessoa(object[] filtro);
    void DesativarPessoa(int codigoPessoa);
}
