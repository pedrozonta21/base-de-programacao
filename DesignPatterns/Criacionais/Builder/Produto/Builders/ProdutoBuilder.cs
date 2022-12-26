using DesignPatterns.Criacionais.Builder.Produto.Builders.Interfaces;
using DesignPatterns.Criacionais.Builder.Produto.Models;

namespace DesignPatterns.Criacionais.Builder.Produto.Builders;

public class ProdutoBuilder : IProdutoBuilder
{
    private ProdutoModel ProdutoModel;

    public ProdutoBuilder() => ProdutoModel = new();

    public void ConstruirCategoriaDoProduto() => ProdutoModel.Categoria = new() { Codigo = 1 };

    public void ConstruirDadosBasicosDoProduto()
    {
        ProdutoModel.Codigo = 1;
        ProdutoModel.Nome = "Produto exemplo";
        ProdutoModel.Observacao = "Produto está sendo observado";
        ProdutoModel.Qtde = 4;
        ProdutoModel.ValorUn = 10;
        ProdutoModel.ValorTotal = ProdutoModel.Qtde * ProdutoModel.ValorUn;
    }

    public void ConstruirEstoqueDoProduto() => ProdutoModel.Estoque = new() { Codigo = 1 };

    public void ConstruirHistoricoDoProduto() => ProdutoModel.Historico = new() { Codigo = 1 };

    public void ConstruirImpostosDoProduto() => ProdutoModel.Impostos = new() { Codigo = 1 };

    public ProdutoModel RetornarProduto()
    {
        var produto = ProdutoModel;
        ProdutoModel = new();
        return produto;
    }
}
