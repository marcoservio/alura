using Alura.Filmes.App.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Extensions
{
    public static class ClassificacaoIndicativaExtensions
    {
        private static Dictionary<string, ClassificacaoIndicativa> mapa = new Dictionary<string, ClassificacaoIndicativa>
        {
            { "G", ClassificacaoIndicativa.Livre },
            { "PG", ClassificacaoIndicativa.MaioresQue10 },
            { "PG-13", ClassificacaoIndicativa.MaioresQue13 },
            { "R", ClassificacaoIndicativa.MaioresQue14 },
            { "NC-17", ClassificacaoIndicativa.MaioresQue18 }
        };

        public static string ParaString(this ClassificacaoIndicativa valor)
        {
            return mapa.FirstOrDefault(c => c.Value == valor).Key;
        }

        public static ClassificacaoIndicativa ParaValor(this string texto)
        {
            if (!mapa.ContainsKey(texto))
                throw new Exception("Não existe enumedador com essa chave");

            return mapa.First(c => c.Key == texto).Value;
        }
    }
}
