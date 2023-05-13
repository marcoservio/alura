using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using Xunit;
using Xunit.Abstractions;
using Alura.ByteBank.WebApp.Testes.PageObjects;
using Alura.ByteBank.WebApp.Testes.Utilitarios;

namespace Alura.ByteBank.WebApp.Testes
{
    public class AposRealizarLogin : IClassFixture<Gerenciador>
    {
        private readonly IWebDriver _driver;
        private readonly ITestOutputHelper _saidaConsoleTeste;
        private readonly LoginPO _loginPO;
        private readonly HomePO _homePO;

        public AposRealizarLogin(Gerenciador gerenciador, ITestOutputHelper saidaConsoleTeste)
        {
            _driver = gerenciador.Driver;
            _saidaConsoleTeste = saidaConsoleTeste;
            _loginPO = new LoginPO(_driver);
            _homePO = new HomePO(_driver);
        }

        private void Logar()
        {
            _loginPO.Navegar("https://localhost:44309/UsuarioApps/Login");
            _loginPO.PreencherCampos("andre@email.com", "senha01");
            _loginPO.Logar();
        }

        [Fact]
        public void AposRealizarLoginVerificarSeExisteOpcaoAgenciaMenu()
        {
            Logar();

            Assert.Contains("Agência", _driver.PageSource);
        }

        [Fact]
        public void TentaRealizarLoginSemPreencherCampos()
        {
            _loginPO.Navegar("https://localhost:44309/UsuarioApps/Login");
            _loginPO.Logar();

            Assert.Contains("The Email field is required.", _driver.PageSource);
            Assert.Contains("The Senha field is required.", _driver.PageSource);
        }

        [Fact]
        public void TentaRealizarLoginComSenhaInvalida()
        {
            _loginPO.Navegar("https://localhost:44309/UsuarioApps/Login");
            _loginPO.PreencherCampos("andre@email.com", "senha010");
            _loginPO.Logar();

            Assert.Contains("Login", _driver.PageSource);
        }

        [Fact]
        public void RealizarLoginAcessaMenuECadastraCliente()
        {
            Logar();

            _driver.FindElement(By.LinkText("Cliente")).Click();
            _driver.FindElement(By.LinkText("Adicionar Cliente")).Click();

            _driver.FindElement(By.Name("Identificador")).Click();
            _driver.FindElement(By.Name("Identificador")).SendKeys("28767910-a088-4014-8f86-5765842b836c");
            _driver.FindElement(By.Name("CPF")).Click();
            _driver.FindElement(By.Name("CPF")).SendKeys("10606435611");
            _driver.FindElement(By.Name("Nome")).Click();
            _driver.FindElement(By.Name("Nome")).SendKeys("Marco Sérvio");
            _driver.FindElement(By.Name("Profissao")).Click();
            _driver.FindElement(By.Name("Profissao")).SendKeys("Desenvolvedor");

            _driver.FindElement(By.CssSelector(".btn-primary")).Click();
            _driver.FindElement(By.LinkText("Home")).Click();

            Assert.Contains("Logout", _driver.PageSource);
        }

        [Fact]
        public void RealizaLoginAcessarListagemDeContas()
        {
            Logar();

            _driver.FindElement(By.Id("contacorrente")).Click();

            IReadOnlyCollection<IWebElement> elements = _driver.FindElements(By.TagName("a"));

            foreach (var e in elements)
                _saidaConsoleTeste.WriteLine(e.Text);

            var elemento = (from webElemento in elements
                            where webElemento.Text.Contains("Detalhes")
                            select webElemento).FirstOrDefault();

            elemento.Click();

            Assert.Contains("Voltar", _driver.PageSource);
        }

        [Fact]
        public void RealizaLoginAcessaListagemDeContasHomePO()
        {
            Logar();

            _homePO.LinkContaCorrenteClick();

            Assert.Contains("Adicionar Conta-Corrente", _driver.PageSource);
        }
    }
}
