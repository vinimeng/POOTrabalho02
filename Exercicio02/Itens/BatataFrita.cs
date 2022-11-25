using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Itens
{
    internal class BatataFrita : Item
    {
        private double QuantidadeEmGramas;
        public BatataFrita(string nome, double preco, double quantidadeEmGramas) : base(nome, preco)
        {
            QuantidadeEmGramas = quantidadeEmGramas;
        }
    }
}
