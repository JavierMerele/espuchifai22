using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Espuchifai.Mvc.Views
{
    public class Albumes : PageModel
    {
        private readonly ILogger<Albumes> _logger;

        public Albumes(ILogger<Albumes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}