namespace Exercicio02.Entidades
{
    internal class Humano : NPC
    {
        private string Sexo;

        public Humano(string sexo) : base()
        { 
            Sexo = sexo;
        }

        public override void Atualizar()
        {
            throw new System.NotImplementedException();
        }

        public override void Desenhar()
        {
            throw new System.NotImplementedException();
        }
    }
}
