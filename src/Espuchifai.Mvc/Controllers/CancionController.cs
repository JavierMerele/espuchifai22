
using Espuchifai.adoET12;
using Espuchifai.Core;
using Microsoft.AspNetCore.Mvc;

namespace Espuchifai.Mvc.Controllers
{
    [Route("[controller]")]
    public class CancionController : Controller
    {
        private readonly Servicio _servicio;

        public CancionController(Servicio servicio) => _servicio = servicio;

        public IActionResult Index()
        {
            var canciones = _servicio.ObtenerCancion();
            return View("Listado", canciones);
        }
        [HttpGet]
        public IActionResult Alta() => View();

    }
}