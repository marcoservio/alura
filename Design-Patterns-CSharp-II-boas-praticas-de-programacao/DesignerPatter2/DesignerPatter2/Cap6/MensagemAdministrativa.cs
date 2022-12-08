using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Cap6
{
    class MensagemAdministrativa : IMensagem
    {
        private string nome;

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        public IEnviador Enviador { get; set; }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format($"Enviando a mensagem para o administrador {nome}");
        }
    }
}
