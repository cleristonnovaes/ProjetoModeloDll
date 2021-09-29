using System;
using ByteBank.Modelos;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 876456);
            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
