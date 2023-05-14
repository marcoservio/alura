using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class RegistroPO
    {
        private readonly IWebDriver _driver;
        private readonly By _byFormRegistro;
        private readonly By _byInputNome;
        private readonly By _byInputEmail;
        private readonly By _byInputSenha;
        private readonly By _byInputConfirmSenha;
        private readonly By _byBtnRegistro;
        private readonly By _bySpanErroNome;
        private readonly By _bySpanErroEmail;

        public string NomeMensagemErro => _driver.FindElement(_bySpanErroNome).Text;
        public string EmailMensagemErro => _driver.FindElement(_bySpanErroEmail).Text;

        public RegistroPO(IWebDriver driver)
        {
            _driver = driver;
            _byFormRegistro = By.TagName("form");
            _byInputNome = By.Id("Nome");
            _byInputEmail = By.Id("Email");
            _byInputSenha = By.Id("Password");
            _byInputConfirmSenha = By.Id("ConfirmPassword");
            _byBtnRegistro = By.Id("btnRegistro");
            _bySpanErroNome = By.CssSelector("span.msg-erro[data-valmsg-for=Nome]");
            _bySpanErroEmail = By.CssSelector("span.msg-erro[data-valmsg-for=Email]");
        }

        public void Visitar()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001");
        }

        public void SubmeteFormulario()
        {
            _driver.FindElement(_byBtnRegistro).Click();
        }

        public void PreencheForm(string nome, string email, string senha, string confirmSenha)
        {
            _driver.FindElement(_byInputNome).SendKeys(nome);
            _driver.FindElement(_byInputEmail).SendKeys(email);
            _driver.FindElement(_byInputSenha).SendKeys(senha);
            _driver.FindElement(_byInputConfirmSenha).SendKeys(confirmSenha);
        }
    }
}
