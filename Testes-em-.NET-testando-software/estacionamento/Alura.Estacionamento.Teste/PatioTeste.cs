using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Teste
{
    public class PatioTeste : IDisposable
    {
        private Veiculo _veiculo;
        private Patio _estacionamento;
        private Operador _operador;
        private ITestOutputHelper _saidaConsoleTeste;

        public PatioTeste(ITestOutputHelper saidaConsoleTeste)
        {
            _saidaConsoleTeste = saidaConsoleTeste;
            _saidaConsoleTeste.WriteLine("Construtor invocado");

            _veiculo = new Veiculo();

            _estacionamento = new Patio();

            _operador = new Operador();
            _operador.Nome = "Pedro Fagundes";
        }

        [Fact]
        public void ValidaFaturamento()
        {
            //Arrange
            //var estacionamento = new Patio();
            //var veiculo = new Veiculo();
            //Operador operador = new Operador();
            //operador.Nome = "Pedro Fagundes";

            _estacionamento.OperadorPartio = _operador;
            _veiculo.Proprietario = "Marco Sérvio";
            _veiculo.Tipo = TipoVeiculo.Automovel;
            _veiculo.Cor = "Verde";
            _veiculo.Modelo = "Stilo";
            _veiculo.Placa = "HBA-8868";

            _estacionamento.RegistrarEntradaVeiculo(_veiculo);
            _estacionamento.RegistrarSaidaVeiculo(_veiculo.Placa);

            //Act
            double faturamento = _estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("Marco Sérvio", "ASD-1498", "Preto", "Gol")]
        [InlineData("Jose Sérvio", "POL-9242", "Cinza", "Palio")]
        [InlineData("Maria Sérvio", "GRD-6524", "Vermelho", "Strada")]
        [InlineData("Pedro Sérvio", "RDS-2121", "Azul", "Corsa")]
        public void ValidaFaturamentoComVariosVeiculos(string proprietario, string placa, string cor, string modelo)
        {
            //var estacionamento = new Patio();
            //var veiculo = new Veiculo();
            _estacionamento.OperadorPartio = _operador;
            _veiculo.Proprietario = proprietario;
            _veiculo.Cor = cor;
            _veiculo.Modelo = modelo;
            _veiculo.Placa = placa;

            _estacionamento.RegistrarEntradaVeiculo(_veiculo);
            _estacionamento.RegistrarSaidaVeiculo(_veiculo.Placa);

            double faturamento = _estacionamento.TotalFaturado();

            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("Marco Sérvio", "ASD-1498", "Preto", "Gol")]
        public void LocalizaVeiculoNoPatioComBaseNoIdTicket(string proprietario, string placa, string cor, string modelo)
        {
            //var estacionamento = new Patio();
            //var veiculo = new Veiculo();
            _estacionamento.OperadorPartio = _operador;
            _veiculo.Proprietario = proprietario;
            _veiculo.Cor = cor;
            _veiculo.Modelo = modelo;
            _veiculo.Placa = placa;

            _estacionamento.RegistrarEntradaVeiculo(_veiculo);

            var consultado = _estacionamento.PesquisaVeiculo(_veiculo.IdTicket);

            Assert.Contains("### Ticket Estacionamento Alura ###", consultado.Ticket);
        }

        [Fact]
        public void AlterarDadosVeiculo()
        {
            //var estacionamento = new Patio();
            //var veiculo = new Veiculo();
            _estacionamento.OperadorPartio = _operador;
            _veiculo.Proprietario = "Marco Sérvio";
            _veiculo.Tipo = TipoVeiculo.Automovel;
            _veiculo.Cor = "Verde";
            _veiculo.Modelo = "Stilo";
            _veiculo.Placa = "HBA-8868";

            _estacionamento.RegistrarEntradaVeiculo(_veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "Marco Sérvio";
            veiculoAlterado.Placa = "HBA-8868";
            veiculoAlterado.Cor = "Preto";
            _veiculo.Modelo = "Stilo";

            Veiculo alterado = _estacionamento.AlterarDadosVeiculo(veiculoAlterado);

            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);
        }

        public void Dispose()
        {
            _saidaConsoleTeste.WriteLine("Dispose invocado");
        }
    }
}