using Exercicio02.Itens;
using System.ComponentModel;

namespace Exercicio02
{
    internal class Pedido : IPrecoCalculavel
    {
        private BindingList<Item> Itens;

        public Pedido()
        {
            Itens = new BindingList<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public void RemoverItem(Item item)
        {
            Itens.Remove(item);
        }

        public void LimparItens()
        {
            Itens.Clear();
        }

        public BindingList<Item> GetItens()
        {
            return Itens;
        }

        public double CalcularPreco()
        {
            var preco = 0.0;

            foreach (var item in Itens)
            {
                preco += item.GetPreco();
            }

            return preco;
        }
    }
}
