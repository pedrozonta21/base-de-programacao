using DesignPatterns.Comportamentais.ChainOfResponsability.Handlers.Interfaces;
using DesignPatterns.Comportamentais.ChainOfResponsability.Model;

namespace DesignPatterns.Comportamentais.ChainOfResponsability.Handlers;

internal class PessoaHandlerBase : IPessoaHandler
{
    private IPessoaHandler _validadorAtual;

    public IPessoaHandler SetarNovaValidacao(IPessoaHandler pessoaHandler) 
        => _validadorAtual = pessoaHandler;

    public virtual bool ValidarPessoa(PessoaModel pessoa)
    {
        if(_validadorAtual != null) 
            return _validadorAtual.ValidarPessoa(pessoa);

        return true;
    }
}
