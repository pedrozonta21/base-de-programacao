using System.Collections;

namespace DesignPatterns.Comportamentais.Iterator.Abstracao;

public abstract class Iterator : IEnumerator
{
    public abstract bool MoveNext();
    public abstract void Reset();
    object IEnumerator.Current => Atual();
    protected abstract object Atual();
}