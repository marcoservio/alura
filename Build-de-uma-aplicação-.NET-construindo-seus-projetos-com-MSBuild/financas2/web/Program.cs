using Microsoft.AspNetCore.Hosting;

namespace Alura.FinancasWeb
{
	public class Program
	{
		static void Main()
		{
			new WebHostBuilder()
				.UseKestrel()
				.UseStartup<Startup>()
				.Build()
				.Run();
		}
	}
}