using DevIO.Business.Core.Validations.Documentos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Fornecedores.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("o campo {PropertyName} precisa ser preenchido")
                .Length(2, 100).WithMessage("o campo {PropertyName} precisa ter entre {MinLength} e {MaxLenght}");

            When(f=>f.TipoFornecedor==TipoFornecedor.PessoaFisica,()=>
            {
                RuleFor(f=>f.Documento.Length).Equal(CpfValidacao.TamanhoCpf).WithMessage("o campo {PropertyName} precisa ter 11 digitos");

                RuleFor(f=>CpfValidacao.Validar(f.Documento)).Equal(true).WithMessage("Documento inválidos");
            
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj).WithMessage("o campo {PropertyName} precisa ter 13 digitos");

                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true).WithMessage("Documento inválidos");

            });
        }
    }
}
