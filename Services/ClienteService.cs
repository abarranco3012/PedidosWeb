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
    public class ClienteService
    {
        private readonly PedidosWebContext _context;

        public ClienteService(PedidosWebContext context)
        {
            _context = context;
        }

        public List<Cliente> FindAll()
        {
            return _context.Cliente.OrderBy(x => x.Nome).ToList();
        }

        public void Insert(Cliente obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Cliente FindById(int id)
        {
            return _context.Cliente.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Cliente.Find(id);
            _context.Cliente.Remove(obj);
            _context.SaveChanges();
        }

        public void Editar(Cliente obj)
        {
            if (!_context.Cliente.Any(x => x.Id == obj.Id))
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
