using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia.AppRepositorio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class RepositorioTamano: IRepositorioTamano
    {
        private readonly AppContext _appContext;

        public RepositorioTamano(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Tamano> IRepositorioTamano.GetAllTamanos()
        {
            return _appContext.Tamanos;
        }
        Tamano IRepositorioTamano.AddTamano(Tamano tamano)
        {
            var tamanoAdicionado = _appContext.Tamanos.Add(tamano);
            _appContext.SaveChanges();
            return tamanoAdicionado.Entity;
        }
        Tamano IRepositorioTamano.UpdateTamano(Tamano tamano)
        {
            var tamanoEncontrado = _appContext.Tamanos.FirstOrDefault(p => p.id == tamano.id);
            if (tamanoEncontrado!= null)
            {
                tamanoEncontrado.descripcion= tamano.descripcion;
                _appContext.SaveChanges();
            }
            return tamanoEncontrado;

        }
        void IRepositorioTamano.DeleteTamano(int idTamano)
        {
            var tamanoEncontrado = _appContext.Tamanos.FirstOrDefault(p => p.id == idTamano);
            if (tamanoEncontrado == null)
                return;
            _appContext.Tamanos.Remove(tamanoEncontrado);
            _appContext.SaveChanges();

        }
       Tamano IRepositorioTamano.GetTamano(int idTamano)
        {
            return _appContext.Tamanos.FirstOrDefault(p => p.id == idTamano);
        }

    }
}
