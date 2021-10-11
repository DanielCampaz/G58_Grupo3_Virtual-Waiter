using Microsoft.EntityFrameworkCore;
using Sator.App.Dominio;

namespace Sator.App.Persistencia
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
      public DbSet<ProductoTamano> ProductosTamanos { get; set; }
      public DbSet<Sucursal> Sucursales { get; set; }
      public DbSet<TipoId> TiposIds { get; set; }
      public DbSet<TipoProducto> TiposProductos { get; set; }
      
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Server=localhost; Database=DESARROLLO; user id=sa; password=daniel2008b; Initial Catalog = SatorDb");
            }
        }   
    }
}
