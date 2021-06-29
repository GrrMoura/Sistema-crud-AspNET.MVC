using Business.Models.Fornecedores;
using System.Data.Entity;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Infra.Data.Mappings
{
    public class FornecedorMapping : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMapping()
        {
            ToTable("Fornecedores");

            HasKey(f => f.Id);

            Property(f => f.Nome);

            Property(f => f.Documento).HasColumnAnnotation("Id_Documento", new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            HasRequired(f => f.Endereco).WithRequiredPrincipal(e => e.Fornecedor);

        }
    }
}
