using System;
using System.Collections.Generic;

namespace Sator.App.Dominio.Entidades
{
    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public TipoProducto tipoproducto { get; set; }
        public List<Ingrediente> ingrediente { get; set; }

        public void Preparar()
        {
            Console.WriteLine("no se ha definido el metodo");
        }
    }
}