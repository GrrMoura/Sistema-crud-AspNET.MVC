using Business.Core.Notificador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.Services
{
    public class Notificador : INotificador
    {
        List<Notificacoes> _notificacoes;
        public Notificador()
        {
            _notificacoes  = new List<Notificacoes>() ;
        }
                
        public void Handle(Notificacoes notificacoes)
        {
            _notificacoes .Add(notificacoes);
        }

        public List<Notificacoes> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
