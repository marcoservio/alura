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
    public class AoEfetuarLogin
    {
        private readonly IWebDriver _driver;
        private readonly LoginPO _loginPO;

        public AoEfetuarLogin(TestFixture fixture)
        {
            _driver = fixture.Driver;
            _loginPO = new LoginPO(_driver);
        }

        [Fact]
        public void DadoCredenciaisValidasDeveIrParaDashboard()
        {
            _loginPO.Visitar();
            _loginPO.PreencheFormulario("fulano@example.org", "123");

            _loginPO.SubmeteFormulario();

            Assert.Contains("Dashboard", _driver.Title);
        }

        [Fact]
        public void DadoCredenciaisInvalidasDeveContinuarLogin()
        {
            _loginPO.Visitar();
            _loginPO.PreencheFormulario("fulano@example.org", "");

            _loginPO.SubmeteFormulario();

            Assert.Contains("Login", _driver.PageSource);
        }
    }
}
