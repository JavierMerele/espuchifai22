using Espuchifai.adoET12;
using Espuchifai.Core;
using Microsoft.AspNetCore.Mvc;

namespace Espuchifai.Mvc.Controllers;

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
    public async Task<IActionResult> Detalle(short? id)
    {
        if (id is null || id == 0)
            return NotFound();
        var banda = (await _servicio.ObtenerBandaAsync())
            .FirstOrDefault(a => a.IdBanda == id);
        if (banda is null)
            return NotFound();

        return View("Detalle", banda);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Alta(Banda banda)
    {
        if (banda.IdBanda == 0)
            await _servicio.AltaBandaAsync(banda);

        return RedirectToAction(nameof(this.Index));
    }

    [HttpGet]
    public IActionResult Alta() => View();
}
