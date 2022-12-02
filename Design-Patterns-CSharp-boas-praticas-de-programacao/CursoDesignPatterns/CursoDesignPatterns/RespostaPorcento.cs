using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RespostaPorcento : Resposta
    {
        public Resposta OutraReposta { get; private set; }

        public RespostaPorcento(Resposta outraResposta)
        {
            OutraReposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if(req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else if(OutraReposta != null)
            {
                OutraReposta.Responde(req, conta);
            }
            else
            {
                // não existe próxima na corrente, e ninguém atendeu a requisição!
                // poderíamos não ter feito nada aqui, caso não fosse necessário!
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
