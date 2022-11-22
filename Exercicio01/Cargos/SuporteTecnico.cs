namespace Exercicio01.Cargos
{
    internal class SuporteTecnico : Funcionario
    {
        public SuporteTecnico(string nome, string matricula, double salarioBase)
        {
            Nome = nome;
            Matricula = matricula;
            SalarioBase = salarioBase;
        }

        public override double CalculaSalario()
        {
            return SalarioBase;
        }
    }
}
