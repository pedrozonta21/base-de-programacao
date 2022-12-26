namespace DesignPatterns.Criacionais.Builder.Produto.Models;

public class ProdutoModel
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Observacao { get; set; }
    public decimal ValorUn { get; set; }
    public decimal Qtde { get; set; }
    public decimal ValorTotal { get; set; }
    public decimal Desconto { get; set; }
    public decimal Frete { get; set; }
    public ImpostosModel Impostos { get; set; }
    public CategoriaModel Categoria { get; set; }
    public EstoqueModel Estoque { get; set; }
    public HistoricoModel Historico { get; set; }
}

public class ImpostosModel
{
    public int Codigo { get; set; }
    // ...
}

public class CategoriaModel
{
    public int Codigo { get; set; }
    // ...
}

public class EstoqueModel
{
    public int Codigo { get; set; }
    // ...
}

public class HistoricoModel
{
    public int Codigo { get; set; }
    // ...
}
