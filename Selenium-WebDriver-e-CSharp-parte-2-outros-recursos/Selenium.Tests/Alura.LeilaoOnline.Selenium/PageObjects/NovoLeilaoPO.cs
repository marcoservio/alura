using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class NovoLeilaoPO
    {
        private readonly IWebDriver _driver;
        private readonly By _byInputTitulo;
        private readonly By _byInputDescricao;
        private readonly By _byInputCategoria;
        private readonly By _byInputValorInicial;
        private readonly By _byInputImage;
        private readonly By _byInputInicioPregao;
        private readonly By _byInputTerminoPregao;
        private readonly By _byBtnSalvar;

        public IEnumerable<string> Categorias
        {
            get
            {
                var elementoCategoria = new SelectElement(_driver.FindElement(_byInputCategoria));
                return elementoCategoria.Options.Where(o => o.Enabled).Select(o => o.Text);
            }
        }

        public NovoLeilaoPO(IWebDriver driver)
        {
            _driver = driver;
            _byInputTitulo = By.Id("Titulo");
            _byInputDescricao = By.Id("Descricao");
            _byInputCategoria = By.Id("Categoria");
            _byInputValorInicial = By.Id("ValorInicial");
            _byInputImage = By.Id("ArquivoImagem");
            _byInputInicioPregao = By.Id("InicioPregao");
            _byInputTerminoPregao = By.Id("TerminoPregao");
            _byBtnSalvar = By.CssSelector("button[type=submit]");
        }

        public void Visitar()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/Leiloes/Novo");
        }

        public void PreencheFormulario(string titulo, string descricao, string categoria, double valor, string imagem, DateTime inicio, DateTime termino)
        {
            _driver.FindElement(_byInputTitulo).SendKeys(titulo);
            _driver.FindElement(_byInputDescricao).SendKeys(descricao);
            _driver.FindElement(_byInputCategoria).SendKeys(categoria);
            _driver.FindElement(_byInputValorInicial).SendKeys(valor.ToString());
            _driver.FindElement(_byInputImage).SendKeys(imagem);
            _driver.FindElement(_byInputInicioPregao).SendKeys(inicio.ToString("d"));
            _driver.FindElement(_byInputTerminoPregao).SendKeys(termino.ToString("d"));
        }

        public void SubmeteFormulario()
        {
            _driver.FindElement(_byBtnSalvar).Click();
        }
    }
}
