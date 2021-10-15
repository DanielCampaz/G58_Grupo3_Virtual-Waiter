using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Presentacion.Pages
{
    public class cartaModel : PageModel
    {
        private readonly IRepositorioProducto _repoProducto;
        private readonly IRepositorioIngrediente _repoIngrediente;

        public IEnumerable<Producto> producto_list { get; set; }

        public Producto producto { get; set; }  

        public int numIn;

        public List<Ingrediente> ingrediente = new List<Ingrediente>(){
            new Ingrediente(),
            new Ingrediente()
        };
        
        public TipoProducto tipoproducto { get; set; } 

        public cartaModel()
        {
            _repoProducto = new RepositorioProducto (new Sator.App.Persistencia.AppContext());
            _repoIngrediente = new RepositorioIngrediente (new Sator.App.Persistencia.AppContext());
            numIn = 0;
            producto = new Producto();
            producto_list = _repoProducto.GetAllProductos();
            /*producto_list = new List<Producto>(){
                new Producto{id=1, nombre="Papas Fritas", descripcion="Papas con tocineta y queso", tipoproducto= new TipoProducto{id=1, descripcion="Entrada"}, ingrediente= new List<Ingrediente>(){new Ingrediente{id=1, descripcion="Papa", cantidad=1}, new Ingrediente{id=2, descripcion="Queso", cantidad=1}, new Ingrediente{id=3, descripcion="Tocineta", cantidad=1}}},
                new Producto{id=2, nombre="Gratinado", descripcion="Maiz con queso tocineta", tipoproducto= new TipoProducto{id=2, descripcion="Entrada"}, ingrediente= new List<Ingrediente>(){new Ingrediente{id=4, descripcion="Queso", cantidad=1}, new Ingrediente{id=5, descripcion="Tocineta", cantidad=1}, new Ingrediente{id=6, descripcion="Maiz", cantidad=1}}},
                new Producto{id=3, nombre="Aros de cebolla", descripcion="Cebolla con queso frita", tipoproducto= new TipoProducto{id=3, descripcion="Entrada"}, ingrediente= new List<Ingrediente>(){new Ingrediente{id=7, descripcion="Cebolla", cantidad=1}, new Ingrediente{id=8, descripcion="Queso", cantidad=1}}}
            };*/
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (producto.nombre==null)
            {   
                return RedirectToPage("../Privacy");
            }else{
                return Page();
            }
            /*producto.ingrediente = ingrediente;
            producto.tipoproducto = tipoproducto;
            _repoProducto.AddProducto(producto);*/
        }

    }
}