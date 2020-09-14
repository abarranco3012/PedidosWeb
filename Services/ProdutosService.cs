using PedidosWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Services
{
    public class ProdutosService
    {
        private readonly PedidosWebContext _context;

        public ProdutosService(PedidosWebContext context)
        {
            _context = context;
        }
    }
}
