using bytebank.Modelos.Conta;

using bytebank_ATENDIMENTO.bytebank.Exceptions;

namespace bytebank_ATENDIMENTO.bytebank.Atendimento
{
#nullable disable
    public class ByteBankAtendimento
    {
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
        {
            new ContaCorrente(95, "123456-X"){ Saldo = 100, Titular = new Cliente { Cpf = "11111", Nome = "Henrique", Profissao = "Dev" } },
            new ContaCorrente(95, "951258-X"){ Saldo = 200, Titular = new Cliente { Cpf = "22222", Nome = "Pedro", Profissao = "Dev" } },
            new ContaCorrente(91, "987321-W"){ Saldo = 60, Titular = new Cliente { Cpf = "33333", Nome = "Marisa", Profissao = "Dev" } }
        };

        public void AtendimentoCliente()
        {
            try
            {
                char opcao = '0';
                while(opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("===       Atendimento       ===");
                    Console.WriteLine("===   1 - Cadastrar Conta   ===");
                    Console.WriteLine("===   2 - Listar Contas     ===");
                    Console.WriteLine("===   3 - Remover Conta     ===");
                    Console.WriteLine("===   4 - Ordenar Contas    ===");
                    Console.WriteLine("===   5 - Pesquisar Conta   ===");
                    Console.WriteLine("===   6 - Sair do Sistema   ===");
                    Console.WriteLine("===============================");
                    Console.Write("Digite a opção desejada: ");

                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch(Exception ex)
                    {
                        throw new ByteBankException(ex.Message);
                    }

                    switch(opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarContas();
                            break;
                        case '3':
                            RemoverContas();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarContas();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opção não implementada");
                            break;
                    }
                }
            }
            catch(ByteBankException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("... Encerrando a aplicação ...");
            Console.ReadKey();
        }

        private void PesquisarContas()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===    Pesquisar Contas     ===");
            Console.WriteLine("===============================");
            Console.WriteLine();

            Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA, (2) CPF TITULAR ou (3) NUMERO AGENCIA? ");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine();
                    Console.Write("Informe o numero da Conta: ");
                    string _numeroConta = Console.ReadLine();
                    ContaCorrente consultaConta = ConsultaPorNumero(_numeroConta);
                    Console.WriteLine(consultaConta.ToString());
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.Write("Informe o CPF do Titular: ");
                    string _cpf = Console.ReadLine();
                    ContaCorrente consultaCpf = ConsultaPorCpfTitular(_cpf);
                    Console.WriteLine(consultaCpf.ToString());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.Write("Informe o numero da Agencia: ");
                    int _numeroAgencia = int.Parse(Console.ReadLine());
                    var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                    ExibirListaContas(contasPorAgencia);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Opção não implementada");
                    break;
            }
        }

        private void ExibirListaContas(List<ContaCorrente> contasPorAgencia)
        {
            if(contasPorAgencia.Count == 0)
            {
                Console.WriteLine("... Consulta não retornou dados ...");
                return;
            }

            foreach(var item in contasPorAgencia)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            var consulta = (
                from conta in _listaDeContas
                where conta.Numero_agencia == numeroAgencia
                select conta).ToList();

            return consulta;
        }

        private ContaCorrente ConsultaPorCpfTitular(string? cpf)
        {
            //ContaCorrente conta = null;

            //foreach(var item in _listaDeContas)
            //{
            //    if(item.Titular.Cpf.Equals(cpf))
            //        conta = item;
            //}

            //return conta;

            return _listaDeContas.Where(conta => conta.Titular.Cpf.Equals(cpf)).FirstOrDefault();
        }

        private ContaCorrente ConsultaPorNumero(string? numeroConta)
        {
            //ContaCorrente conta = null;

            //foreach(var item in _listaDeContas)
            //{
            //    if(item.Conta.Equals(numeroConta))
            //        conta = item;
            //}

            //return conta;

            return _listaDeContas.Where(conta => conta.Conta.Equals(numeroConta)).FirstOrDefault();
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort();
            Console.WriteLine("... Lista de contas ordenada ...");
            Console.ReadKey();
        }

        private void RemoverContas()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===     Remover Contas      ===");
            Console.WriteLine("===============================");
            Console.WriteLine();

            Console.Write("Informe o número da Conta: ");
            string numeroConta = Console.ReadLine();

            ContaCorrente conta = null;

            foreach(var item in _listaDeContas)
            {
                if(item.Conta.Equals(numeroConta))
                    conta = item;
            }

            if(conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.WriteLine("... Conta removida da lista! ...");
            }
            else
                Console.WriteLine("... Conta para remoção não econtrada ...");

            Console.ReadKey();
        }

        private void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===     Lista de Contas     ===");
            Console.WriteLine("===============================");
            Console.WriteLine();

            if(_listaDeContas.Count <= 0)
            {
                Console.WriteLine("... Não ha contas cadastradas ...");
                Console.ReadKey();
                return;
            }

            foreach(ContaCorrente item in _listaDeContas)
            {
                //Console.WriteLine("===     Dados da conta      ===");
                //Console.WriteLine($"Numero da conta: {item.Conta}");
                //Console.WriteLine($"Numero da conta: {item.Saldo}");
                //Console.WriteLine($"Titular da conta: {item.Titular.Nome}");
                //Console.WriteLine($"CPF do titular: {item.Titular.Cpf}");
                //Console.WriteLine($"Profissão do titular: {item.Titular.Profissao}");
                Console.WriteLine(item.ToString());
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.ReadKey();
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===   Cadastro de Contas    ===");
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.WriteLine("=== Informe dados da conta  ===");

            Console.Write("Numero da agencia: ");
            int numeroAgencia = int.Parse(Console.ReadLine());
            ContaCorrente conta = new ContaCorrente(numeroAgencia);
            Console.WriteLine($"Numero da conta [NOVA] : {conta.Conta}");

            Console.Write("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.Write("Informe o nome do Titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.Write("Informe o CPF do Titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.Write("Informe a profissão do Titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);

            Console.WriteLine("... Conta cadastrada com sucesso! ...");
            Console.ReadKey();
        }
    }
}
