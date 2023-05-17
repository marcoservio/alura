using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class MenuNaoLogadoPO
    {
        private readonly IWebDriver _driver;
        private readonly By _byMenuMobile;
        public bool MenuMobileVisivel
        {
            get
            {
                var elemento = _driver.FindElement(_byMenuMobile);
                return elemento.Displayed;
            }
        }

        public MenuNaoLogadoPO(IWebDriver driver)
        {
            _driver = driver;
            _byMenuMobile = By.ClassName("sidenav-trigger");
        }
    }
}