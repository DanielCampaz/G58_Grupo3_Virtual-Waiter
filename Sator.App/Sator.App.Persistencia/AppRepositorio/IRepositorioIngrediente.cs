using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public interface IRepositorioIngrediente
    {
        IEnumerable<Ingrediente> GetAllIngredientes();
        Ingrediente AddIngrediente(Ingrediente ingrediente);
        Ingrediente UpdateIngrediente(Ingrediente ingrediente);
        void DeleteIngrediente(int idIngrediente);    
        Ingrediente GetIngrediente(int idIngrediente);
    }
}