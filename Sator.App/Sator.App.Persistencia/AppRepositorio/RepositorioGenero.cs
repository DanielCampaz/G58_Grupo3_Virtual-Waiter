using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia.AppRepositorio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class RepositorioGenero: IRepositorioGenero
    {
        private readonly AppContext _appContext;

        public RepositorioProducto(AppContext appContext)
        {
            _appContext = appContext;
        }
        IEnumerable<Genero> GetAllGeneros()
        {
            return _appContext.Generos;
        }
        Genero AddGenero(Genero genero)
        {
            var generoAdicionado = _appContext.Generos.Add(genero);
            _appContext.SaveChanges();
            return generoAdicionado.Entity;
        }
        Genero UpdateGenero(Genero genero)
        {
            var GeneroEncontrado = _appContext.Generos.FirstOrDefault(p => p.id == genero.id);
            if (GeneroEncontrado!= null)
            {
                GeneroEncontrado.abreviatura= genero.abreviatura;
                GeneroEncontrado.descripcion= genero.descripcion;
                _appContext.SaveChanges();
            }
            return PersonaEncontrado;
        }
        void DeleteGenero(int idGenero)
        {

        }    
        Genero GetGenero(int idGenero)
        {

        }
    }
}