using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia.AppRepositorio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class RepositorioTipoProducto: IRepositorioTipoProducto
    {
        private readonly AppContext _appContext;

        public RepositorioTipoProducto(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<TipoProducto> IRepositorioTipoProducto.GetAllTiposProductos()
        {
            return _appContext.TiposProductos;
        }
        TipoProducto IRepositorioTipoProducto.AddTipoProducto(TipoProducto tipoproducto)
        {
            var tipoProductoAdicionado = _appContext.TiposProductos.Add(tipoproducto);
            _appContext.SaveChanges();
            return tipoProductoAdicionado.Entity;
        }
        TipoProducto IRepositorioTipoProducto.UpdateTipoProducto(TipoProducto tipoproducto)
        {
            var TipoProductoEncontrado = _appContext.TiposProductos.FirstOrDefault(p => p.id == tipoproducto.id);
            if (TipoProductoEncontrado!= null)
            {
                TipoProductoEncontrado.descripcion= tipoproducto.descripcion;
                _appContext.SaveChanges();
            }
            return TipoProductoEncontrado;

        }
        void IRepositorioTipoProducto.DeleteTipoProducto(int idTipoProducto)
        {
            var TipoProductoEncontrado = _appContext.TiposProductos.FirstOrDefault(p => p.id == idTipoProducto);
            if (TipoProductoEncontrado == null)
                return;
            _appContext.TiposProductos.Remove(TipoProductoEncontrado);
            _appContext.SaveChanges();

        }
        TipoProducto IRepositorioTipoProducto.GetTipoProducto(int idTipoProducto)
        {
            return _appContext.TiposProductos.FirstOrDefault(p => p.id == idTipoProducto);
        }

    }
}