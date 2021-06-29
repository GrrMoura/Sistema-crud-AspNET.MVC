using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.Notificador
{
   public class Notificacoes
    {

        public Notificacoes(string mensagem)
        {

            Mensagem = mensagem;
        }
        public string Mensagem { get; set; }
    }
}
