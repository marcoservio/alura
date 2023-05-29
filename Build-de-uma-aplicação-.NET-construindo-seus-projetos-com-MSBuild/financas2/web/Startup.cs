using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace Alura.FinancasWeb
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
		}
		
		public void Configure(IApplicationBuilder app)
		{
			app.UseMvcWithDefaultRoute();
		}
	}
}