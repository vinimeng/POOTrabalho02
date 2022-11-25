using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Itens
{
    internal abstract class Item
    {
        private string Nome;
        private double Preco;

        public Item(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
