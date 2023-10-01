using System.Collections;

namespace DesignPatterns.Comportamentais.Iterator.Abstracao;

public abstract class ColecaoIteravel : IEnumerable
{
    public abstract IEnumerator GetEnumerator();
}