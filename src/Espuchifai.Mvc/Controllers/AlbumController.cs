using Espuchifai.adoET12;
using Espuchifai.Core;
using Microsoft.AspNetCore.Mvc;


namespace Espuchifai.Mvc.Controllers
{
    [Route("[controller]")]
    public class AlbumController : Controller
    {
        private readonly Servicio _servicio;

        public AlbumController(Servicio servicio) => _servicio = servicio;

        public IActionResult Index()
        {
            var albumes = _servicio.ObtenerAlbum();
            return View("Listado", albumes);
        }
        [HttpGet]
        public IActionResult Alta() => View();

    }
}