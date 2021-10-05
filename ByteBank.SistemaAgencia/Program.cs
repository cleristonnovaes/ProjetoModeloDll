using System;
using System.Text.RegularExpressions;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";


            ContaCorrente conta = new ContaCorrente(456, 789456);

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }
            Console.ReadLine();

        }
        static void TestaString()
        {
            ///Expressões regulares
            ///
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 94784-4546";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();


            // Funções Inicia com, Fim com e Contem
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
