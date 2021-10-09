using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public interface IRepositorioGenero
    {
        IEnumerable<Genero> GetAllGeneros();
        Genero AddGenero(Genero genero);
        Genero UpdateGenero(Genero genero);
        void DeleteGenero(int idGenero);    
        Genero GetGenero(int idGenero);
    }
}