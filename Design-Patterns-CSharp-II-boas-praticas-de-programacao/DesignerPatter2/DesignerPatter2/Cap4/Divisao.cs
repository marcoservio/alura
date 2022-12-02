using DesignerPatter2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Cap4
{
    class Divisao : IExpressao
    {
        public IExpressao Direita { get; private set; }
        public IExpressao Esquerda { get; private set; }

        public Divisao(IExpressao direita, IExpressao esquerda)
        {
            this.Direita = direita;
            this.Esquerda = esquerda;
        }

        public int Avalia()
        {
            int valorDireita = Direita.Avalia();
            int valorEsquerda = Esquerda.Avalia();

            return valorEsquerda / valorDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeDivisao(this);
        }
    }
}
