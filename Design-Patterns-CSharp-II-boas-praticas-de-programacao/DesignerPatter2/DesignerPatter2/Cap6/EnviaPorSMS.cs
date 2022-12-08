using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Cap6
{
    class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagme)
        {
            Console.WriteLine("Enviando a mensagem por SMS");
            Console.WriteLine(mensagme.Formata());
        }
    }
}
