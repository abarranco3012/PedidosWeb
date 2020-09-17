using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using PedidosWeb.Models;
using PedidosWeb.Models.ViewModels;
using PedidosWeb.Services;
using PedidosWeb.Services.Exceptions;

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
                return RedirectToAction(nameof(Error),new { message = "Id não informado"});
            }

            var obj = _produtoService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" }); 
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
                return RedirectToAction(nameof(Error), new { message = "Id não informado" });
            }

            var obj = _produtoService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não informado" });
            }

            var obj = _produtoService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            List<Tipo> tipos = _tipoService.FindAll();
            ProdutoFormViewModel viewModel = new ProdutoFormViewModel { Produto = obj, Tipos = tipos };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Ids diferentes " });
            }

            try
            {
                _produtoService.Editar(produto);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {
                return RedirectToAction(nameof(Error), new { e.Message });
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { e.Message });
            }
            // ou ao invés das duas exceções, pode usar ApplicationException:
            //catch (ApplicationException e)
            //{
            //    return RedirectToAction(nameof(Error), new { e.Message });
            //}
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);

        }
    }
}
