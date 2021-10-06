using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sator.App.Presentacion.Pages
{
    public class cartaModel : PageModel
    {
        //public List<Producto> producto_list{ get; set; }

        public void OnGet()
        {
            //Llenarlista();
        }
       /*public void Llenarlista()
        {
            for (var i = 0; i < 10; i++)
            {
                producto_list.Add(new Producto(i, "Papas a la francesa","The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested."));
            }
        }*/

    }
}


/*
@foreach (var Producto in Model.producto_list)
{
	<div class="card" style="width: 18rem;">
  	<img src="..." class="card-img-top" alt="...">
  	<div class="card-body">
    	<h5 class="card-title">@Producto.nombre</h5>
		<p class="card-text">@Producto.descripcion</p>
		<a href="#" class="btn btn-warning">Agregar</a>
  	</div>
</div>
}
*/
