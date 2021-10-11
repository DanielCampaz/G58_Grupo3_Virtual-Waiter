using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Persistencia
{
    public class RepositorioProductoTamano: IRepositorioProductoTamano
    {
        private readonly AppContext _appContext;

        public RepositorioProductoTamano(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<ProductoTamano> IRepositorioProductoTamano.GetAllProductosTamanos()
        {
            return _appContext.ProductosTamanos;
        }
        ProductoTamano IRepositorioProductoTamano.AddProductoTamano(ProductoTamano productotamano)
        {
            var productoTamanoAdicionado = _appContext.ProductosTamanos.Add(productotamano);
            _appContext.SaveChanges();
            return productoTamanoAdicionado.Entity;
        }
        ProductoTamano IRepositorioProductoTamano.UpdateProductoTamano(ProductoTamano productotamano)
        {
            var ProductoTamanoEncontrado = _appContext.ProductosTamanos.FirstOrDefault(p => p.id == productotamano.id);
            if (ProductoTamanoEncontrado!= null)
            {
                ProductoTamanoEncontrado.tamano= productotamano.tamano;
                ProductoTamanoEncontrado.precio= productotamano.precio;
                _appContext.SaveChanges();
            }
            return ProductoTamanoEncontrado;

        }
        void IRepositorioProductoTamano.DeleteProductoTamano(int idProductoTamano)
        {
            var ProductoTamanoEncontrado = _appContext.ProductosTamanos.FirstOrDefault(p => p.id == idProductoTamano);
            if (ProductoTamanoEncontrado == null)
                return;
            _appContext.ProductosTamanos.Remove(ProductoTamanoEncontrado);
            _appContext.SaveChanges();

        }
        ProductoTamano IRepositorioProductoTamano.GetProductoTamano(int idProductoTamano)
        {
            return _appContext.ProductosTamanos.FirstOrDefault(p => p.id == idProductoTamano);
        }

    }
}