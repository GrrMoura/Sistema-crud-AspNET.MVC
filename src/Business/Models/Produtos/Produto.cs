using Business.Core.Model;
using Business.Models.Fornecedores;
using System;

namespace Business.Models.Produtos
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        public decimal Preco { get; set; }
        
        public Guid FornecedorId { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}
