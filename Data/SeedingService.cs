using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosWeb.Data
{
    public class SeedingService
    {
        private PedidosWebContext _context;

        public SeedingService(PedidosWebContext context)
        {
            _context = context;
        }

    }
}
