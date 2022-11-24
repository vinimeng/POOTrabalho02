using System;
using System.Drawing;

namespace Exercicio02.Entidades
{
    internal class Tigre : NPC
    {
        private Color Cor;
        public Tigre(Color cor) : base()
        {
            Cor = cor;
        }

        public override void Atualizar()
        {
            throw new NotImplementedException();
        }

        public override void Desenhar()
        {
            throw new NotImplementedException();
        }
    }
}
