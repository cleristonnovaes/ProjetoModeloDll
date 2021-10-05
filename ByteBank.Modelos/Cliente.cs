using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo minha lógica de validação de CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

        //sobescrevendo o método Equal que recebe com argumento um object

        public override bool Equals(object obj)
        {
           //Cliente outroCliente = (Cliente) obj;
            Cliente outroCliente = obj as Cliente;


            if(outroCliente == null)
            {
                return false;
            }

            return CPF == outroCliente.CPF;
        }
    }

}
