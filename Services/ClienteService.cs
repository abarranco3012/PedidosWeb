using PedidosWeb.Data;
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
    }
}
