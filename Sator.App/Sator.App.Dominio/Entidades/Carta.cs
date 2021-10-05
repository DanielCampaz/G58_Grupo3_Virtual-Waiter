using System;
using System.Collections.Generic;

namespace Sator.App.Dominio.Entidades
{
    public class Carta
    {
        public int id { get; set; }
        public List<ProductoTamano> productos { get; set; }
        public bool estado { get; set; }

        public void CambiarEstado()
        {
            if (estado)
            { 
               estado = false;
            }else{
               estado = true; 
            }
        }
    }
}