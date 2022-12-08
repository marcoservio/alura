using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Cap7
{
    class FilaDeTrabalho
    {
        private IList<IComando> comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this.comandos.Add(comando);
        }

        public void Processa()
        {
            foreach (var comando in this.comandos)
            {
                comando.Executa();
            }
        }
    }
}
