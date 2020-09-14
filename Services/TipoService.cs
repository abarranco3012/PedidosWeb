using PedidosWeb.Data;
using PedidosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Services
{
    public class TipoService
    {
        private readonly PedidosWebContext _context;

        public TipoService(PedidosWebContext context)
        {
            _context = context;
        }

        public List<Tipo> FindAll()
        {
            return _context.Tipo.OrderBy(x => x.Nome).ToList();
        }

        public void Insert(Tipo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Tipo FindById(int id)
        {
            return _context.Tipo.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Tipo.Find(id);
            _context.Tipo.Remove(obj);
            _context.SaveChanges();
        }

        // no Service de Produtos, colocar no Insert, antes de tudo:
        // obj.Tipos = _context.Tipos.First();
    }
}
