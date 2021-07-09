using Business.Models.Usuarios;
using Infra.Data.DbApplications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(DbApplication contexto) : base(contexto) { }



        public static Usuario Get(string username, string password)
        {
            var users = new List<Usuario>();
            users.Add(new Usuario { Id = Guid.NewGuid(), Username = "patrao", Password = "patrao", Role = "gerente" });
            users.Add(new Usuario { Id = Guid.NewGuid(), Username = "empregado", Password = "empregado", Role = "funcionario" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }


    }


}
