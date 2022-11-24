namespace Exercicio01.Cargos
{
    internal class Analista : Funcionario
    {
        private double Bonus;

        public Analista(string nome, string matricula, double salarioBase, double bonus) : base(nome, matricula, salarioBase)
        {
            Bonus = bonus;
        }

        public double GetBonus()
        {
            return Bonus;
        }

        public override double CalculaSalario()
        {
            return SalarioBase + Bonus;
        }
    }
}
