using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Sator.App.Presentacion.Pages
{
    public class LogingSinginModel : PageModel
    {
        private readonly ILogger<LogingSinginModel> _logger;

        public LogingSinginModel(ILogger<LogingSinginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
