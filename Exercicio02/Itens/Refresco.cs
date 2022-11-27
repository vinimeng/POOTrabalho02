namespace Exercicio02.Itens
{
    internal class Refresco : Item
    {
        private int QuantidadeEmMl;
        public Refresco(string nome, double preco, int quantidadeEmMl) : base(nome, preco)
        {
            QuantidadeEmMl = quantidadeEmMl;
        }

        public override double GetPreco()
        {
            return Preco;
        }
    }
}
