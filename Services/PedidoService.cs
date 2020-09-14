using PedidosWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Services
{
    public class PedidoService
    {
        private readonly PedidosWebContext _context;

        public PedidoService(PedidosWebContext context)
        {
            _context = context;
        }
    }
}
