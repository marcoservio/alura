using System;
using System.Collections.Generic;
using System.Text;

namespace csharp7_3
{
    public class ReatribuicaoEmRefs
    {
        public static void TestaRefs()
        {
            var numeros = new[] { 1, 3, 7, 15, 31, 1023, 63, 127, 255, 511 };
            EscreverNumeros(numeros);

            ref var maiorValor = ref ObterMaiorNumero(numeros);
            Console.WriteLine($"Maior valor: {maiorValor}");

            maiorValor = maiorValor * 2;
            Console.WriteLine($"Maior valor*2: {maiorValor}");

            EscreverNumeros(numeros);
        }

        private static ref int ObterMaiorNumero(int[] numeros)
        {
            Span<int> numerosSpan = new Span<int>(numeros);
            ref var maior = ref numeros[0];

            foreach(ref var item in numerosSpan.Slice(0, 5))
            {
                if(item > maior)
                    maior = ref item;
            }

            foreach(ref var item in new MeuIteravel())
            {

            }

            return ref maior;
        }

        private static void EscreverNumeros(int[] numeros) => Console.WriteLine(string.Join(", ", numeros));
    }

    class MeuIteravel
    {
        public MeuEnumerator GetEnumerator()
        {
            return new MeuEnumerator();
        }
    }

    class MeuEnumerator
    {
        private int[] numeros = { 1, 2, 3 };

        public ref int Current { get { return ref numeros[0]; } }

        public bool MoveNext()
        {
            return false;
        }
    }
}
