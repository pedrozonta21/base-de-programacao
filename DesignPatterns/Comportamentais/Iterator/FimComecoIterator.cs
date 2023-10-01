namespace DesignPatterns.Comportamentais.Iterator;

public class FimComecoIterator : Abstracao.Iterator
{
    private readonly NumerosColletion _listaDeNumeros;
    private int _posicao;

    public FimComecoIterator(NumerosColletion numerosColletion)
    {
        _listaDeNumeros = numerosColletion;
        _posicao = _listaDeNumeros.RetornarListaDeNumeros().Count;
    }

    public override bool MoveNext()
    {
        if (_posicao <= 0) return false;

        _posicao--;
        return true;
    }

    public override void Reset() => _posicao = _listaDeNumeros.RetornarListaDeNumeros().Count;

    protected override object Atual() => _listaDeNumeros.RetornarListaDeNumeros()[_posicao];
}