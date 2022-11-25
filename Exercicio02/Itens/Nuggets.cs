using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Itens
{
    internal class Nuggets : Item
    {
        private int QuantidadeEmUnidade;

        public Nuggets(string nome, double preco, int quantidadeEmUnidade) : base(nome, preco)
        {
            QuantidadeEmUnidade = quantidadeEmUnidade;
        }
    }
}
