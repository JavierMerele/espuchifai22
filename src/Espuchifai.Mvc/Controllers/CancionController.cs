
using Espuchifai.adoET12;
using Microsoft.AspNetCore.Mvc;


namespace Espuchifai.Mvc.Controllers;
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
    public async Task<IActionResult> Detalle(short? id)
    {
        if (id is null || id == 0)
            return NotFound();
        var cancion = (await _servicio.ObtenerCancionAsync())
            .FirstOrDefault(a => a.IdCancion == id);
        if (cancion is null)
            return NotFound();
        return View("Detalle", cancion);
    }
    // [HttpGet]
    //public async Task<IActionResult> Alta(short? id)
    //{

    //    var cancion = (await _servicio.ObtenerCancionAsync())
    //        .FirstOrDefault(a => a.IdCancion == id);
    //    var vMAlbum = new VMAlbum();
    //    return View("Alta", cancion);
    //}

    [HttpGet]
    public IActionResult Alta() => View();

}
