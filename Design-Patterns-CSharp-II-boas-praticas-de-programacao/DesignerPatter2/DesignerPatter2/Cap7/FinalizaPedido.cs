using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Cap7
{
    class FinalizaPedido : IComando
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine($"Finalizando o pedido do cliente {pedido.Cliente}");
            pedido.Finaliza();
        }
    }
}
