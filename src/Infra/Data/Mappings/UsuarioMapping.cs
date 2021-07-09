using Business.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mappings
{
   public class UsuarioMapping:EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            Property(u=>u.Username)
                .IsRequired()                ;

            Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(8);
                
        }
    }
}
