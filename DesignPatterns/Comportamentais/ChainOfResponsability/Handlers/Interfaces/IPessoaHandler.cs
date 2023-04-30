using DesignPatterns.Comportamentais.ChainOfResponsability.Model;

namespace DesignPatterns.Comportamentais.ChainOfResponsability.Handlers.Interfaces;

internal interface IPessoaHandler
{
    IPessoaHandler SetarNovaValidacao(IPessoaHandler pessoaHandler);
    bool ValidarPessoa(PessoaModel pessoa);
}
