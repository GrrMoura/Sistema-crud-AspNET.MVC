using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppMVC.Models;
using AppMVC.ViewModel;
using Business.Models.Fornecedores.Services;
using Business.Models.Fornecedores.Repositories;
using AutoMapper;
using System.Web.Services.Description;
using Business.Models.Fornecedores;

namespace AppMVC.Controllers
{
    public class FornecedorController : Controller
    {
        protected readonly IFornecedorService _fornecedorService;
        protected readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public FornecedorController(IFornecedorRepository fornecedorRepository,
                                    IFornecedorService fornecedorService,
                                     IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _fornecedorService = fornecedorService;
            _mapper = mapper;
        }

        [Route("listar-todos")]
        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos()));
        }


        [Route("dados-dos-produtos/{id:guid}")]
        [HttpPost]
        public async Task<ActionResult> Details(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedor(id);

            if (fornecedorViewModel == null)
            {
                return HttpNotFound();
            }
            return View(fornecedorViewModel);
        }

        [Route("novo-usuario")]
        [HttpGet]
        [Authorize(Roles = "funcionario")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("novo-usuario")]
        [HttpPost]
        [Authorize(Roles = "funcionario")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(FornecedorViewModel fornecedorViewModel)
        {

            if (ModelState.IsValid)
            {

                await _fornecedorService.Adicionar(_mapper.Map<Fornecedor>(fornecedorViewModel));
                return RedirectToAction("Index");
            }

            return View(fornecedorViewModel);

        }

        [Route("editar-funcionario/{id:guid}")]
        [HttpGet]
        [Authorize(Roles = "funcionario")]
        public async Task<ActionResult> Edit(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedor(id);

            if (fornecedorViewModel == null)
            {
                return HttpNotFound();
            }
            return View(fornecedorViewModel);
        }

        [Route("editar-funcionario/{id:guid}")]
        [HttpPost]
        [Authorize(Roles = "funcionario")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(FornecedorViewModel fornecedorViewModel)
        {

            if (ModelState.IsValid)
            {
                await _fornecedorService.Atualizar(_mapper.Map<Fornecedor>(fornecedorViewModel)));
                return RedirectToAction("Index");
            }
            return View(fornecedorViewModel);
        }

        [Route("deletar-fornecedor/{id:guid}")]
        [HttpGet]
        [Authorize(Roles = "gerente")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedor(id);

            if (fornecedorViewModel == null)
            {
                return HttpNotFound();
            }
            return View(fornecedorViewModel);
        }

        [Route("deletar-fornecedor/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedor(id);

            if (fornecedorViewModel == null)
            {
                return HttpNotFound();
            }

            return RedirectToAction("Index");
        }

        private async Task<FornecedorViewModel> ObterFornecedor(Guid id)
        {
            var fornecedor = _mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterFornecedorProdutoEndereco(id));

            return fornecedor;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _fornecedorRepository?.Dispose();
                _fornecedorService?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
