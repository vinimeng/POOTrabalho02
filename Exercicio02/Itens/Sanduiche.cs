namespace Exercicio02.Itens
{
    internal class Sanduiche : Item
    {
        private bool LinhaNobre;
        private double AdicionalLinhaNobre;
        public Sanduiche(string nome, double preco, bool linhaNobre, double adicionalLinhaNobre) : base(nome, preco)
        {
            LinhaNobre = linhaNobre;
            AdicionalLinhaNobre = adicionalLinhaNobre;
        }

        public override double GetPreco()
        {
            return LinhaNobre ? AdicionalLinhaNobre + Preco : Preco;
        }
    }
}
