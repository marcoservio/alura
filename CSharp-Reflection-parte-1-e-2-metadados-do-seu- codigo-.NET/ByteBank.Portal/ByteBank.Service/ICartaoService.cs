using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Service
{
    public interface ICartaoService
    {
        string ObterCartaoCreditoDestaque();
        string ObterCartaoDebitoDestaque();
    }
}
