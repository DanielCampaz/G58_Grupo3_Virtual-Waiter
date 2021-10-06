using System;
using System.Collections.Generic;

namespace Sator.App.Dominio.Entidades
{
    public class Pedido
    {
        public int id { get; set; }
        public List<Orden> producto { get; set; }    
        public Persona cliente { get; set; }
        public DateTime fecha { get; set; }
        public DateTime horapedido { get; set; }
        public DateTime horaentrega { get; set; }
        public TipoPedido tipo { get; set; }
        public Persona empleasdo { get; set; }
        public FormaPago formapago { get; set; }

        /*public float Pagar()
        {
            float totalpedido = 0;

            foreach (var item in producto)
            {
                float costoProducto = item.CalcularCosto;
                totalpedido = totalpedido + costoProducto;     
            }

            return totalpedido;
        }*/

        public void Facturar()
        {
            Console.WriteLine("Definicion no definida aun");
        }
    }
}