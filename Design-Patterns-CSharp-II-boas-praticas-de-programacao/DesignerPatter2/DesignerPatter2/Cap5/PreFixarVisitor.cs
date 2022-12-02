using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignerPatter2.Cap4;

namespace DesignerPatter2.Cap5
{
    class PreFixarVisitor : IVisitor
    {
        public void ImprimeDivisao(Divisao divisao)
        {
            throw new NotImplementedException();
        }

        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            throw new NotImplementedException();
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Numero);
        }

        public void ImprimeRaizQuadrada(RaizQuadrada raiz)
        {
            throw new NotImplementedException();
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write(" + ");
            soma.Esquerda.Aceita(this);
            Console.Write(" ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write(" - ");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}
