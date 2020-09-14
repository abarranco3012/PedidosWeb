using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidosWeb.Data;
using PedidosWeb.Models;
using PedidosWeb.Services;

namespace PedidosWeb.Controllers
{
    public class TipoController : Controller
    {
        private readonly TipoService _tipoService;

        public TipoController(TipoService tipoService)
        {
            _tipoService = tipoService;
        }

        public IActionResult Index()
        {
            //List<Tipos> list = new List<Tipos>();
            var list = _tipoService.FindAll();
            return View(list);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Novo(Tipo tipo)
        {
            _tipoService.Insert(tipo);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _tipoService.FindById(id.Value);
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
            _tipoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
