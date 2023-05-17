using Alura.LeilaoOnline.Selenium.Helpers;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    public class AoNavegarParaHomeMobile : IDisposable
    {
        private ChromeDriver _driver;

        public AoNavegarParaHomeMobile()
        {

        }

        [Fact]
        public void DataLargura992eveMostrarMenuMobile()
        {
            var deviceSettings = new ChromeMobileEmulationDeviceSettings();
            deviceSettings.Width = 992;
            deviceSettings.Height = 800;
            deviceSettings.UserAgent = "Customizada";

            var options = new ChromeOptions();
            options.EnableMobileEmulation(deviceSettings);

            _driver = new ChromeDriver(TestHelper.PastaDoExecutavel, options);
            var _homePO = new HomeNaoLogadaPO(_driver);
            _homePO.Visitar();

            Assert.True(_homePO.Menu.MenuMobileVisivel);
        }

        [Fact]
        public void DataLargura993NaoDeveMostrarMenuMobile()
        {
            var deviceSettings = new ChromeMobileEmulationDeviceSettings();
            deviceSettings.Width = 993;
            deviceSettings.Height = 800;
            deviceSettings.UserAgent = "Customizada";

            var options = new ChromeOptions();
            options.EnableMobileEmulation(deviceSettings);

            _driver = new ChromeDriver(TestHelper.PastaDoExecutavel, options);
            var _homePO = new HomeNaoLogadaPO(_driver);
            _homePO.Visitar();

            Assert.False(_homePO.Menu.MenuMobileVisivel);
        }

        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
