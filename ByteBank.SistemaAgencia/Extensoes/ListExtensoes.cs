using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(21);
            idades.Add(35);

            idades.AdicionarVarios(53, 345, 123);

            //ListExtensoes<int>.AdicionarVarios(idades, 1, 2, 4);

            List<string> nomes = new List<string>();

            nomes.Add("Guilherme");
            nomes.Add("Mateus");

            nomes.AdicionarVarios("Marcos", "João");

        }
    }

    
}
