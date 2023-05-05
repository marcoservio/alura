using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Entidades;
using Alura.ByteBank.Dominio.Interfaces.Repositorios;
using Alura.ByteBank.Infraestrutura.Teste.Servico;
using Alura.ByteBank.Infraestrutura.Teste.Servico.DTO;

using Microsoft.Extensions.DependencyInjection;

using Moq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Alura.ByteBank.Infraestrutura.Teste
{
    public class ContaCorrenteRepositorioTestes
    {
        private readonly IContaCorrenteRepositorio _repositorio;

        public ContaCorrenteRepositorioTestes()
        {
            var servico = new ServiceCollection();
            servico.AddTransient<IContaCorrenteRepositorio, ContaCorrenteRepositorio>();
            var provedor = servico.BuildServiceProvider();
            _repositorio = provedor.GetService<IContaCorrenteRepositorio>();
        }

        [Fact]
        public void TestaObterTodasContas()
        {
            List<ContaCorrente> lista = _repositorio.ObterTodos();

            Assert.NotNull(lista);
        }

        [Fact]
        public void TestaObterContaPorId()
        {
            var conta = _repositorio.ObterPorId(1);

            Assert.NotNull(conta);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void TestaObterContaPorVariosIds(int id)
        {
            var conta = _repositorio.ObterPorId(id);

            Assert.NotNull(conta);
        }

        [Fact]
        public void TestaAtualizaSaldoDeterminadaConta()
        {
            var conta = _repositorio.ObterPorId(1);
            double novoSaldo = 15;
            conta.Saldo = novoSaldo;

            var atualizado = _repositorio.Atualizar(1, conta);

            Assert.True(atualizado);
        }

        [Fact]
        public void TestaInsereUmaNovaContaCorrenteNoBancoDeDados()
        {
            var conta = new ContaCorrente()
            {
                Saldo = 10,
                Identificador = Guid.NewGuid(),
                Numero = 23713,
                Cliente = new Cliente()
                {
                    Nome = "Marco Sérvio",
                    CPF = "106.064.356-11",
                    Identificador = Guid.NewGuid(),
                    Profissao = "Bancário",
                    Id = 1
                },
                Agencia = new Agencia()
                {
                    Nome = "Agencia Central Coast City",
                    Identificador = Guid.NewGuid(),
                    Id = 1,
                    Endereco = "Rua das Flores",
                    Numero = 147
                }
            };

            var retorno = _repositorio.Adicionar(conta);

            Assert.True(retorno);
        }

        [Fact]
        public void TestaConsultaPix()
        {
            var guild = new Guid("30cc061c-a2c5-4c50-9200-9501dea5cd25");
            var pix = new PixDTO() { Chave = guild, Saldo = 10 };

            var pixRepo = new Mock<IPixRepositorio>();
            pixRepo.Setup(x => x.ConsultaPix(It.IsAny<Guid>())).Returns(pix);

            var mock = pixRepo.Object;

            var saldo = mock.ConsultaPix(guild).Saldo;

            Assert.Equal(10, saldo);
        }
    }
}
