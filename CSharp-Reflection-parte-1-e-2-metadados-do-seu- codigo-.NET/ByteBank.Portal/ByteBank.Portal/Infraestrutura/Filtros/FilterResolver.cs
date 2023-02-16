using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Portal.Filtros;
using ByteBank.Portal.Infraestrutura.Binding;

namespace ByteBank.Portal.Infraestrutura.Filtros
{
    public class FilterResolver
    {
        public FilterResult VerificarFiltros(ActionBindingInfo actionBindingInfo)
        {
            var methodInfo = actionBindingInfo.MethodInfo;
            var atributos = methodInfo.GetCustomAttributes(typeof(FiltroAttribute), false);

            foreach (FiltroAttribute filtro in atributos)
                if (!filtro.PodeContinuar())
                    return new FilterResult(false);

            return new FilterResult(true);
        }
    }
}
