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
    public class AoEfeturaLogout
    {
        private readonly IWebDriver _driver;
        private readonly LoginPO _loginPO;
        private readonly DashboardInteressadosPO _dashboardPO;

        public AoEfeturaLogout(TestFixture fixture)
        {
            _driver = fixture.Driver;
            _loginPO = new LoginPO(_driver);
            _dashboardPO = new DashboardInteressadosPO(_driver);
        }

        [Fact]
        public void DadoLoginValidoDeveIrParaHomeNaoLogada()
        {
            _loginPO
                .Visitar()
                .InformarEmail("fulano@example.org")
                .InformarSenha("123")
                .EfetuarLogin();

            _dashboardPO.Menu.EfetuarLogout();

            Assert.Contains("Próximos Leilões", _driver.PageSource);
        }
    }
}
