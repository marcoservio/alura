using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class FiltroLeiloesPO
    {
        private readonly IWebDriver _driver;
        private readonly By _bySelectCategorias;
        private readonly By _byInputTermo;
        private readonly By _byInputAndamento;
        private readonly By _byBtnPesquisar;

        public FiltroLeiloesPO(IWebDriver driver)
        {
            _driver = driver;
            _bySelectCategorias = By.ClassName("select-wrapper");
            _byInputTermo = By.Id("termo");
            _byInputAndamento = By.ClassName("switch");
            _byBtnPesquisar = By.CssSelector("form>button.btn");
        }

        public void PesquisarLeiloes(List<string> categorias, string termo, bool emAndamento)
        {
            var select = new SelectMaterialize(_driver, _bySelectCategorias);
            select.DeselectAll();
            categorias.ForEach(categ =>
            {
                select.SelectByText(categ);
            });

            _driver.FindElement(_byInputTermo).SendKeys(termo);
            if (emAndamento)
                _driver.FindElement(_byInputAndamento).Click();

            _driver.FindElement(_byBtnPesquisar).Click();
        }
    }
}
