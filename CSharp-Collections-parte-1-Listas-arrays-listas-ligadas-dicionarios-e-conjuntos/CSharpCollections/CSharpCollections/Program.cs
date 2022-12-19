using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                    Console.WriteLine("Guincho está fazendo o pagamento");

                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine();
            Console.WriteLine("FILA:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }

        private static void Queue()
        {
            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
        }

        private static void Stack()
        {
            var navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();

            navegador.Anterior();
            navegador.Anterior();
        }

        private static void LinkedLink()
        {
            List<string> frutas = new List<string>
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            LinkedList<string> dias = new LinkedList<string>();

            var d4 = dias.AddFirst("quarta");

            Console.WriteLine("d4.Value: " + d4.Value);

            var d2 = dias.AddBefore(d4, "segunda");

            var d3 = dias.AddAfter(d2, "terça");

            var d6 = dias.AddAfter(d4, "sexta");

            var d7 = dias.AddAfter(d6, "sabado");

            var d5 = dias.AddBefore(d6, "quinta");

            var d1 = dias.AddBefore(d2, "domingo");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            var quarta = dias.Find("quarta");

            dias.Remove("quarta");
            // dias.Remove(d4);

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
        }

        private static void HashSetObjetosEDicionarios()
        {
            Curso csharpColecoes = new Curso("C# Colecoes", "Marco Sérvio");
            csharpColecoes.Adicionar(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adicionar(new Aula("Criando um Aula", 20));
            csharpColecoes.Adicionar(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafel Nercessian", 17645);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();

            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));
            Console.WriteLine();

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine("Tinini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));
            Console.WriteLine();

            Console.WriteLine("a1 == a Tonini?");
            Console.WriteLine(a1 == tonini);
            Console.WriteLine();

            Console.WriteLine("a1 é igual a Tonini?");
            Console.WriteLine(a1.Equals(tonini));
            Console.WriteLine();

            Console.Clear();

            Console.WriteLine("Quem é o aluno com matrícula 5617?");
            Aluno aluno5617 = csharpColecoes.BuscarMatriculado(5617);
            Console.WriteLine($"aluno5617: {aluno5617}");

            Console.WriteLine("Quem é o aluno 5618?");
            Console.WriteLine($"aluno5618: {csharpColecoes.BuscarMatriculado(5618)}");

            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            //csharpColecoes.Matricula(fabio);

            csharpColecoes.SubstituiAluno(fabio);

            Console.WriteLine("Quem é o aluno 5617 agora?");
            Console.WriteLine(csharpColecoes.BuscarMatriculado(5617));
        }

        private static void HashSet()
        {
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(alunos);
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();

            alunos.Add("Pricila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Faibio Gushiken");

            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();

            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();

            alunos.Add("Faibio Gushiken");

            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();

            //Ordenando HashSet
            List<string> alunosEmLista = new List<string>(alunos);

            alunosEmLista.Sort();

            Console.WriteLine(string.Join(", ", alunosEmLista));
            Console.WriteLine();
        }

        private static void ListasSomenteLeitura()
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adicionar(new Aula("Trabalhando com listas", 21));
            Imprimir(csharpColecoes.Aulas);

            csharpColecoes.Adicionar(new Aula("Criando uma aula", 20));
            csharpColecoes.Adicionar(new Aula("Modelando com Coleções", 19));
            Imprimir(csharpColecoes.Aulas);

            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);
        }

        private static void ListasObjetos()
        {
            var aulaIntro = new Aula("Introdução as coleções", 20);
            var aulaModelando = new Aula("Modelando a classe aula", 18);
            var aulaSets = new Aula("Trabalhando com conjuntos", 16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            //aulas.Add("Conclusão");

            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var item in aulas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void ImprimirLista(List<string> lst)
        {
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine(lst[i]);
            //}

            lst.ForEach(item => { Console.WriteLine(item); });

            Console.WriteLine();
        }

        private static void Arrays()
        {
            string aulaIntro = "Introdução as coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com conjuntos";

            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Console.WriteLine(aulas);
            Console.WriteLine();

            ImprimirArray(aulas);

            Console.WriteLine(aulas[0]);
            Console.WriteLine();
            Console.WriteLine(aulas[aulas.Length - 1]);
            Console.WriteLine();

            aulaIntro = "Trabalhando com Arrays";
            ImprimirArray(aulas);

            aulas[0] = "Trabalhando com Arrays";
            ImprimirArray(aulas);

            Console.WriteLine("Aula modelando está no indice " + Array.IndexOf(aulas, aulaModelando));
            //Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando)); // Antivirus esta pegando

            Array.Reverse(aulas);
            ImprimirArray(aulas);

            Array.Reverse(aulas);
            ImprimirArray(aulas);

            Array.Resize(ref aulas, 2);
            ImprimirArray(aulas);

            Array.Resize(ref aulas, 3);
            ImprimirArray(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            ImprimirArray(aulas);

            Array.Sort(aulas);
            ImprimirArray(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            ImprimirArray(copia);

            string[] clone = aulas.Clone() as string[];
            ImprimirArray(clone);

            Array.Clear(clone, 1, 2);
            ImprimirArray(clone);
        }

        private static void Listas()
        {
            string aulaIntro = "Introdução as coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            List<string> aulas = new List<string>();

            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Console.WriteLine(aulas);
            Console.WriteLine();

            ImprimirLista(aulas);

            Console.WriteLine($"A primeira aula é: {aulas[0]}");
            Console.WriteLine($"A primeira aula é: {aulas.First()}");
            Console.WriteLine();
            Console.WriteLine($"A ultima aula é: {aulas[aulas.Count - 1]}");
            Console.WriteLine($"A ultima aula é: {aulas.Last()}");
            Console.WriteLine();

            aulas[0] = "Trabalhando com listas";
            ImprimirLista(aulas);

            Console.WriteLine($"A primeira aula 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));
            Console.WriteLine();
            Console.WriteLine($"A ultima aula 'Trabalhando' é: " + aulas.Last(aula => aula.Contains("Trabalhando")));
            Console.WriteLine();
            Console.WriteLine($"A primeira aula 'Conclusão' é: " + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));
            Console.WriteLine();

            aulas.Reverse();
            ImprimirLista(aulas);

            aulas.Reverse();
            ImprimirLista(aulas);

            aulas.RemoveAt(aulas.Count - 1);
            ImprimirLista(aulas);

            aulas.Add("Conclusão");
            ImprimirLista(aulas);

            aulas.Sort();
            ImprimirLista(aulas);

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            ImprimirLista(copia);

            List<string> clone = new List<string>(aulas);
            ImprimirLista(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            ImprimirLista(clone);
        }

        private static void ImprimirArray(string[] arr)
        {
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine();
        }
    }
}
