using Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mappings
{
    public class ProdutosMapping : EntityTypeConfiguration<Produto>
    {
        public ProdutosMapping()
        {
            ToTable("Produtos");
            HasKey(p => p.Id);

            Property(p => p.Nome);
            Property(p => p.Descricao);

            HasRequired(p => p.Fornecedor).WithMany(f => f.Produtos).HasForeignKey(p => p.FornecedorId);



        }
    }
}
