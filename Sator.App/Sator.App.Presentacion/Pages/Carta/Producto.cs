using System;
using System.Collections.Generic;

namespace Sator.App.Presentacion.Pages{
    public class Producto{
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Producto (int id, string nombre, string descripcion){
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }



}