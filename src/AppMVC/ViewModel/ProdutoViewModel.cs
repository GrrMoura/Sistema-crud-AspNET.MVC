using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace AppMVC.ViewModel
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "o Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descricação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "o Campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Descricao { get; set; }


        public string Imagem { get; set; }

        [DisplayName("Imagem do Produto")]
        public HttpPostedFileBase ImagemUpload { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Preco { get; set; }

        [DisplayName("Fornecedor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid FornecedorId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }


        public FornecedorViewModel Fornecedor  { get; set; }

        public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }


    }
}