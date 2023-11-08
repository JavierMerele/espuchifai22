
using Espuchifai.Core;
using Espuchifai.Mvc.Views;
using Microsoft.AspNetCore.Mvc;

namespace Espuchifai.Mvc.Controllers
{
    [Route("[controller]")]
    public class CancionController : Controller
    {
        private readonly ILogger<CancionController> _logger;

        public CancionController(ILogger<CancionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var canciones = new List<Cancion>
            {
                new Cancion("Shape of You", orden: 1, idAlbum: 2, idCancion: 1, cantidad: 2)
            };
        }
        [HttpGet]
        public IActionResult Alta() => View();
    }
}