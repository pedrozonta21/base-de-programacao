using ProjetoComFundamentos.Features.Cidade.Models;

namespace ProjetoComFundamentos.Features.Endereco.Models;

public class EnderecoModel
{
    public uint Codigo { get; set; }
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public ushort Numero { get; set; }
    public string Cep { get; set; }

    public CidadeModel Cidade { get; set; }
}
