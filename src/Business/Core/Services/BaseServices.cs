using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Core.Model;
using Business.Core.Notificador;
using FluentValidation;
using FluentValidation.Results;

namespace Business.Core.Services
{
    public class BaseServices
    {
        protected readonly INotificador _notificador;

        public BaseServices(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacoes(mensagem));
        }

        public void Notificar(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                Notificar(erro.ErrorMessage);
            }
        }

        public bool ExecutarValidacao<TV, TE>(TV valiacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validador = valiacao.Validate(entidade);

            if (!validador.IsValid)
            {
                Notificar(validador);
            }

            return true;
        }
    }
}
