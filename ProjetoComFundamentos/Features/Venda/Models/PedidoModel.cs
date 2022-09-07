using ProjetoComFundamentos.Features.Pessoa.Models;
using ProjetoComFundamentos.Features.Produto.Models;

namespace ProjetoComFundamentos.Features.Venda.Models;

public class PedidoModel
{
    public uint Codigo { get; set; }
    public string Observacao { get; set; }
    public decimal Desconto { get; set; }
    public decimal Frete { get; set; }
    public decimal ValorTotal { get; set; }
    public decimal ValorTotalDosProdutos => Produtos.Sum(produto => produto.PrecoDeVenda);
    List<ProdutoModel> Produtos { get; set; } = new();
    public ClienteModel Cliente { get; set; } = new();
    public FuncionarioModel Funcionario { get; set; } = new();
}
