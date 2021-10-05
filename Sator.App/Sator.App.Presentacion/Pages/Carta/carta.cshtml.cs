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
        public List<Producto> producto_list{ get; set; }

        public void OnGet()
        {
        }
       public void Llenarlista()
        {
            for (var i = 0; i < 10; i++)
            {
                producto_list.Add(new Producto(i, "Papas a la francesa","The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested."));
            }
        }

    }
}
