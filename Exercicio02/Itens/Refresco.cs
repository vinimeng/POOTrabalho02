using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Itens
{
    internal class Refresco : Item
    {
        private double QuantidadeEmMl;
        public Refresco(string nome, double preco, double quantidadeEmMl) : base(nome, preco)
        {
            QuantidadeEmMl = quantidadeEmMl;
        }
    }
}
