using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class SemResposta : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public SemResposta(Resposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            Console.WriteLine("");
        }
    }
}
