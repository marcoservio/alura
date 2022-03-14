using System;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if(acompanhado)
            {
                mensagemAdicional = "João está acompanhado";
            }
            // Pode remover as chaves quando tem apenas uma linha dentro do bloco (IF || ESLSE)
            else
                mensagemAdicional = "João não está acompanhado";

            if(idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
