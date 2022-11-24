using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Entidades
{
    internal abstract class NPC : IEntidade
    {
        public Guid ID { get; set; }
        public string Estado { get; set; }

        public NPC()
        {
            ID = Guid.NewGuid();
            Estado = "Normal";
        }

        public abstract void Atualizar();

        public abstract void Desenhar();
    }
}
