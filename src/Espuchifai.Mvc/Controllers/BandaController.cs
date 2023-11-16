using Espuchifai.adoET12;
using Espuchifai.Core;
using Microsoft.AspNetCore.Mvc;


namespace Espuchifai.Mvc.Controllers
{
    [Route("[controller]")]
    public class BandaController : Controller
    {
        private readonly Servicio _servicio;

        public BandaController(Servicio servicio) => _servicio = servicio;

        public IActionResult Index()
        {
            var bandas = _servicio.ObtenerBandas();
            return View("Listado", bandas);
        }
        [HttpGet]
        public IActionResult Alta () =>View(); 
    }
}