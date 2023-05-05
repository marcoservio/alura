using Alura.ByteBank.Dominio.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.Infraestrutura.Teste.Servico
{
    public class ByteBankRepositorio : IByteBankRepositorio
    {
        private List<Cliente> clientes = new List<Cliente>()
        {
            new Cliente()
            {
                Nome = "Bruse Kent",
                CPF = "486.074.980-45",
                Identificador = Guid.NewGuid(),
                Profissao = "Empresario",
                Id = 1
            },
            new Cliente()
            {
                Nome = "Maria Kent",
                CPF = "486.074.980-45",
                Identificador = Guid.NewGuid(),
                Profissao = "Develo",
                Id = 2
            },
            new Cliente()
            {
                Nome = "Marco Kent",
                CPF = "486.074.980-45",
                Identificador = Guid.NewGuid(),
                Profissao = "Dev front",
                Id = 3
            },
        };

        private List<Agencia> agencias = new List<Agencia>()
        {
            new Agencia()
            {
                Nome = "teste",
                Identificador= Guid.NewGuid(),
                Numero = 1,
                Endereco = "rua testefgdfgsdgdfgdfg",
                Id= 1
            },
            new Agencia()
            {
                Nome = "teste2",
                Identificador= Guid.NewGuid(),
                Numero = 1,
                Endereco = "rua testefgdfgsdgdfgdfg2",
                Id= 2
            }
        };

        private List<ContaCorrente> contas = new List<ContaCorrente>()
        {
            new ContaCorrente()
            {
                Identificador = Guid.NewGuid(),
                Numero = 1231,
                Id = 1,
                Agencia = new Agencia()
                {
                    Nome = "teste",
                    Identificador= Guid.NewGuid(),
                    Numero = 1,
                    Endereco = "rua testefgdfgsdgdfgdfg",
                    Id= 1
                },
                Cliente = new Cliente()
                {
                    Nome = "Bruse Kent",
                    CPF = "486.074.980-45",
                    Identificador = Guid.NewGuid(),
                    Profissao = "Empresario",
                    Id = 1
                }
            }
        };

        public List<Agencia> BuscarAgencias()
        {
            return agencias;
        }

        public List<Cliente> BuscarClientes()
        {
            return clientes;
        }

        public List<ContaCorrente> BuscarContaCorrente()
        {
            return contas;
        }

        public bool AdicionarAgencia(Agencia agencia)
        {
            agencias.Add(agencia);

            return true;
        }
    }
}
