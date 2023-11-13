using Espuchifai.Core;
using Microsoft.AspNetCore.Mvc;


namespace Espuchifai.Mvc.Controllers
{
    [Route("[controller]")]
    public class AlbumController : Controller
    {
        private readonly ILogger<AlbumController> _logger;

        public AlbumController(ILogger<AlbumController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var albumes = new List<Album>
            {
                new Album("Un Verano sin ti", new DateTime(2022, 1, 24), idBanda:0, idAlbum:0, cantidad: 1)
            };
        return View(albumes);
        }
        [HttpGet]
        public IActionResult Alta() => View();
        
        [HttpPost]


    }
}