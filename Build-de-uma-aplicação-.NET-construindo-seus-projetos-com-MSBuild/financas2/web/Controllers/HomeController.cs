using Microsoft.AspNetCore.Mvc;
using Alura.Financas.Modelos;

namespace Alura.FinancasWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var cliente = new Cliente("Fulando de tal");
            var conta = new Conta("12341", cliente);
            conta.Deposita(500);
            conta.Saca(200);
            return Ok($"O saldo da conta é {conta.Saldo}");
            return Ok("Alô, mundo!");
        }
    }
}