using Alura.ByteBank.Dominio.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.Infraestrutura.Teste.Servico
{
    public interface IByteBankRepositorio
    {
        List<Cliente> BuscarClientes();
        List<Agencia> BuscarAgencias();
        List<ContaCorrente> BuscarContaCorrente();
    }
}
