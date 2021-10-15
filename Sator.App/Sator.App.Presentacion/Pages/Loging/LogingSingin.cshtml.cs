using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Sator.App.Persistencia;
using Sator.App.Dominio;

namespace Sator.App.Presentacion.Pages
{
    public class LogingSinginModel : PageModel
    {
        private readonly ILogger<LogingSinginModel> _logger;

        private readonly IRepositorioPersona _repoPersona;

        public Persona persona { get; set; }
        public string confContra { get; set; }
        public string log_contrasena { get; set; }
        public string log_email { get; set; }

        public LogingSinginModel(ILogger<LogingSinginModel> logger)
        {
            _logger = logger;
            _repoPersona = new RepositorioPersona (new Sator.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (persona.nombre != null)
            {
                _repoPersona.AddPersona(persona);
                return Page();
            }
            if (log_email!=null)
            {
                Persona perso = _repoPersona.GetPersonaFEmail(log_email);
                if (perso!=null)
                {
                    if (perso.contrasena == log_contrasena)
                    {
                        return RedirectToPage("../Index");
                    }
                }
            }
            return Page();
        }
    }
}
