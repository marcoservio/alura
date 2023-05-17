using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoCriarLeilao
    {
        private readonly IWebDriver _driver;
        private readonly LoginPO _loginPO;
        private readonly NovoLeilaoPO _novoLeilaoPO;

        public AoCriarLeilao(TestFixture fixture)
        {
            _driver = fixture.Driver;
            _loginPO = new LoginPO(_driver);
            _novoLeilaoPO = new NovoLeilaoPO(_driver);
        }

        [Fact]
        public void DadoLoginAdminInfoValidasDeveCadastrarLeilao()
        {
            _loginPO.Visitar();
            _loginPO.PreencheFormulario("admin@example.org", "123");
            _loginPO.SubmeteFormulario();

            _novoLeilaoPO.Visitar();
            _novoLeilaoPO.PreencheFormulario("Leilão de Coleção 1",
                @"Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                "Item de Colecionador", 4000, "c:\\imagens\\colecao1.jpg", DateTime.Now.AddDays(20), DateTime.Now.AddDays(40));

            _novoLeilaoPO.SubmeteFormulario();

            Assert.Contains("Leilões cadastrados no sistema", _driver.PageSource);
        }
    }
}
