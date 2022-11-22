using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Cargos
{
    internal class Analista : Funcionario
    {
        private double Bonus;

        public Analista(string nome, string matricula, double salarioBase, double bonus)
        {
            Nome = nome;
            Matricula = matricula;
            SalarioBase = salarioBase;
            Bonus = bonus;
        }

        public override double CalculaSalario()
        {
            return SalarioBase + Bonus;
        }
    }
}
