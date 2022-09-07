namespace ProjetoComFundamentos.Features.Pessoa.Models;

public class EmpresaModel : PessoaModel
{
    public string Cnpj { get; set; }
    public string NomeFantasiaa { get; set; }
    public string RazaoSocial { get; set; }
    public string InscricaoEstadual { get; set; }
    public string InscricaoMunicipal { get; set; }
}
