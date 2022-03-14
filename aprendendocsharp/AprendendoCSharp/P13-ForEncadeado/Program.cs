using System;

namespace P13_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********
            //**********

            //Escrevendo asteriscos com o break
            for(int linha = 0; linha < 10; linha++)
            {
                for(int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");

                    if(coluna >= linha)
                        break;
                }
                Console.WriteLine();
            }

            //Uma forma diferente de fazer o desenho de asteriscos
            for(int linha = 0; linha < 10; linha++)
            {
                for(int coluna = 0; coluna <= linha; coluna++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Fatorial();

            Console.ReadLine();
        }

        static void Fatorial()
        {
            int numero = 6;
            int fatorial = 1;

            Console.Write("O fatorial de " + numero + "! = ");
            for(int i = 1; i <= numero; i++)
            {
                Console.Write(i);
                fatorial *= i;
                if(i != numero)
                    Console.Write("x");
            }
            Console.Write(" = " + fatorial);
        }
    }
}
