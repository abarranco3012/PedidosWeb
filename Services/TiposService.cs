using PedidosWeb.Data;
using PedidosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Services
{
    public class TiposService
    {
        private readonly PedidosWebContext _context;

        public TiposService(PedidosWebContext context)
        {
            _context = context;
        }

        public List<Tipos> FindAll()
        {
            return _context.Tipos.ToList();
        }

        public void Insert(Tipos obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Tipos FindById(int id)
        {
            return _context.Tipos.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Tipos.Find(id);
            _context.Tipos.Remove(obj);
            _context.SaveChanges();
        }

        // no Service de Produtos, colocar no Insert, antes de tudo:
        // obj.Tipos = _context.Tipos.First();
    }
}
