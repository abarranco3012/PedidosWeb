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

        public DbSet<Tipos> Tipos { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
    }
}
