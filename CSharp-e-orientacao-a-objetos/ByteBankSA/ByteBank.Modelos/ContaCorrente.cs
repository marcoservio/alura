using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank.
    /// </summary>
    public class ContaCorrente : IComparable
    {
        /// <summary>
        /// 
        /// </summary>
        public int ContadorSaquesNaoPermitidos { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public int ContadorTranferenciaNaoPermitidas { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public static double TaxaOperacao { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Cliente Titular { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static int TotalDeContasCriadas { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public int Agencia { get; }
        /// <summary>
        /// 
        /// </summary>
        public int Numero { get; }

        private double _saldo = 100;
        /// <summary>
        /// 
        /// </summary>
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        /// <summary>
        /// Cria uma instacia de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="numeroAgencia"> Representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que 0 </param>
        /// <param name="numeroConta"> Representa o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que 0 </param>
        /// <exception cref="ArgumentException"></exception>
        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if(numeroAgencia <= 0)
            {
                throw new ArgumentException("O argumento agencia dever ser maior que 0.", nameof(numeroAgencia));
            }
            if(numeroConta <= 0)
            {
                throw new ArgumentException("O argumento numero dever ser maior que 0.", nameof(numeroConta));
            }

            Agencia = numeroAgencia;
            Numero = numeroConta;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContaCorrente()
        {

        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>.
        /// </summary>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que o <see cref="Saldo"/> </param>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é ultilizado no argumento <paramref name="valor"/> </exception>
        /// <exception cref="SaldoInsuficienteException"> Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/> </exception>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para o saque.", nameof(valor));
            }

            if(_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="contaDestino"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="OperacaoFinanceiraException"></exception>
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor invalido para a tranferencia.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTranferenciaNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Número {Numero}, Agência {Agencia}, Saldo {Saldo}";
            //return "Número: " + Numero + ", Agência: " + Agencia + ", Saldo: " + Saldo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return false;
            }

            if(Numero == outraConta.Numero && Agencia == outraConta.Agencia)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            // Retornar negativo quando a instância precede o obj;
            // Retornar zero quando nossa instância e obj forem equivalentes;
            // Retornar positivo diferente de zero quando a precedencia for de obj;

            var outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return -1;
            }

            if(Numero < outraConta.Numero)
            {
                return -1;
            }

            if(Numero == outraConta.Numero)
            {
                return 0;
            }

            return 1;
        }
    }
}