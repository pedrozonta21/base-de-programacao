namespace ProjetoComFundamentos.Features.Pessoa.Models;

public class FuncionarioModel : PessoaModel
{
    public decimal Salario { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime DataAdmissao { get; set; }
}
