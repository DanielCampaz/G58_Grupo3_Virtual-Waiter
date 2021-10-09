using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia.AppRepositorio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class RepositorioGenero: IRepositorioGenero
    {
        private readonly AppContext _appContext;

        public RepositorioGenero(AppContext appContext)
        {
            _appContext = appContext;
        }
        IEnumerable<Genero> IRepositorioGenero.GetAllGeneros()
        {
            return _appContext.Generos;
        }
        Genero IRepositorioGenero.AddGenero(Genero genero)
        {
            var generoAdicionado = _appContext.Generos.Add(genero);
            _appContext.SaveChanges();
            return generoAdicionado.Entity;
        }
        Genero IRepositorioGenero.UpdateGenero(Genero genero)
        {
            var GeneroEncontrado = _appContext.Generos.FirstOrDefault(p => p.id == genero.id);
            if (GeneroEncontrado!= null)
            {
                GeneroEncontrado.abreviatura= genero.abreviatura;
                GeneroEncontrado.descripcion= genero.descripcion;
                _appContext.SaveChanges();
            }
            return GeneroEncontrado;
        }
        void IRepositorioGenero.DeleteGenero(int idGenero)
        {
            var GeneroEncontrado = _appContext.Generos.FirstOrDefault(p => p.id == idGenero);
            if (GeneroEncontrado == null)
                return;
            _appContext.Generos.Remove(GeneroEncontrado);
            _appContext.SaveChanges();
        }    
        Genero IRepositorioGenero.GetGenero(int idGenero)
        {
             return _appContext.Generos.FirstOrDefault(p => p.id == idGenero);
        }
    }
}