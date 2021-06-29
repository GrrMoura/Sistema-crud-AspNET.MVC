using Business.Models.Fornecedores;
using Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Infra.Data.Mappings;

namespace Infra.Data.DbApplications
{
    public class DbApplication : DbContext
    {
        public DbApplication() : base(nameOrConnectionString: "DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>()
                .Configure(f=>f.HasColumnType("varchar")
                               .HasMaxLength(100)
                               .IsRequired());

            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new FornecedorMapping());
            modelBuilder.Configurations.Add(new EnderecoMapping());
            modelBuilder.Configurations.Add(new ProdutosMapping());
        }
    }

}
