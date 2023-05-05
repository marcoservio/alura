using Alura.ByteBank.Infraestrutura.Teste.Servico.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.Infraestrutura.Teste.Servico
{
    public interface IPixRepositorio
    {
        PixDTO ConsultaPix(Guid pix);
    }
}
