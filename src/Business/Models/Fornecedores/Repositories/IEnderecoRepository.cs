using Business.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Fornecedores.Repositories
{
    public interface IEnderecoRepository:IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorfornecedor(Guid fornecedorId);
    }
}
