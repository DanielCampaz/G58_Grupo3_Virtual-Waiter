using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Persistencia
{
    public class RepositorioOrden: IRepositorioOrden
    {
        private readonly AppContext _appContext;

        public RepositorioOrden(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Orden> IRepositorioOrden.GetAllOrdenes()
        {
            return _appContext.Ordenes;
        }
        Orden IRepositorioOrden.AddOrden(Orden orden)
        {
            var ordenAdicionado = _appContext.Ordenes.Add(orden);
            _appContext.SaveChanges();
            return ordenAdicionado.Entity;
        }
        Orden IRepositorioOrden.UpdateOrden(Orden orden)
        {
            var OrdenEncontrado = _appContext.Ordenes.FirstOrDefault(p => p.id == orden.id);
            if (OrdenEncontrado!= null)
            {
                OrdenEncontrado.cantidad= orden.cantidad;
                _appContext.SaveChanges();
            }
            return OrdenEncontrado;
        }
        void IRepositorioOrden.DeleteOrden(int idOrden)
        {
            var OrdenEncontrado = _appContext.Ordenes.FirstOrDefault(p => p.id == idOrden);
            if (OrdenEncontrado == null)
                return;
            _appContext.Ordenes.Remove(OrdenEncontrado);
            _appContext.SaveChanges();
        }
        Orden IRepositorioOrden.GetOrden(int idOrden)
        {
            return _appContext.Ordenes.FirstOrDefault(p => p.id == idOrden);
        }

    }
}
