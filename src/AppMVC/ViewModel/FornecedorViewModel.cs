using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMVC.ViewModel
{
    public class FornecedorViewModel
    {
        public FornecedorViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "o Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(13, ErrorMessage = "o Campo {0} precisa ter entre {2} e {1}", MinimumLength = 11)]
        public string Documento { get; set; }

        [DisplayName("Ativo?")]
        [Required]
        public bool Ativo { get; set; }

        [DisplayName("Pessoa Fisica ou Juridica")]
        [Required]
        public string TipoFornecedor { get; set; }


        public EnderecoViewModel Endereco { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}