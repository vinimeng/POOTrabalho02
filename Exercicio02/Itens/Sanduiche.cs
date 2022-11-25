using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
