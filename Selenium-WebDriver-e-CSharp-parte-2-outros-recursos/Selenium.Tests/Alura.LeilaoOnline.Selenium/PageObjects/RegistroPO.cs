﻿using System;
using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class RegistroPO
    {
        private IWebDriver driver;
        private By byFormRegistro;
        private By byInputNome;
        private By byInputEmail;
        private By byInputSenha;
        private By byInputConfirmSenha;
        private By byBotaoRegistro;
        private By bySpanErroEmail;
        private By bySpanErroNome;

        public string EmailMensagemErro => driver.FindElement(bySpanErroEmail).Text;

        public string NomeMensagemErro => driver.FindElement(bySpanErroNome).Text;

        public RegistroPO(IWebDriver driver)
        {
            this.driver = driver;
            byFormRegistro = By.TagName("form");
            byInputNome = By.Id("Nome");
            byInputEmail = By.Id("Email");
            byInputSenha = By.Id("Password");
            byInputConfirmSenha = By.Id("ConfirmPassword");
            byBotaoRegistro = By.Id("btnRegistro");
            bySpanErroEmail = By.CssSelector("span.msg-erro[data-valmsg-for=Email]");
            bySpanErroNome = By.CssSelector("span.msg-erro[data-valmsg-for=Nome]");
        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000");
        }

        public void SubmeteFormulario()
        {
            driver.FindElement(byBotaoRegistro).Click();
        }

        public void PreencheFormulario(
            string nome, 
            string email, 
            string senha, 
            string confirmSenha)
        {
            driver.FindElement(byInputNome).SendKeys(nome);
            driver.FindElement(byInputEmail).SendKeys(email);
            driver.FindElement(byInputSenha).SendKeys(senha);
            driver.FindElement(byInputConfirmSenha).SendKeys(confirmSenha);
        }
    }
}
