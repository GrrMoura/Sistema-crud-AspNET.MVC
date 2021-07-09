using Business.Core.Notificador;
using Business.Core.Services;
using Business.Models.Fornecedores.Repositories;
using Business.Models.Fornecedores.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Fornecedores.Services
{
    public class FornecedorService : BaseServices, IFornecedorService
    {
        protected readonly IFornecedorRepository _fornecedorRespository;
        protected readonly IEnderecoRepository _enderecoRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository,
                                 IEnderecoRepository enderecoRepository,
                                 INotificador notificador) : base(notificador)
        {
            _fornecedorRespository = fornecedorRepository;
            _enderecoRepository = enderecoRepository;

        }

        public async Task Adicionar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor) ||
                !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;


            if (await FornecedorExistente(fornecedor)) return;

            await _fornecedorRespository.Adicionar(fornecedor);

        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;

            if (await FornecedorExistente(fornecedor)) return;

            await _fornecedorRespository.Atualizar(fornecedor);
        }

        public async Task Remover(Guid id)
        {
            var fornecedor = await _fornecedorRespository.ObterFornecedorProdutoEndereco(id);

            if (fornecedor.Produtos.Any())
            {
                Notificar("O fornecedor possui produtos");
            }

            if (fornecedor.Endereco != null)
            {

                await _enderecoRepository.Remover(id);
            }

            await _fornecedorRespository.Remover(id);

        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;


            await _enderecoRepository.Atualizar(endereco);

        }

        private async Task<bool> FornecedorExistente(Fornecedor fornecedor)
        {
            var fornecedorAtual = await _fornecedorRespository
                .Buscar(f => f.Documento == fornecedor.Documento &&
                 f.Id != fornecedor.Id
                );

            if (fornecedorAtual.Any())
            {
                Notificar("já possui fornecedor com esses dados ");
                return true;
            }

            return false;

        }

        public void Dispose()
        {
            _enderecoRepository?.Dispose();
            _fornecedorRespository?.Dispose();
        }
    }
}
