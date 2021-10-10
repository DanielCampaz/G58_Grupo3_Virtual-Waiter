using Microsoft.EntityFrameworkCore;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class AppContext : DbContext
    {
      public DbSet<Producto> Productos { get; set; }
      public DbSet<Persona> Personas { get; set; }
      public DbSet<Genero> Generos { get; set; }
      public DbSet<Carta> Cartas { get; set; } 
      public DbSet<FormaPago> FormaPagos { get; set; }
      public DbSet<Ingrediente> Ingredientes { get; set; }
      public DbSet<Orden> Ordenes {get; set; }
      public DbSet<Pedido> Pedidos {get; set; }
      public DbSet<Tamano> Tamanos {get; set; }
      public DbSet<TipoPedido> TipoPedidos {get; set; }

      
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
