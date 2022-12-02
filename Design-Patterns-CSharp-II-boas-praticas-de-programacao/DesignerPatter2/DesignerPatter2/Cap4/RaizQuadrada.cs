using DesignerPatter2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Cap4
{
    class RaizQuadrada : IExpressao
    {
        public IExpressao Numero { get; private set; }

        public RaizQuadrada(IExpressao numero)
        {
            this.Numero = numero;
        }

        public int Avalia()
        {
            int numero = this.Numero.Avalia();
            return (int) Math.Sqrt(numero);
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeRaizQuadrada(this);
        }
    }
}
