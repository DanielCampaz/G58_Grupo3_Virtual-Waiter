using System;

namespace Sator.App.Dominio.Entidades
{
    public class Sucursal
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public int num_fijo { get; set; }
        public int num_cel { get; set; }
        public bool estado { get; set; }
        public Carta carta { get; set; }
    }
}