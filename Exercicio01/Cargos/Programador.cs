namespace Exercicio01.Cargos
{
    internal class Programador : Funcionario
    {
        public Programador(string nome, string matricula, double salarioBase) : base(nome, matricula, salarioBase) { }

        public override double CalculaSalario()
        {
            return SalarioBase * 2;
        }
    }
}
