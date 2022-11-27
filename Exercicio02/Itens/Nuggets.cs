namespace Exercicio02.Itens
{
    internal class Nuggets : Item
    {
        private int QuantidadeEmUnidade;

        public Nuggets(string nome, double preco, int quantidadeEmUnidade) : base(nome, preco)
        {
            QuantidadeEmUnidade = quantidadeEmUnidade;
        }

        public override double GetPreco()
        {
            return Preco;
        }
    }
}
