using PedidosWeb.Data;
using PedidosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Services
{
    public class ProdutoService
    {
        private readonly PedidosWebContext _context;

        public ProdutoService(PedidosWebContext context)
        {
            _context = context;
        }

        public List<Produto> FindAll()
        {
            return _context.Produto.OrderBy(x => x.Nome).ToList();
        }

        public void Insert(Produto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Produto FindById(int id)
        {
            return _context.Produto.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Produto.Find(id);
            _context.Produto.Remove(obj);
            _context.SaveChanges();
        }
    }
}
