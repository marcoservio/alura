using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Alura.ByteBank.WebApp.Testes
{
    public class NavegandoNaPaginaHome : IDisposable
    {
        private readonly IWebDriver _driver;

        public NavegandoNaPaginaHome()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        [Fact]
        public void CarregaPaginaNomeEVerificaTituloDaPagina()
        {
            _driver.Navigate().GoToUrl("https://localhost:44309");

            Assert.Contains("WebApp", _driver.Title);
        }

        [Fact]
        public void CarregadaPaginaHomeVerificarExistenciaLinkLoginEHome()
        {
            _driver.Navigate().GoToUrl("https://localhost:44309");

            Assert.Contains("Login", _driver.PageSource);
            Assert.Contains("Home", _driver.PageSource);
        }

        [Fact]
        public void LogandoNoSistema()
        {
            _driver.Navigate().GoToUrl("https://localhost:44309/");
            _driver.Manage().Window.Size = new System.Drawing.Size(862, 1015);
            _driver.FindElement(By.LinkText("Login")).Click();
            _driver.FindElement(By.Id("Email")).SendKeys("andre@email.com");
            _driver.FindElement(By.Id("Senha")).SendKeys("senha01");
            _driver.FindElement(By.Id("btn-logar")).Click();
            _driver.FindElement(By.CssSelector(".btn")).Click();
            _driver.Close();
        }

        [Fact]
        public void ValidaLinkDeLoginNaHome()
        {
            _driver.Navigate().GoToUrl("https://localhost:44309/");

            var linkLogin = _driver.FindElement(By.LinkText("Login"));

            linkLogin.Click();

            Assert.Contains("img", _driver.PageSource);
        }

        [Fact]
        public void TentaAcessarPaginaSemEstarLogado()
        {
            _driver.Navigate().GoToUrl("https://localhost:44309/Agencia/Index");

            Assert.Contains("401", _driver.PageSource);
        }

        [Fact]
        public void AcessaPaginaSemEstarLogadoVerificaURL()
        {
            _driver.Navigate().GoToUrl("https://localhost:44309/Agencia/Index");

            Assert.Contains("https://localhost:44309/Agencia/Index", _driver.Url);
            Assert.Contains("401", _driver.PageSource);
        }

        public void Dispose()
        {
            _driver.Quit();
            GC.SuppressFinalize(this);
        }
    }
}
