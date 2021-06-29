using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Fornecedores.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(e => e.Logradouro)
                .Length(2, 100).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
                .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");

            RuleFor(e => e.Numero)
               .Length(2, 10).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
               .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");

            RuleFor(e => e.Complemento)
               .Length(2, 100).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
               .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");

            RuleFor(e => e.Bairro)
               .Length(2, 100).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
               .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");

            RuleFor(e => e.Cidade)
               .Length(2, 100).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
               .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");

            RuleFor(e => e.Cep)
               .Length(2, 8).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
               .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");

            RuleFor(e => e.Estado)
               .Length(2, 30).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
               .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");

        }
    }
}
