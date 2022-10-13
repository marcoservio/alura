using System;
using System.Collections.Generic;
using System.Text;

namespace csharp7_3
{
    static class TesteTuples
    {
        public static void TestaIgualdade()
        {
            var origem = ("Avenida Paulista", "900", "São Paulo");
            var destino = ("Avenida Paulista", "300", "São Paulo");

            //var mesmoLugar = origem.Item1 == destino.Item1 &&
            //                 origem.Item2 == destino.Item2 &&
            //                 origem.Item3 == destino.Item3;

            var mesmoLugar = origem == destino;

            Console.WriteLine(mesmoLugar);
        }

        public static void TestaIgualdade2()
        {
            var origem = (rua: "Avenida Paulista", numero: "900", cidade: "São Paulo");
            var destino = (numero: "900", rua: "Avenida Paulista", cidade: "São Paulo");

            var mesmoLugar = origem == destino;

            Console.WriteLine(mesmoLugar);
        }

        public static void MaisAlgunsCasos()
        {
            var ehIgual = (nome: "Pedro", idade: 15) == (nome: "Maria", idade: 12);

            (string, int) pedro = (nome: "Pedro", idade: 15);
            (string, int?) maria = (nome: "Maria", idade: 12);

            Console.WriteLine(pedro == maria);
        }
    }
}
