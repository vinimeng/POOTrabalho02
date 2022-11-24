using System;
using System.Drawing;

namespace Exercicio02.Entidades
{
    internal class Cachorro : NPC
    {
        private Color Cor;
        public Cachorro(Color cor) : base()
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
