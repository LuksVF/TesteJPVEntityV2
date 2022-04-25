using Microsoft.EntityFrameworkCore;
using TesteJPVEntityV2.Models;

namespace TesteJPVEntityV2.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
