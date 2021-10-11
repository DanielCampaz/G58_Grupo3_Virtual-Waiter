using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia
{
    public interface IRepositorioTipoId
    {
        IEnumerable<TipoId> GetAllTiposIds();
        TipoId AddTipoId(TipoId tipoid);
        TipoId UpdateTipoId(TipoId tipoid);
        void DeleteTipoId(int idTipoId);    
        TipoId GetTipoId(int idTipoId);
    }
}