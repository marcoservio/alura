using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Capt3
{
    class EstadoContrato
    {
        public Contrato Contrato { get; private set; }

        public EstadoContrato(Contrato contrato)
        {
            this.Contrato = contrato;
        }
    }
}
