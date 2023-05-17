using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoNavegarParaFormNovoLeilao
    {
        private readonly IWebDriver _driver;
        private readonly LoginPO _loginPO;
        private readonly NovoLeilaoPO _novoLeilaoPO;

        public AoNavegarParaFormNovoLeilao(TestFixture fixture)
        {
            _driver = fixture.Driver;
            _loginPO = new LoginPO(_driver);
            _novoLeilaoPO = new NovoLeilaoPO(_driver);
        }

        [Fact]
        public void DadoLoginAdmDeveMostrarTresCategorias()
        {
            _loginPO.Visitar();
            _loginPO.PreencheFormulario("admin@example.org", "123");
            _loginPO.SubmeteFormulario();

            _novoLeilaoPO.Visitar();

            Assert.Equal(3, _novoLeilaoPO.Categorias.Count());
        }
    }
}
