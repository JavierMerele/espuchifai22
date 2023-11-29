using Espuchifai.adoET12;
using Microsoft.AspNetCore.Mvc;
using Espuchifai.Mvc.ViewModels;

namespace Espuchifai.Mvc.Controllers;
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
    public async Task<IActionResult> Detalle(short? id)
    {
        if (id is null || id == 0)
            return NotFound();
        var album = (await _servicio.ObtenerAlbumAsync())
            .FirstOrDefault(a => a.IdAlbum == id);
        if (album is null)
            return NotFound();
        return View("Detalle", album);
    }


    [HttpGet]
    public async Task<IActionResult> Alta(short? id)
    {

        var bandas = await _servicio.ObtenerBandaAsync();
        var VMAlbum = new VMAlbum(bandas);
        return View("Alta", VMAlbum);
    }

    //[HttpGet]
    //public IActionResult Alta() => View();

}