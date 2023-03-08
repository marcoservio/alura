using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Relatorio : IRelatorio
    {
        private readonly ICatalogo catalogo;

        public Relatorio(ICatalogo catalogo)
        {
            this.catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var item in catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{item.Codigo,-5}{item.Nome,-40}{item.Preco.ToString("C"),-5}\r\n");
            }
        }
    }
}
