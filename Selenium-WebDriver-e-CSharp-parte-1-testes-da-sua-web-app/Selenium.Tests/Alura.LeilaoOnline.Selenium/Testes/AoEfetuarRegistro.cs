using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoEfetuarRegistro
    {
        //Nome da classe fica com o nome do act -> AoEfetuarRegistro
        //Nome do metodo ficar como o nome do arrange e assert -> DadoInfoValidasDeveIrParaPaginaDeAgradecimento

        private readonly IWebDriver _driver;
        private readonly RegistroPO _registroPO;

        public AoEfetuarRegistro(TestFixture fixture)
        {
            _driver = fixture.Driver;
            _registroPO = new RegistroPO(_driver);
        }

        [Fact]
        public void DadoInfoValidasDeveIrParaPaginaDeAgradecimento()
        {
            _registroPO.Visitar();

            _registroPO.PreencheForm("Marco Sérvio", "marco@marco.com", "123", "123");

            _registroPO.SubmeteFormulario();

            Assert.Contains("Obrigado", _driver.PageSource);
        }

        [Theory]
        [InlineData("", "marco@marco.com", "123", "123")]
        [InlineData("Marco", "marco", "123", "123")]
        [InlineData("Marco", "marco@marco.com", "123", "21312")]
        [InlineData("Marco", "marco@marco.com", "123", "")]
        public void DadoInfoInvalidasDeveContinuarNaHome(string nome, string email, string senha, string confirmaSenha)
        {
            _registroPO.Visitar();

            _registroPO.PreencheForm(nome, email, senha, confirmaSenha);

            _registroPO.SubmeteFormulario();

            Assert.Contains("section-registro", _driver.PageSource);
        }

        [Fact]
        public void DadoNomeEmBrancoDeveMostrarMensagemDeErro()
        {
            _registroPO.Visitar();

            _registroPO.SubmeteFormulario();

            Assert.Equal("The Nome field is required.", _registroPO.NomeMensagemErro);
        }

        [Fact]
        public void DadoEmailInvalidoDeveMostrarMensagemDeErro()
        {
            _registroPO.Visitar();

            _registroPO.PreencheForm(nome: "", email: "daniel", senha: "", confirmSenha: "");

            _registroPO.SubmeteFormulario();

            Assert.Equal("Please enter a valid email address.", _registroPO.EmailMensagemErro);
        }
    }
}
