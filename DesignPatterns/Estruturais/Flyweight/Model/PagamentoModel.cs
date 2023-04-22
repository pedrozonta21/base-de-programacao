namespace DesignPatterns.Estruturais.Flyweight.Model
{
    internal class PagamentoModel
    {
        public int Codigo { get; set; }
        public ContaBancariaModel ContaBancaria { get; set; }
        public PagadorModel Pagador { get; set; }
    }
}
