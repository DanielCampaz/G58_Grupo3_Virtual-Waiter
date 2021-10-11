using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Persistencia
{
    public class RepositorioPersona: IRepositorioPersona
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }
        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionado = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
        }
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.id == persona.id);
            if (PersonaEncontrado!= null)
            {
                PersonaEncontrado.nombre= persona.nombre;
                PersonaEncontrado.apellido= persona.apellido;
                PersonaEncontrado.num_cel= persona.num_cel;
                PersonaEncontrado.fec_nacimiento= persona.fec_nacimiento;
                PersonaEncontrado.genero= persona.genero;
                PersonaEncontrado.tipoid= persona.tipoid;
                PersonaEncontrado.admin= persona.admin;
                PersonaEncontrado.contrasena= persona.contrasena;
                PersonaEncontrado.email= persona.email;
                _appContext.SaveChanges();
            }
            return PersonaEncontrado;
        }
        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.id == idPersona);
            if (PersonaEncontrado == null)
                return;
            _appContext.Personas.Remove(PersonaEncontrado);
            _appContext.SaveChanges();
        }
        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.id == idPersona);
        }
        Persona IRepositorioPersona.GetPersonaFEmail(string emPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.email == emPersona);
        }
    }
}