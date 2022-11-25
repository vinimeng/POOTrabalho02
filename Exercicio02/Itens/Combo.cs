using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Itens
{
    internal class Combo : Item, IPrecoCalculavel
    {
        private List<Item> Itens;

        public Combo(string nome, double preco = 0) : base(nome, preco)
        {
        }

        public double CalcularPreco()
        {
            throw new NotImplementedException();
        }
    }
}
