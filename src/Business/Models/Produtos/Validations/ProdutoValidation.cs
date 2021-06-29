using Business.Models.Produtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Fornecedores.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Nome)
               .Length(2, 100).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
               .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");

            RuleFor(p => p.Descricao)
                   .Length(2, 100).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
                   .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");

            RuleFor(p => p.Preco)
               .GreaterThan(1).WithMessage("O campo {PropertyName} precisa ser maior que {PropertyValue}")
               .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido");
        }
    }
}
