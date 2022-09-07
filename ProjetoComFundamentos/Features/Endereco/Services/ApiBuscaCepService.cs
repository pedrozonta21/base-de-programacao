using ProjetoComFundamentos.Features.Endereco.Services.Interfaces;

namespace ProjetoComFundamentos.Features.Endereco.Services;

public class ApiBuscaCepService : IBuscadorDeCepViaApiService
{
    public string RetornarJsonDaPesquisaDoCep(string cep)
    {
        // A ideia seria usar a API do busca cep.
        return string.Empty;
    }
}
