using System;
using System.Collections.Generic;
using System.Text;

namespace csharp7_3
{
    public class DeInstanciaOuEstatico
    {
        public void TestaSobrecarga()
        {
            this.EscreveMensagem(null);
            DeInstanciaOuEstatico.EscreveMensagem(null);
        }

        public void EscreveMensagem(StringBuilder stringBuilder)
        {
            Console.WriteLine(stringBuilder);
        }

        public static void EscreveMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }

    class MelhoriaEmSobrecargaDeMetodoGenerico
    {
        void TestaMelhoria()
        {
            EscreveMensagem("Mensagem", 2);
        }

        public void EscreveMensagem<T>(T objeto, int numero) where T : IDisposable
        {
            Console.WriteLine(objeto);
        }

        public void EscreveMensagem<T>(T objeto, short numero)
        {
            Console.WriteLine(objeto);
        }
    }

    class MelhoriaEmSobrecargaDeDelegates
    {
        void Teste()
        {
            int numero = int.Parse("1");
            TestaDelegate(int.Parse);
            TestaDelegate(EscreveMensagem);
        }

        public void TestaDelegate(Func<string, int> func) => Console.WriteLine("Func<string, int>");

        public void TestaDelegate(Action<string> action) => Console.WriteLine("Action<string>");

        public void EscreveMensagem(string a) => Console.WriteLine(a);
    }
}
