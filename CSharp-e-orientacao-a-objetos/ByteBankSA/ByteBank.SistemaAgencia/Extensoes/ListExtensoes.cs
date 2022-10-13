using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach(T i in itens)
            {
                lista.Add(i);
            }
        }
    }
}
