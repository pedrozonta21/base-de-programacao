namespace ProjetoComFundamentos.Features.Endereco.Services.Interfaces;

public interface IBuscadorDeCepViaApiService
{
    string RetornarJsonDaPesquisaDoCep(string cep);
}
