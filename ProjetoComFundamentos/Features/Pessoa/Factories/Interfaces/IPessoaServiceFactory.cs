using ProjetoComFundamentos.Features.Pessoa.Enums;
using ProjetoComFundamentos.Features.Pessoa.Services.Interfaces;

namespace ProjetoComFundamentos.Features.Pessoa.Factories.Interfaces;

public interface IPessoaServiceFactory
{
    IPessoaService FabricarPessoaService(TipoPessoaEnum tipoPessoa);
}
