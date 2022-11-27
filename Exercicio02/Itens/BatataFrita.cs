namespace Exercicio02.Itens
{
    internal class BatataFrita : Item
    {
        private int QuantidadeEmGramas;
        public BatataFrita(string nome, double preco, int quantidadeEmGramas) : base(nome, preco)
        {
            QuantidadeEmGramas = quantidadeEmGramas;
        }

        public override double GetPreco()
        {
            return Preco;
        }
    }
}
