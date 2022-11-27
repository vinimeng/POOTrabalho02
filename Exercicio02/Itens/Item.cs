namespace Exercicio02.Itens
{
    internal abstract class Item
    {
        protected string Nome;
        protected double Preco;

        public Item(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public abstract double GetPreco();

        public override string ToString()
        {
            return Nome + " - " + GetPreco().ToString("c");
        }
    }
}
