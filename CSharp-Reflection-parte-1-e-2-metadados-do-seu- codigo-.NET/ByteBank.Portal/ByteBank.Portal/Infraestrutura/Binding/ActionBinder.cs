using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura.Binding
{
    public class ActionBinder
    {
        public ActionBindingInfo ObterActionBindInfo(object controller, string path)
        {
            var idxInterrogação = path.IndexOf('?');
            var existeQueryString = idxInterrogação >= 0;

            if (!existeQueryString)
            {
                var nomeAction = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[1];
                var methodInfo = controller.GetType().GetMethod(nomeAction);

                return new ActionBindingInfo(methodInfo, Enumerable.Empty<ArgumentoNomeValor>());
            }
            else
            {
                var nomeControllerComAction = path.Substring(0, idxInterrogação);
                var nomeAction = nomeControllerComAction.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[1];
                var queryString = path.Substring(idxInterrogação + 1);

                var tuplasNomeValor = ObterArgumentoNomeValores(queryString);
                var argumentoNome = tuplasNomeValor.Select(t => t.Nome).ToArray();

                var methodInfo = ObterMethodInfoAPartirDeNomeEArgumentos(nomeAction, argumentoNome, controller);

                return new ActionBindingInfo(methodInfo, tuplasNomeValor);
            }
        }

        private IEnumerable<ArgumentoNomeValor> ObterArgumentoNomeValores(string queryString)
        {
            var tuplasNomeValor = queryString.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in tuplasNomeValor)
            {
                var partesTupla = item.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                yield return new ArgumentoNomeValor(partesTupla[0], partesTupla[1]);
            }
        }

        private MethodInfo ObterMethodInfoAPartirDeNomeEArgumentos(string nomeAction, string[] argumentos, object controller)
        {
            var argumentosCount = argumentos.Length;

            var bindingFlags =
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.DeclaredOnly;

            var methodInfo = controller.GetType().GetMethods(bindingFlags);
            var sobrecargas = methodInfo.Where(m => m.Name == nomeAction);

            foreach (var item in sobrecargas)
            {
                var parametros = item.GetParameters();

                if (argumentosCount != parametros.Length)
                    continue;

                var match =
                    parametros.All(
                        p =>
                            argumentos.Contains(p.Name)
                        );

                if (match)
                    return item;
            }

            throw new ArgumentException($"A sobrecarga do metodo {nomeAction} não foi encontrada!");
        }
    }
}
