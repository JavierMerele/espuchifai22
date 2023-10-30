using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Espuchifai.Mvc.Views
{
    public class Canciones : PageModel
    {
        private readonly ILogger<Canciones> _logger;

        public Canciones(ILogger<Canciones> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}