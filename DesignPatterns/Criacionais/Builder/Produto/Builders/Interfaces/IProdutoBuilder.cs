using DesignPatterns.Criacionais.Builder.Produto.Models;

namespace DesignPatterns.Criacionais.Builder.Produto.Builders.Interfaces;

public interface IProdutoBuilder
{
    void ConstruirDadosBasicosDoProduto();
    void ConstruirImpostosDoProduto();
    void ConstruirCategoriaDoProduto();
    void ConstruirEstoqueDoProduto();
    void ConstruirHistoricoDoProduto();
    ProdutoModel RetornarProduto();
}
