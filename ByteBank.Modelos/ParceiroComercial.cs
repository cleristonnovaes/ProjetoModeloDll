using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _auteticacaoHelper = new AutenticacaoHelper();
          public string Senha { get; set; }

          public bool Autenticar(string senha)
        {
            return _auteticacaoHelper.CompararSenhas(Senha, senha);
        }


    }
}
