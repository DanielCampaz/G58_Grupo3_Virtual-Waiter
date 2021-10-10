using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public interface IRepositorioOrden
    {
        IEnumerable<Orden> GetAllOrdenes();
        Orden AddOrden(Orden orden);
        Orden UpdateOrden(Orden orden);
        void DeleteOrden(int idOrden);    
        Orden GetOrden(int idOrden);
    }
}
