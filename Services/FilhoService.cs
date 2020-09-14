using PedidosWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Services
{
    public class FilhoService
    {
        private readonly PedidosWebContext _context;

        public FilhoService(PedidosWebContext context)
        {
            _context = context;
        }
    }
}
