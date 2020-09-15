using Microsoft.EntityFrameworkCore;
using PedidosWeb.Data;
using PedidosWeb.Models;
using PedidosWeb.Services.Exceptions;
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

        public void Editar(Tipo obj)
        {
            if (!_context.Tipo.Any(x => x.Id == obj.Id))
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
