using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class LoginPO
    {
        private readonly IWebDriver _driver;
        private readonly By _inputLogin;
        private readonly By _inputSenha;
        private readonly By _btnLogin;

        public LoginPO(IWebDriver driver)
        {
            _driver = driver;
            _inputLogin = By.Id("Login");
            _inputSenha = By.Id("Password");
            _btnLogin = By.Id("btnLogin");
        }

        public void Visitar()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/Autenticacao/Login");
        }

        public void PreencheFormulario(string login, string senha)
        {
            _driver.FindElement(_inputLogin).SendKeys(login);
            _driver.FindElement(_inputSenha).SendKeys(senha);
        }

        public void SubmeteFormulario()
        {
            _driver.FindElement(_btnLogin).Submit();
        }
    }
}
