namespace Exercicio01.Cargos
{
    internal abstract class Funcionario
    {
        protected string Nome;
        protected string Matricula;
        protected double SalarioBase;

        public abstract double CalculaSalario();
    }
}
