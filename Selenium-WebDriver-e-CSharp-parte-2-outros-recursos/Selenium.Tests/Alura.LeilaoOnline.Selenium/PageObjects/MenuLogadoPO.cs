using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class MenuLogadoPO
    {
        private readonly IWebDriver _driver;
        private readonly By _logoutLink;
        private readonly By _meuPerfilLink;

        public MenuLogadoPO(IWebDriver driver)
        {
            _driver = driver;
            _logoutLink = By.Id("logout");
            _meuPerfilLink = By.Id("meu-perfil");
        }

        public void EfetuarLogout()
        {
            var linkLogout = _driver.FindElement(_logoutLink);
            var linkMeuPerfil = _driver.FindElement(_meuPerfilLink);

            IAction acaoLogout = new Actions(_driver)
                .MoveToElement(linkMeuPerfil)
                .MoveToElement(linkLogout)
                .Click()
                .Build();

            acaoLogout.Perform();
        }
    }
}
