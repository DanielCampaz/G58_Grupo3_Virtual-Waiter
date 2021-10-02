using System;

namespace Sator.App.Dominio.Entidades
{
    public class Pedido
    {
        public int id { get; set; }
        public Orden producto { get; set; }    
        public Persona cliente { get; set; }
        public DateTime fecha { get; set; }
        public DateTime horapedido { get; set; }
        public DateTime horaentrega { get; set; }
        public TipoPedido tipo { get; set; }
        public Persona empleasdo { get; set; }
        public FormaPago formapago { get; set; }

        public void Pagar()
        {
            Console.WriteLine("Definicion no definida aun");
        }

        public void Facturar()
        {
            Console.WriteLine("Definicion no definida aun");
        }
    }
}