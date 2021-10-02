using System;

namespace Sator.App.Dominio.Entidades
{
    public class Orden
    {
        public int cantidad { get; set; }

        public void CalcularCosto()
        {
            Console.WriteLine("No se ha defenido el metodso");
        }
    }
}