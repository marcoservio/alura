using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alura.LeilaoOnline.Selenium.Helpers
{
    public class SelectMaterialize
    {
        private readonly IWebDriver _driver;
        private readonly IWebElement _selectWrapper;
        public IEnumerable<IWebElement> Options { get; }

        public SelectMaterialize(IWebDriver driver, By bySelectWrapper)
        {
            _driver = driver;
            _selectWrapper = _driver.FindElement(bySelectWrapper);
            Options = _selectWrapper.FindElements(By.CssSelector("li>span"));
        }

        private void OpenWrapper()
        {
            _selectWrapper.Click();
        }

        private void LoseFocus()
        {
            _selectWrapper.FindElement(By.TagName("li")).SendKeys(Keys.Tab);
        }

        public void DeselectAll()
        {
            OpenWrapper();
            Options.ToList().ForEach(o =>
            {
                o.Click();
            });
            LoseFocus();
        }

        public void SelectByText(string option)
        {
            OpenWrapper();
            Options.Where(o => o.Text.Contains(option)).ToList().ForEach(o =>
            {
                o.Click();
            });
            LoseFocus();
        }
    }
}
