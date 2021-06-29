using Business.Models.Produtos;
using Business.Models.Produtos.Repositories;
using Infra.Data.DbApplications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository

    {

        public ProdutoRepository(DbApplication context):base(context){}

        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await _dbSet
                .AsNoTracking()
                .Include(f => f.Fornecedor)
                .OrderBy(f => f.Nome)
                .ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}
