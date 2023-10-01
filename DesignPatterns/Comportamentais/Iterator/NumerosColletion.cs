using System.Collections;
using DesignPatterns.Comportamentais.Iterator.Abstracao;

namespace DesignPatterns.Comportamentais.Iterator;

public class NumerosColletion : ColecaoIteravel
{
    private readonly List<int> _listaDeNumeros = new();

    public IList<int> RetornarListaDeNumeros() => _listaDeNumeros;

    public void AdicionarNumero(int numero) => _listaDeNumeros.Add(numero);
    
    public override IEnumerator GetEnumerator() => new FimComecoIterator(this);
}