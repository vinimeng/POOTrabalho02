namespace Exercicio01.Cargos
{
    internal abstract class Funcionario
    {
        protected string Nome;
        protected string Matricula;
        protected double SalarioBase;

        public Funcionario(string nome, string matricula, double salarioBase)
        {
            Nome = nome;
            Matricula = matricula;
            SalarioBase = salarioBase;
        }

        public abstract double CalculaSalario();

        public string GetNome()
        {
            return Nome;
        }

        public string GetMatricula()
        {
            return Matricula;
        }

        public double GetSalarioBase()
        {
            return SalarioBase;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
