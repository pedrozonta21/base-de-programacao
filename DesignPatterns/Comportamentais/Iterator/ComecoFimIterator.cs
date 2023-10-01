namespace DesignPatterns.Comportamentais.Iterator;

public class ComecoFimIterator : Abstracao.Iterator
{
    private readonly NumerosColletion _listaDeNumeros;
    private int _posicao = -1;
    
    public ComecoFimIterator(NumerosColletion numerosColletion) => _listaDeNumeros = numerosColletion;


    public override bool MoveNext()
    {
        if (_posicao >= _listaDeNumeros.RetornarListaDeNumeros().Count) return false;

        _posicao++;
        return true;
    }

    public override void Reset() => _posicao = 0;

    protected override object Atual() => _listaDeNumeros.RetornarListaDeNumeros()[_posicao];
}