using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public interface IRepositorioTamano
    {
        IEnumerable<Tamano> GetAllTamanos();
        Tamano AddTamano(Tamano tamano);
        Tamano UpdateTamano(Tamano tamano);
        void DeleteTamano(int idTamano);    
        Tamano GetTamano(int idTamano);
    }
}
