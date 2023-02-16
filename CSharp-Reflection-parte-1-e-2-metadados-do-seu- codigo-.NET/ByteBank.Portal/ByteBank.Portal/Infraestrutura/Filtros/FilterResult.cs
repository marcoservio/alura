using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura.Filtros
{
    public class FilterResult
    {
        public FilterResult(bool podeContinuar)
        {
            PodeContinuar = podeContinuar;
        }

        public bool PodeContinuar { get; private set; }
    }
}
