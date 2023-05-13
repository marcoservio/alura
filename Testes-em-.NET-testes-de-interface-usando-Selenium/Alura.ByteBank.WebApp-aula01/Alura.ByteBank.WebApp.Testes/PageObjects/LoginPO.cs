using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.WebApp.Testes.PageObjects
{
    public class LoginPO
    {
        private readonly IWebDriver _driver;
        private readonly By _campoEmail;
        private readonly By _campoSenha;
        private readonly By _btnLogar;

        public LoginPO(IWebDriver drive)
        {
            this._driver = drive;
            _campoEmail = By.Id("Email");
            _campoSenha = By.Id("Senha");
            _btnLogar = By.Id("btn-logar");
        }

        public void Navegar(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void PreencherCampos(string email, string senha)
        {
            _driver.FindElement(_campoEmail).SendKeys(email);
            _driver.FindElement(_campoSenha).SendKeys(senha);
        }

        public void Logar()
        {
            _driver.FindElement(_btnLogar).Click();
        }
    }
}
