using PedidosWeb.Data;
using PedidosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PedidosWeb.Services.Exceptions;

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
            // esse include faz o "join" das tabelas
            return _context.Produto.Include(obj => obj.Tipo).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Produto.Find(id);
            _context.Produto.Remove(obj);
            _context.SaveChanges();
        }

        public void Editar(Produto obj)
        {
            if (!_context.Produto.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id não encontrado !");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
