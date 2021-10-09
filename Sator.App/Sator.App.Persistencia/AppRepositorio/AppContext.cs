using Microsoft.EntityFrameworkCore;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class AppContext : DbContext
    {
      public DbSet<Producto> Productos { get; set; }
      public DbSet<Persona> Personas { get; set; }
      public DbSet<Genero> Generos { get; set; }

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
