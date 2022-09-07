using Newtonsoft.Json;
using ProjetoComFundamentos.Features.Endereco.Models;
using ProjetoComFundamentos.Features.Endereco.Services.Interfaces;

namespace ProjetoComFundamentos.Features.Endereco.Services;

public class PesquisaDeCidadePorCepService : IPesquisaDeCidadePorCepService
{
    private readonly IBuscadorDeCepViaApiService _buscadorDeCepViaApiService;

    public PesquisaDeCidadePorCepService(IBuscadorDeCepViaApiService buscadorDeCepViaApiService) 
        => _buscadorDeCepViaApiService = buscadorDeCepViaApiService;

    public EnderecoModel RetornarEnderecoPeloCep(string cep)
    {
        var json = _buscadorDeCepViaApiService.RetornarJsonDaPesquisaDoCep(cep);
        return JsonConvert.DeserializeObject<EnderecoModel>(json);
    }
}
