using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Entidades;
using Alura.ByteBank.Dominio.Interfaces.Repositorios;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Alura.ByteBank.Infraestrutura.Teste
{
    public class ClienteRepositorioTestes
    {
        private readonly IClienteRepositorio _repositorio;

        public ClienteRepositorioTestes()
        {
            var servico = new ServiceCollection();
            servico.AddTransient<IClienteRepositorio, ClienteRepositorio>();
            var provedor = servico.BuildServiceProvider();
            _repositorio = provedor.GetService<IClienteRepositorio>();
        }

        [Fact]
        public void TestaObterTodosClientes()
        {
            List<Cliente> lista = _repositorio.ObterTodos();

            Assert.NotNull(lista);
            //Assert.Equal(4, lista.Count);
            Assert.True(lista.Any());
        }

        [Fact]
        public void TestaObterClientePorId()
        {
            var cliente = _repositorio.ObterPorId(1);

            Assert.NotNull(cliente);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void TestaObterClientePorVariosIds(int id)
        {
            var cliente = _repositorio.ObterPorId(id);

            Assert.NotNull(cliente);
        }

        [Fact]
        public void TestaAtualizaCpfDeterminadaCliente()
        {
            var cliente = _repositorio.ObterPorId(1);
            string novoCpf = "106.064.356-11";
            cliente.CPF = novoCpf;

            var atualizado = _repositorio.Atualizar(1, cliente);

            Assert.True(atualizado);
        }

        [Fact]
        public void TestaInsereUmaNovaContaCorrenteNoBancoDeDados()
        {
            var cliente = new Cliente()
            {
                Nome = "Marco Sérvio",
                CPF = "106.064.356-11",
                Identificador = Guid.NewGuid(),
                Profissao = "Bancário"
            };

            var retorno = _repositorio.Adicionar(cliente);

            Assert.True(retorno);
        }
    }
}
