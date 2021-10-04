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
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));
            Console.WriteLine(urlTeste.Contains("bytebank"));

            //Console.WriteLine(indiceByteBank == 0);
            Console.ReadLine();



            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorDeArgumentoURL extratorDeValores = new ExtratorValorDeArgumentoURL(urlParametros);

            string valorOrigem = extratorDeValores.GetValor("moedaOrigem");
            string valorDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaOrigem: " + valorOrigem + " e Valor de moedaDestino: " + valorDestino);
            Console.ReadLine();


            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);

            Console.WriteLine(indice);

            int indiceValor = indice + nomeArgumento.Length;
            

            string valorArgumento = palavra.Substring(indiceValor);
            Console.WriteLine(valorArgumento);

            Console.ReadLine();
        }
       
    }
}
