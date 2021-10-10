using System;
using System.Collections.Generic;

namespace Sator.App.Dominio
{
    public class Pedido
    {
        public int id { get; set; }
        public List<Orden> orden { get; set; }    
        public Persona cliente { get; set; }
        public DateTime fecha { get; set; }
        public DateTime horapedido { get; set; }
        public DateTime horaentrega { get; set; }
        public TipoPedido tipo { get; set; }
        public Persona empleado { get; set; }
        public FormaPago formapago { get; set; }

        public float Pagar()
        {
            float totalpedido = 0;

            foreach (var producto in orden)
            {
                float costoProducto = producto.CalcularCosto();
                totalpedido = totalpedido + costoProducto;     
            }

            return totalpedido;
        }

        public void Facturar()
        {
            Console.WriteLine("Definicion no definida aun");
        }
    }
}