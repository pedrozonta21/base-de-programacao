using DesignPatterns.Comportamentais.ChainOfResponsability.Model;

namespace DesignPatterns.Comportamentais.ChainOfResponsability.Handlers;

internal class ValidaPessoaSemAntecedenteCriminal : PessoaHandlerBase
{
    public override bool ValidarPessoa(PessoaModel pessoa)
    {
        if (VerificarSePessoaTemAntecedenteCriminal(pessoa)) return false;

        return base.ValidarPessoa(pessoa);
    }

    private static bool VerificarSePessoaTemAntecedenteCriminal(PessoaModel pessoa) => pessoa.Cpf.Equals("321");
}
