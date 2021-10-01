using System;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);

            Console.WriteLine(indice);

            int indiceValor = indice + nomeArgumento.Length;
            

            string valorArgumento = palavra.Substring(indiceValor + 1);
            Console.WriteLine(valorArgumento);

            Console.ReadLine();
        }
       
    }
}
