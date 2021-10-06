using Microsoft.EntityFrameworkCore;
using Sator.App.Dominio.Entidades;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class AppContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =SatorBD");
            }
        }    
    }
}
