using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia
{
    public interface IRepositorioProductoTamano
    {
        IEnumerable<ProductoTamano> GetAllProductosTamanos();
        ProductoTamano AddProductoTamano(ProductoTamano productotamano);
        ProductoTamano UpdateProductoTamano(ProductoTamano productotamano);
        void DeleteProductoTamano(int idProductoTamano);    
        ProductoTamano GetProductoTamano(int idProductoTamano);
    }
}