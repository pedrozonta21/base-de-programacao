using ProjetoComFundamentos.Features.Pessoa.Enums;
using ProjetoComFundamentos.Features.Pessoa.Factories.Interfaces;
using ProjetoComFundamentos.Features.Pessoa.Services;
using ProjetoComFundamentos.Features.Pessoa.Services.Interfaces;

namespace ProjetoComFundamentos.Features.Pessoa.Factories;

public class PessoaServiceFactory : IPessoaServiceFactory
{
    public IPessoaService FabricarPessoaService(TipoPessoaEnum tipoPessoa)
    {
        var dicionarioDePessoaService = RetornarDicionarioDePessoaService();

        if(dicionarioDePessoaService.TryGetValue(tipoPessoa, out var pessoaService))
            return pessoaService;

        throw new NotImplementedException($"Não existe implementação para {tipoPessoa}");
    }

    private static IDictionary<TipoPessoaEnum, IPessoaService> RetornarDicionarioDePessoaService() 
        => new Dictionary<TipoPessoaEnum, IPessoaService>
        {
            { TipoPessoaEnum.Cliente, new ClienteService() },
            { TipoPessoaEnum.Empresa, new EmpresaService() },
            { TipoPessoaEnum.Funcionario, new FuncionarioService() }
        };
}
