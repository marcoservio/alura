namespace Alura.Financas.Modelos
{
	public class Conta
	{
		public string Numero { get; }
		public Cliente Titular { get; }
		public double Saldo { get; private set; }
		
		public Conta(string numero, Cliente titular)
		{
			Numero = numero;
			Titular = titular;
		}
		
		public void Deposita(double valor)
		{
			Saldo += valor;
		}
		
		
		public void Saca(double valor)
		{
			Saldo -= valor;
		}
	}
}