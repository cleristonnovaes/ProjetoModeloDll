﻿// using _05_ByteBank;
using System;


namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank.
    /// </summary>

    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }


        public int Agencia { get; }

        public int Numero { get; }


        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        /// <summary>
        /// Cria uma instância de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que zero.</param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que zero.</param>
        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;

            
        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// <exception cref="ArgumentException">Execção lançada quando o valor de <paramref name="valor"/>é maior que o valor da propriedade <see cref="Saldo"/>.</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>. </exception>
        /// </summary>
        /// 
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que <see cref="Saldo"/>. </param>
        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
    
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            
            contaDestino.Depositar(valor);
          
        }

        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if (outraConta == null)
            {
                return false;
            }

            return Numero == outraConta.Numero && Agencia == outraConta.Agencia;
        }
    }
}
