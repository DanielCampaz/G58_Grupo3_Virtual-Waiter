using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public interface IRepositorioProducto
    {
        IEnumerable<Producto> GetAllProductos();
        Producto AddProducto(Producto producto);
        Producto UpdateProducto(Producto producto);
        void DeleteProducto(int idProducto);    
        Producto GetProducto(int idProducto);
    }
}