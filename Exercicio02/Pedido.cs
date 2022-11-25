using Exercicio02.Itens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Pedido : IPrecoCalculavel
    {
        private List<Item> Itens;

        public void AdicionarItem(Item item) { }
        public void RemoverItem(Item item) { }
        public double CalcularPreco()
        {
            throw new NotImplementedException();
        }
    }
}
