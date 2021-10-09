using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia.AppRepositorio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class RepositorioProducto: IRepositorioProducto
    {
        private readonly AppContext _appContext;

        public RepositorioProducto(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Producto> IRepositorioProducto.GetAllProductos()
        {
            return _appContext.Productos;
        }
        Producto IRepositorioProducto.AddProducto(Producto producto)
        {
            var productoAdicionado = _appContext.Productos.Add(producto);
            _appContext.SaveChanges();
            return productoAdicionado.Entity;
        }
        Producto IRepositorioProducto.UpdateProducto(Producto producto)
        {
            var ProductoEncontrado = _appContext.Productos.FirstOrDefault(p => p.id == producto.id);
            if (ProductoEncontrado!= null)
            {
                ProductoEncontrado.descripcion= producto.descripcion;
                ProductoEncontrado.nombre= producto.nombre;
                _appContext.SaveChanges();
            }
            return ProductoEncontrado;

        }
        void IRepositorioProducto.DeleteProducto(int idProducto)
        {
            var ProductoEncontrado = _appContext.Productos.FirstOrDefault(p => p.id == idProducto);
            if (ProductoEncontrado == null)
                return;
            _appContext.Productos.Remove(ProductoEncontrado);
            _appContext.SaveChanges();

        }
        Producto IRepositorioProducto.GetProducto(int idProducto)
        {
            return _appContext.Productos.FirstOrDefault(p => p.id == idProducto);
        }

    }
}