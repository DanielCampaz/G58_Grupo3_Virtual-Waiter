using System;

namespace Sator.App.Dominio
{
    public class Persona
    {
        public int id { get; set; }
        public TipoId tipoid { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fec_nacimiento { get; set; }
        public Genero genero { get; set; }
        public string email { get; set; } 
        public float num_cel { get; set; }
        public bool admin { get; set; }
        public string contrasena { get; set; }
    }
}