using Espuchifai.Core;
using Microsoft.AspNetCore.Mvc;


namespace Espuchifai.Mvc.Controllers
{
    [Route("[controller]")]
    public class BandaController : Controller
    {
        private readonly ILogger<BandaController> _logger;

        public BandaController(ILogger<BandaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var bandas = new List<Banda>
            {
                new Banda("QUEEN", 1980, idBanda: 2) 
            };
        return View(bandas);
        }
        [HttpGet]
        public IActionResult Alta () =>View();

        [HttpPost]
        public ActionResult Post([FromBody] Views_Banda_Alta banda)
        {
            return NotFound()
        }   
    }
}