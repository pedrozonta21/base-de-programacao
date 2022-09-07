namespace ProjetoComFundamentos.Features.Pessoa.Models;

public class ClienteModel : PessoaModel
{
    public decimal DescontoPadrao { get; set; }
    public bool ClienteVip { get; set; }
    public bool PossuiParcelasPendentes { get; set; }
}
