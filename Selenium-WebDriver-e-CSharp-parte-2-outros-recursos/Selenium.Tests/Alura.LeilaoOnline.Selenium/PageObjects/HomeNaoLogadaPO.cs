using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class HomeNaoLogadaPO
    {
        private readonly IWebDriver _driver;
        public MenuNaoLogadoPO Menu { get; }

        public HomeNaoLogadaPO(IWebDriver driver)
        {
            _driver = driver;
            Menu = new MenuNaoLogadoPO(_driver);
        }

        public void Visitar()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/");
        }
    }
}
