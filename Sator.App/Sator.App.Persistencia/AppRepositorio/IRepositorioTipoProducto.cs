using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia
{
    public interface IRepositorioTipoProducto
    {
        IEnumerable<TipoProducto> GetAllTiposProductos();
        TipoProducto AddTipoProducto(TipoProducto tipoproducto);
        TipoProducto UpdateTipoProducto(TipoProducto tipoproducto);
        void DeleteTipoProducto(int idTipoProducto);    
        TipoProducto GetTipoProducto(int idTipoProducto);
    }
}