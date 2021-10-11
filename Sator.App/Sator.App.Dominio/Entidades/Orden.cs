using System;

namespace Sator.App.Dominio
{
    public class Orden: ProductoTamano
    {
        public int id { get; set; }
        public int cantidad { get; set; }

        public float CalcularCosto()
        {
            float precioCal = this.precio * cantidad;
            return precioCal;
        }
    }
}