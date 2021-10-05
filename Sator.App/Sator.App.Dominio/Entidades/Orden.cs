using System;

namespace Sator.App.Dominio.Entidades
{
    public class Orden: ProductoTamano
    {
        public int cantidad { get; set; }

        public Orden(int cantidad, ProductoTamano ptamano)
        {
            this.tamano = ptamano.tamano;
            this.precio = ptamano.precio;
            this.cantidad = cantidad;   
        }

        public float CalcularCosto()
        {
            float precioCal = this.precio * cantidad;
            return precioCal;
        }
    }
}