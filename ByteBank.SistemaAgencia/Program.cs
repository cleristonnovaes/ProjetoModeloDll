using System;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 876456);
            Funcionario funcionario = null;

            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
