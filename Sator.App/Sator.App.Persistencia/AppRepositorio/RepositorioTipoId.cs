using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Persistencia
{
    public class RepositorioTipoId: IRepositorioTipoId
    {
        private readonly AppContext _appContext;

        public RepositorioTipoId(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<TipoId> IRepositorioTipoId.GetAllTiposIds()
        {
            return _appContext.TiposIds;
        }
        TipoId IRepositorioTipoId.AddTipoId(TipoId tipoid)
        {
            var tipoIdAdicionado = _appContext.TiposIds.Add(tipoid);
            _appContext.SaveChanges();
            return tipoIdAdicionado.Entity;
        }
        TipoId IRepositorioTipoId.UpdateTipoId(TipoId tipoid)
        {
            var TipoIdEncontrado = _appContext.TiposIds.FirstOrDefault(p => p.id == tipoid.id);
            if (TipoIdEncontrado!= null)
            {
                TipoIdEncontrado.tipoID= tipoid.tipoID;
                TipoIdEncontrado.numeroID= tipoid.numeroID;
                _appContext.SaveChanges();
            }
            return TipoIdEncontrado;

        }
        void IRepositorioTipoId.DeleteTipoId(int idTipoId)
        {
            var TipoIdEncontrado = _appContext.TiposIds.FirstOrDefault(p => p.id == idTipoId);
            if (TipoIdEncontrado == null)
                return;
            _appContext.TiposIds.Remove(TipoIdEncontrado);
            _appContext.SaveChanges();

        }
        TipoId IRepositorioTipoId.GetTipoId(int idTipoId)
        {
            return _appContext.TiposIds.FirstOrDefault(p => p.id == idTipoId);
        }

    }
}