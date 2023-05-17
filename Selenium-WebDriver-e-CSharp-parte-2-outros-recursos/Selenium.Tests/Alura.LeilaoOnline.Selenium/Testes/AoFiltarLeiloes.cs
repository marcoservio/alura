using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoFiltarLeiloes
    {
        private readonly IWebDriver _driver;
        private readonly LoginPO _loginPO;
        private readonly DashboardInteressadosPO _dashboardPO;

        public AoFiltarLeiloes(TestFixture fixture)
        {
            _driver = fixture.Driver;
            _loginPO = new LoginPO(_driver);
            _dashboardPO = new DashboardInteressadosPO(_driver);
        }

        [Fact]
        public void DadoLoginInteressadaDeveMostrarPainelResultado()
        {
            _loginPO.EfetuarLogin("fulano@example.org", "123");

            _dashboardPO.Filtro.PesquisarLeiloes(new List<string> { "Arte", "Coleções" }, "", true);

            Assert.Contains("Resultado da pesquisa", _driver.PageSource);
        }
    }
}
