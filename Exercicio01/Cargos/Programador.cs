namespace Exercicio01.Cargos
{
    internal class Programador : Funcionario
    {
        public Programador(string nome, string matricula, double salarioBase)
        {
            Nome = nome;
            Matricula = matricula;
            SalarioBase = salarioBase;
        }

        public override double CalculaSalario()
        {
            return SalarioBase * 2;
        }
    }
}
