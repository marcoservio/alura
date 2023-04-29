using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

using System;

using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Teste
{
    public class VeiculoTeste : IDisposable
    {
        ///AAA
        //Arrange -> preparação do cenario (obj, variaveis e etc)
        //Act -> invocar o metodo para de fato testar
        //Assert -> resultado obtido

        private Veiculo _veiculo;
        private ITestOutputHelper _saidaConsoleTeste;

        //Setup
        public VeiculoTeste(ITestOutputHelper saidaConsoleTeste)
        {
            _saidaConsoleTeste = saidaConsoleTeste;
            _saidaConsoleTeste.WriteLine("Construtor invocado");
            _veiculo = new Veiculo();
        }

        [Fact(DisplayName = "Teste 1")]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerarComParametro10()
        {
            //var veiculo = new Veiculo();
            _veiculo.Acelerar(10);
            Assert.Equal(100, _veiculo.VelocidadeAtual);
        }

        [Fact]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrearComParametro10()
        {
            //var veiculo = new Veiculo();
            _veiculo.Frear(10);
            Assert.Equal(-150, _veiculo.VelocidadeAtual);
        }

        [Fact]
        public void ValidaTipoVeiculo()
        {
            //var veiculo = new Veiculo();
            Assert.Equal(TipoVeiculo.Automovel, _veiculo.Tipo);
        }

        [Fact(DisplayName = "Teste Ignorado", Skip = "Teste ainda não implementado. Ignorar")]
        public void ValidaNomeProprietario()
        {

        }

        [Fact]
        public void FichaInformacaoVeiculo()
        {
            //var carro = new Veiculo();
            _veiculo.Proprietario = "Marco Sérvio";
            _veiculo.Tipo = TipoVeiculo.Automovel;
            _veiculo.Placa = "HBA-8868";
            _veiculo.Cor = "Preto";
            _veiculo.Modelo = "Stilo";

            string dados = _veiculo.ToString();

            Assert.Contains("Ficha do Veiculo", dados);
        }

        [Fact]
        public void TestaNomeProprietarioVeiculoComeMenosDeTresCaracteres()
        {
            string nomeProprietario = "ab";

            Assert.Throws<FormatException>(() => new Veiculo(nomeProprietario));
        }

        [Fact]
        public void TestaMensagemDeExcecaoDoQuartoCaractereDaPlaca()
        {
            string placa = "ASDF8888";

            var mensagem = Assert.Throws<FormatException>(() => new Veiculo().Placa = placa);

            Assert.Equal("O 4° caractere deve ser um hífen", mensagem.Message);
        }

        [Fact]
        public void TestaUltimosCaracteresPlacaVeiculoComoNumeros()
        {
            //Arrange
            string placaFormatoErrado = "ASD-995U";

            //Assert
            Assert.Throws<FormatException>(
                //Act
                () => new Veiculo().Placa = placaFormatoErrado
            );

        }

        //Cleanup
        public void Dispose()
        {
            _saidaConsoleTeste.WriteLine("Dispose invocado");
        }
    }
}
