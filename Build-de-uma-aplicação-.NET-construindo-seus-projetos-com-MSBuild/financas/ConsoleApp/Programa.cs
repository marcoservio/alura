using System;
using Alura.Financas.Modelos;

namespace Alura.Financas.ConsoleApp
{
	public class Programa
	{
		static void Main()
		{
			var cliente = new Cliente("Fulano de Tal");
			var conta = new Conta("2890-13", cliente);
			conta.Deposita(200);
			conta.Saca(50);
			conta.Deposita(500);
			conta.Saca(400);
			Console.WriteLine(conta.Saldo);
		}
	}
}