using PC3_PrograTeoria.Models;
using Microsoft.EntityFrameworkCore;

namespace PC3_PrograTeoria.Data
{
    public class BuscoContext : DbContext
    {
         public DbSet<Producto> Productos { get; set; }

        public BuscoContext(DbContextOptions dco) : base(dco) {

        }
    }
}