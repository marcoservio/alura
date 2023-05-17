using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoOfertarLance
    {
        private readonly IWebDriver _driver;
        private readonly LoginPO _loginPO;
        private readonly DetalheLeilaoPO _detalhePO;

        public AoOfertarLance(TestFixture fixture)
        {
            _driver = fixture.Driver;
            _loginPO = new LoginPO(_driver);
            _detalhePO = new DetalheLeilaoPO(_driver);
        }

        [Fact]
        public void DadoLoginInteressadaDeveAtualizarLanceAtual()
        {
            _loginPO.Visitar();
            _loginPO.PreencheFormulario("fulano@example.org", "123");
            _loginPO.SubmeteFormulario();

            _detalhePO.Visitar(6);

            _detalhePO.OfertarLance(300);

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(8));
            var iguais = wait.Until(drv => _detalhePO.LanceAtual == 300);

            Assert.True(iguais);
        }
    }
}
