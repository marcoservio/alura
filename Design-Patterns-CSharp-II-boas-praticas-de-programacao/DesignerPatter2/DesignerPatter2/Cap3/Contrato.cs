using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Capt3
{
    class Contrato
    {
        public DateTime Date { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            this.Date = data;
            this.Cliente = cliente;
            this.Tipo = tipo;
        }

        public void Avanca()
        {
            if(this.Tipo == TipoContrato.Novo) this.Tipo = TipoContrato.EmAndamento;
            else if(this.Tipo == TipoContrato.EmAndamento) this.Tipo = TipoContrato.Acertado;
            else if(this.Tipo == TipoContrato.Acertado) this.Tipo = TipoContrato.Concluido;
        }

        public EstadoContrato SalvaEstado()
        {
            return new EstadoContrato(new Contrato(this.Date, this.Cliente, this.Tipo));
        }
    }
}
