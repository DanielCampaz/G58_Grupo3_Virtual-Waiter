using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Persistencia
{
    public class RepositorioIngrediente: IRepositorioIngrediente
    {
        private readonly AppContext _appContext;

        public RepositorioIngrediente(AppContext appContext)
        {
            _appContext = appContext;
        }
        IEnumerable<Ingrediente> IRepositorioIngrediente.GetAllIngredientes()
        {
            return _appContext.Ingredientes;
        }
        Ingrediente IRepositorioIngrediente.AddIngrediente(Ingrediente ingrediente)
        {
            var ingredienteAdicionado = _appContext.Ingredientes.Add(ingrediente);
            _appContext.SaveChanges();
            return ingredienteAdicionado.Entity;
        }
        Ingrediente IRepositorioIngrediente.UpdateIngrediente(Ingrediente ingrediente)
        {
            var IngredienteEncontrado = _appContext.Ingredientes.FirstOrDefault(p => p.id == ingrediente.id);
            if (IngredienteEncontrado!= null)
            {
                IngredienteEncontrado.descripcion= ingrediente.descripcion;
                IngredienteEncontrado.cantidad= ingrediente.cantidad;
                _appContext.SaveChanges();
            }
            return IngredienteEncontrado;
        }
        void IRepositorioIngrediente.DeleteIngrediente(int idIngrediente)
        {
            var IngredienteEncontrado = _appContext.Ingredientes.FirstOrDefault(p => p.id == idIngrediente);
            if (IngredienteEncontrado == null)
                return;
            _appContext.Ingredientes.Remove(IngredienteEncontrado);
            _appContext.SaveChanges();
        }
        Ingrediente IRepositorioIngrediente.GetIngrediente(int idIngrediente)
        {
            return _appContext.Ingredientes.FirstOrDefault(p => p.id == idIngrediente);
        }
    }
}