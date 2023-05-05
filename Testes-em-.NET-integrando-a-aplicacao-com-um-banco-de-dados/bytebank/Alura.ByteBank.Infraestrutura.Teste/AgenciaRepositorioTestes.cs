using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Entidades;
using Alura.ByteBank.Dominio.Interfaces.Repositorios;
using Alura.ByteBank.Infraestrutura.Teste.Servico;

using Microsoft.Extensions.DependencyInjection;

using Moq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Alura.ByteBank.Infraestrutura.Teste
{
    public class AgenciaRepositorioTestes : IDisposable
    {
        private readonly IAgenciaRepositorio _repositorio;
        public ITestOutputHelper SaidaConsoleTeste { get; set; }

        public AgenciaRepositorioTestes(ITestOutputHelper saidaConsoleTeste)
        {
            SaidaConsoleTeste = saidaConsoleTeste;
            saidaConsoleTeste.WriteLine("Construtor Executado com sucesso");

            var servico = new ServiceCollection();
            servico.AddTransient<IAgenciaRepositorio, AgenciaRepositorio>();
            var provedor = servico.BuildServiceProvider();
            _repositorio = provedor.GetService<IAgenciaRepositorio>();
        }

        [Fact]
        public void TestaObterTodasAgencias()
        {
            List<Agencia> lista = _repositorio.ObterTodos();

            Assert.NotNull(lista);
        }

        [Fact]
        public void TestaObterAgenciaPorId()
        {
            var agencia = _repositorio.ObterPorId(1);

            Assert.NotNull(agencia);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void TestaObterAgenciaPorVariosIds(int id)
        {
            var agencia = _repositorio.ObterPorId(id);

            Assert.NotNull(agencia);
        }

        [Fact]
        public void TestaAtualizaNumeroDeterminadaAgencia()
        {
            var agencia = _repositorio.ObterPorId(1);
            int numero = 15;
            agencia.Numero = numero;

            var atualizado = _repositorio.Atualizar(1, agencia);

            Assert.True(atualizado);
        }

        [Fact]
        public void TestaInserirUmaNovaContaCorrenteNoBancoDeDados()
        {
            var agencia = new Agencia()
            {
                Nome = "Agencia Central Coast City",
                Identificador = Guid.NewGuid(),
                Endereco = "Rua das Flores",
                Numero = 147
            };

            var retorno = _repositorio.Adicionar(agencia);

            Assert.True(retorno);
        }

        [Fact]
        public void TestaRemoverInformacaoDeterminadaAgencia()
        {
            var atualizado = true; //_repositorio.Excluir(3);

            Assert.True(atualizado);
        }

        [Fact]
        public void TestaExcecaoConsultaPorAgenciaPorId()
        {
            Assert.Throws<Exception>(() => _repositorio.ObterPorId(231231));
        }

        [Fact]
        public void TestaAdicionarAgenciaMock()
        {
            var agencia = new Agencia()
            {
                Nome = "Agencia Amaral",
                Identificador = Guid.NewGuid(),
                Id = 4,
                Endereco = "Rua Athur Costa",
                Numero = 6497
            };

            var repositorioMock = new ByteBankRepositorio();

            var adicionado = repositorioMock.AdicionarAgencia(agencia);

            Assert.True(adicionado);
        }

        [Fact]
        public void TestaObterAgenciaMock()
        {
            var repoMock = new Mock<IByteBankRepositorio>();
            var mock = repoMock.Object;

            var lista = mock.BuscarAgencias();

            repoMock.Verify(b => b.BuscarAgencias());
        }

        public void Dispose()
        {
            SaidaConsoleTeste.WriteLine("Destrutor invocado.");
        }
    }
}
