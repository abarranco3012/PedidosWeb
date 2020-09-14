using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PedidosWeb.Models;


namespace PedidosWeb.Data
{
    public class PedidosWebContext: IdentityDbContext
    {
        public PedidosWebContext(DbContextOptions<PedidosWebContext> options) : base(options)
        {
        }

        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Filho> Filho { get; set; }
    }
}
