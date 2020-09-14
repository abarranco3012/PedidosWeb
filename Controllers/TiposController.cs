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
    public class TiposController : Controller
    {
        private readonly TiposService _tiposService;

        public TiposController(TiposService tiposService)
        {
            _tiposService = tiposService;
        }

        public IActionResult Index()
        {
            //List<Tipos> list = new List<Tipos>();
            var list = _tiposService.FindAll();
            return View(list);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Novo(Tipos tipos)
        {
            _tiposService.Insert(tipos);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _tiposService.FindById(id.Value);
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
            _tiposService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
