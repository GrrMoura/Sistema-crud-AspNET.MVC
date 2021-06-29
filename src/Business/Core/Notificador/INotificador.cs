using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Core.Notificador
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacoes> ObterNotificacoes();
        void Handle(Notificacoes notificacoes );
    }
}
