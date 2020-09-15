using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidosWeb.Models;
using PedidosWeb.Models.ViewModels;
using PedidosWeb.Services;

namespace PedidosWeb.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly ProdutoService _produtoService;
        private readonly TipoService _tipoService;

        public ProdutoController(ProdutoService produtoService, TipoService tipoService)
        {
            _produtoService = produtoService;
            _tipoService = tipoService;
        }
        public IActionResult Index()
        {
            var list = _produtoService.FindAll();
            return View(list);
        }

        public IActionResult Novo()
        {
            var tipos = _tipoService.FindAll();
            var viewModel = new ProdutoFormViewModel { Tipos = tipos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Novo(Produto produto)
        {
            _produtoService.Insert(produto);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _produtoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(int id)
        {
            _produtoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _produtoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
    }
}
