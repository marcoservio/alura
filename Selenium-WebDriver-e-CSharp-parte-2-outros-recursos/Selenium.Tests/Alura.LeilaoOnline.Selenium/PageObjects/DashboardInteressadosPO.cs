using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class DashboardInteressadosPO
    {
        private readonly IWebDriver _driver;
        public MenuLogadoPO Menu { get; }
        public FiltroLeiloesPO Filtro { get; }

        //Xpath testar no navegador inspecionar crtl+f
        //"/html/body/div[2]/div/div[1]/div/div/table/tbody/tr[9]"
        //"//table/tbody/tr[9]"
        //"//div[@class='card minhas-ofertas']/*/table/tbody/tr[last()]"
        //"//div[contains(@class,'minhas-ofertas')]/*/table/tbody/tr[last()]"

        public DashboardInteressadosPO(IWebDriver driver)
        {
            _driver = driver;
            Menu = new MenuLogadoPO(_driver);
            Filtro = new FiltroLeiloesPO(_driver);
        }
    }
}
