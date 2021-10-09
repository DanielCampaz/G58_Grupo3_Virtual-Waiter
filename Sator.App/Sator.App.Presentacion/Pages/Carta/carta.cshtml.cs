using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Sator.App.Dominio;

namespace Sator.App.Presentacion.Pages
{
    public class cartaModel : PageModel
    {
        public IEnumerable<Producto> producto_list { get; set; }

        public cartaModel()
        {
            producto_list = new List<Producto>(){
                new Producto{id=1, nombre="Papas Fritas", descripcion="Papas con tocineta y queso", tipoproducto= new TipoProducto{id=1, descripcion="Entrada"}, ingrediente= new List<Ingrediente>(){new Ingrediente{id=1, descripcion="Papa", cantidad=1}, new Ingrediente{id=2, descripcion="Queso", cantidad=1}, new Ingrediente{id=3, descripcion="Tocineta", cantidad=1}}},
                new Producto{id=2, nombre="Gratinado", descripcion="Maiz con queso tocineta", tipoproducto= new TipoProducto{id=2, descripcion="Entrada"}, ingrediente= new List<Ingrediente>(){new Ingrediente{id=4, descripcion="Queso", cantidad=1}, new Ingrediente{id=5, descripcion="Tocineta", cantidad=1}, new Ingrediente{id=6, descripcion="Maiz", cantidad=1}}},
                new Producto{id=3, nombre="Aros de cebolla", descripcion="Cebolla con queso frita", tipoproducto= new TipoProducto{id=3, descripcion="Entrada"}, ingrediente= new List<Ingrediente>(){new Ingrediente{id=7, descripcion="Cebolla", cantidad=1}, new Ingrediente{id=8, descripcion="Queso", cantidad=1}}}
            };
        }

        public void OnGet()
        {
        }

    }
}