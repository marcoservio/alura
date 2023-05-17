using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class DetalheLeilaoPO
    {
        private readonly IWebDriver _driver;
        private readonly By _byInputValor;
        private readonly By _byBtnOfertar;
        private readonly By _byLanceAtual;
        public double LanceAtual
        {
            get
            {
                var valorTexto = _driver.FindElement(_byLanceAtual).Text;
                var valor = double.Parse(valorTexto, System.Globalization.NumberStyles.Currency);
                return valor;
            }
        }

        public DetalheLeilaoPO(IWebDriver driver)
        {
            _driver = driver;
            _byInputValor = By.Id("Valor");
            _byBtnOfertar = By.Id("btnDarLance");
            _byLanceAtual = By.Id("lanceAtual");
        }

        public void Visitar(int idLeilao)
        {
            _driver.Navigate().GoToUrl($"https://localhost:5001/Home/Detalhes/{idLeilao}");
        }

        public void OfertarLance(double valor)
        {
            _driver.FindElement(_byInputValor).Clear();
            _driver.FindElement(_byInputValor).SendKeys(valor.ToString());
            _driver.FindElement(_byBtnOfertar).Click();
        }
    }
}
