namespace Exercicio01.Cargos
{
    internal class SuporteTecnico : Funcionario
    {
        public SuporteTecnico(string nome, string matricula, double salarioBase) : base(nome, matricula, salarioBase) { }

        public override double CalculaSalario()
        {
            return SalarioBase;
        }
    }
}
