using System;
using System.Collections.Generic;

namespace Exercicio02.Itens
{
    internal class Combo : Item, IPrecoCalculavel
    {
        private List<Item> Itens;
        private double PorcentagemDesconto;

        public Combo(string nome, double preco, double porcentagemDesconto, List<Item> itens) : base(nome, preco)
        {
            PorcentagemDesconto = porcentagemDesconto;
            Itens = itens;
        }

        public double CalcularPreco()
        {
            var preco = Preco;

            foreach (var item in Itens)
            {
                preco += item.GetPreco();
            }

            var desconto = 1 - PorcentagemDesconto;

            return preco * desconto;
        }

        public override double GetPreco()
        {
            return CalcularPreco();
        }
    }
}
