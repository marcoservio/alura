using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Service.Cartao
{
    public class CartaoServiceTeste : ICartaoService
    {
        public string ObterCartaoCreditoDestaque() => "ByteBank Gold Plantinum Extra Premium Special";

        public string ObterCartaoDebitoDestaque() => "ByteBank Estudante Sem Taxas de Manuteção";
    }
}
