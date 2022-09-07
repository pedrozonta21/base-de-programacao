namespace ProjetoComFundamentos.Features.Produto.Models;

public class ProdutoModel
{
    public uint Codigo { get; set; }
    public string NomeProduto { get; set; }
    public decimal PrecoDeVenda { get; set; }
    public decimal PrecoDeCusto { get; set; }
    public DateTime DataCadastro { get; set; }
    public int Qtde { get; set; }
}
