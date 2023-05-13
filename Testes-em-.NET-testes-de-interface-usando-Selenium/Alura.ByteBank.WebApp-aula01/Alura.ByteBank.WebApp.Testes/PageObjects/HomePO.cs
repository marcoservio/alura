using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.WebApp.Testes.PageObjects
{
    public class HomePO
    {
        private readonly IWebDriver _driver;
        private readonly By _linkHome;
        private readonly By _linkContaCorrentes;
        private readonly By _linkClientes;
        private readonly By _linkAgencias;

        public HomePO(IWebDriver drive)
        {
            _driver = drive;
            _linkHome = By.Id("home");
            _linkContaCorrentes = By.Id("contacorrente");
            _linkClientes = By.Id("clientes");
            _linkAgencias = By.Id("agencia");
        }

        public void Navegar(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void LinkHomeClick()
        {
            _driver.FindElement(_linkHome).Click();
        }

        public void LinkContaCorrenteClick()
        {
            _driver.FindElement(_linkContaCorrentes).Click();
        }

        public void LinkClientesClick()
        {
            _driver.FindElement(_linkClientes).Click();
        }

        public void LinkAgenciasClick()
        {
            _driver.FindElement(_linkAgencias).Click();
        }
    }
}
