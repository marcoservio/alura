using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }

        private static void Foreach()
        {
            var meses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            foreach (var mes in meses)
            {
                meses[0] = meses[0].ToUpper();
                Console.WriteLine(mes);
            }
            Console.WriteLine();
        }

        private static void ConvertendoColecoes()
        {
            Console.WriteLine("string para object");
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);
            Console.WriteLine();

            Console.WriteLine("List<string> para List<object>");
            IList<string> lstMeses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            //IList<object> lstObj = lstMeses;
            Console.WriteLine();

            Console.WriteLine("string[] para object[]");
            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            object[] arrayObj = arrayMeses; //COVARIÂNCIA
            Console.WriteLine(arrayObj);
            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }
            arrayObj[0] = "Primeiro Mes";
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();
            //arrayObj[0] = 112432;
            //Console.WriteLine(arrayObj[0]);
            //Console.WriteLine();

            Console.WriteLine("List<string> para IEnumerable<object>");
            IEnumerable<object> enumObj = lstMeses; //COVARIÂNCIA
            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
            //enumObj[0] = 11234;
            Console.WriteLine();
        }

        private static void Linq()
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            //meses.Sort();

            //foreach (var mes in meses)
            //{
            //    if(mes.Dias == 31)
            //        Console.WriteLine(mes.Nome.ToUpper());
            //}

            var consulta = meses.Where(m => m.Dias == 31).OrderBy(m => m.Nome).Select(m => m.Nome.ToUpper());
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            var consulta1 = meses.Take(3);
            foreach (var item in consulta1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var consulta2 = meses.Skip(3);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var consulta3 = meses.Skip(6).Take(3);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var consulta4 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var consulta5 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("Concatenando duas sequências");
            var consulta6 = seq1.Concat(seq2);
            foreach (var item in consulta6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("União de duas sequências");
            var consulta7 = seq1.Union(seq2);
            foreach (var item in consulta7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("União de duas sequência com comparador");
            var consulta8 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Interseção de duas sequências");
            var consulta9 = seq1.Intersect(seq2);
            foreach (var item in consulta9)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Exceto: elementos de seq1 que não estão em seq2");
            var consulta10 = seq1.Except(seq2);
            foreach (var item in consulta10)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void JaggedArrays()
        {
            string[][] familias = new string[3][];

            familias[0] = new string[] { "Fred", "Wilma", "Pedrita", };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie", };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(", ", familia));
            }
        }

        private static void ArrayMultidimensional()
        {
            string[,] resultados = new string[4, 3];
            //{
            //    { "Alemanha", "Espanha", "Itália" },
            //    { "Argentina", "Holanda", "França" },
            //    { "Holanda", "Alemanha", "Alemanha" }
            //};

            resultados[0, 0] = "Alemanha";
            resultados[1, 0] = "Argentina";
            resultados[2, 0] = "Holanda";
            resultados[3, 0] = "Brasil";

            resultados[0, 1] = "Espanha";
            resultados[1, 1] = "Holanda";
            resultados[2, 1] = "Alemanha";
            resultados[3, 1] = "Uruguai";

            resultados[0, 2] = "Italia";
            resultados[1, 2] = "França";
            resultados[2, 2] = "Alemanha";
            resultados[3, 2] = "Portugal";

            //foreach (var selecao in resultados)
            //{
            //    Console.WriteLine(selecao);
            //}

            for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
            {
                int ano = 2014 - copa * 4;
                Console.Write(ano.ToString().PadRight(12));
            }
            Console.WriteLine();
            for (int i = 0; i <= resultados.GetUpperBound(0); i++)
            {
                for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
                {
                    Console.Write(resultados[i, copa].PadRight(12));
                }
                Console.WriteLine();
            }
        }

        private static void SortedSet()
        {
            ISet<string> alunos = new SortedSet<string>(new ComparadadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessiano",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ISet<string> outroConjunto = new HashSet<string>();

            //este conjunto é subconjunto do outro?
            alunos.IsSubsetOf(outroConjunto);

            //este conjunto é superconjunto do outro?
            alunos.IsSupersetOf(outroConjunto);

            //os cojuntos contêm os mesmo elementos?
            alunos.SetEquals(outroConjunto);

            //subtrai os elementos da outra coleção que também estão neste conjunto
            alunos.ExceptWith(outroConjunto);

            //intersecção dos conjuntos
            alunos.IntersectWith(outroConjunto);

            //somente em um ou outro conjunto
            alunos.SymmetricExceptWith(outroConjunto);

            //união de conjuntos
            alunos.UnionWith(outroConjunto);
        }

        private static void SortedDictionary()
        {
            IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            alunos.Remove("AL");
            alunos.Add("MO", new Aluno("Marcelo", 12345));
            Console.WriteLine();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
