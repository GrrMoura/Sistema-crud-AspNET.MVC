using Business.Models.Fornecedores;
using Business.Models.Fornecedores.Repositories;
using Infra.Data.DbApplications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DbApplication context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorfornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId);
        }
    }
}
