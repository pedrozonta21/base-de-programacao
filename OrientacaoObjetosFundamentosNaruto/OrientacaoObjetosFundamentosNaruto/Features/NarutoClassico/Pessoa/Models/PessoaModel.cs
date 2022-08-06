namespace OrientacaoObjetosFundamentosNaruto.Features.NarutoClassico.Pessoa.Models;

public class PessoaModel
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int Idade { get => DateTime.Now.Year - DataNascimento.Year; }
}
