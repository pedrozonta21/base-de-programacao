using DesignPatterns.Comportamentais.ChainOfResponsability.Model;

namespace DesignPatterns.Comportamentais.ChainOfResponsability.Handlers;

internal class ValidaPessoaForaDoSerasaHandler : PessoaHandlerBase
{
    public override bool ValidarPessoa(PessoaModel pessoa)
    {
        if(VerificarSePessoaEstaComNomeNoSerasa(pessoa)) return false;
        
        return base.ValidarPessoa(pessoa);
    }

    private static bool VerificarSePessoaEstaComNomeNoSerasa(PessoaModel pessoa) => pessoa.Cpf.Equals("1234");
}
