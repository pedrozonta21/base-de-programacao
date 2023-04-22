using DesignPatterns.Estruturais.Flyweight.Model;

namespace DesignPatterns.Estruturais.Flyweight.ContaBancaria;

internal class ContaBancariaFlyweightFactory
{
    private Dictionary<int, ContaBancariaModel> _dicionarioDeContasBancarias;

    public ContaBancariaFlyweightFactory() => _dicionarioDeContasBancarias = new();

    public ContaBancariaModel RetornarContaBancaria(int codigoConta)
    {
        if (_dicionarioDeContasBancarias.TryGetValue(codigoConta, out var contaBancaria))
            return contaBancaria;

        throw new Exception($"Conta {codigoConta} não existe. Adicione-a pelo método {nameof(AdicionarContaAoDicionario)}");
    }

    public void AdicionarContaAoDicionario(ContaBancariaModel contaBancaria)
    {
        if (_dicionarioDeContasBancarias.ContainsKey(contaBancaria.Codigo)) return;

        _dicionarioDeContasBancarias[contaBancaria.Codigo] = contaBancaria;
    }
}
