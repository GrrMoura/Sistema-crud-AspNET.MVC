using Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mappings
{
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMapping()
        {
            ToTable("Enderecos");

            HasKey(e => e.Id);

            Property(e => e.Logradouro);
            Property(e => e.Numero).HasMaxLength(10);
            Property(e => e.Complemento);
            Property(e => e.Bairro);
            Property(e => e.Cidade);
            Property(e => e.Cep).HasMaxLength(8);
            Property(e => e.Estado).HasMaxLength(30);
        }
    }
}
