using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura.Binding
{
    public class ActionBindingInfo
    {
        public ActionBindingInfo(MethodInfo methodInfo, IEnumerable<ArgumentoNomeValor> tuplasArgumentoNomeValor)
        {
            MethodInfo = methodInfo ?? throw new ArgumentNullException(nameof(methodInfo));

            if (tuplasArgumentoNomeValor == null)
                throw new ArgumentNullException(nameof(tuplasArgumentoNomeValor));

            TuplasArgumentoNomeValor = new ReadOnlyCollection<ArgumentoNomeValor>(tuplasArgumentoNomeValor.ToList());
        }

        public MethodInfo MethodInfo { get; private set; }
        public IReadOnlyCollection<ArgumentoNomeValor> TuplasArgumentoNomeValor { get; private set; }

        public object Invoke(object controller)
        {
            var countParametros = TuplasArgumentoNomeValor.Count;
            var possuiArgumento = countParametros > 0;

            if (!possuiArgumento)
                return MethodInfo.Invoke(controller, new object[0]);

            var parametroMethodInfo = MethodInfo.GetParameters();
            var parametrosInvoke = new object[countParametros];
            for (int i = 0; i < countParametros; i++)
            {
                var parametro = parametroMethodInfo[i];
                var parametroNome = parametro.Name;

                var argumento = TuplasArgumentoNomeValor.Single(t => t.Nome == parametroNome);

                parametrosInvoke[i] = Convert.ChangeType(argumento.Valor, parametro.ParameterType);
            }

            return MethodInfo.Invoke(controller, parametrosInvoke);
        }
    }
}
