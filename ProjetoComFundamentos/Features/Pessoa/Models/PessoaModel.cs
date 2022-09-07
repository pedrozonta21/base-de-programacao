using ProjetoComFundamentos.Features.Endereco.Models;
using ProjetoComFundamentos.Features.Pessoa.Enums;

namespace ProjetoComFundamentos.Features.Pessoa.Models;

public class PessoaModel
{
    public uint Codigo { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public TipoPessoaEnum TipoPessoa { get; set; }
    public EnderecoModel Endereco { get; set; } = new();
}
