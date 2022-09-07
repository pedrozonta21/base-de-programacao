using ProjetoComFundamentos.Features.Endereco.Models;

namespace ProjetoComFundamentos.Features.Endereco.Services.Interfaces;

public interface IPesquisaDeCidadePorCepService
{
    EnderecoModel RetornarEnderecoPeloCep(string cep);
}
