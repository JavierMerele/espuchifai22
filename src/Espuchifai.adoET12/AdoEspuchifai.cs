using Espuchifai.AdoMySQL.Mapeadores;
using Espuchifai.Core;
using et12.edu.ar.AGBD.Ado;

namespace Espuchifai.adoET12;
public class AdoEspuchifai
{
    public AdoAGBD Ado { get; set; }
    public MapBanda MapBanda { get; set; }
    public AdoEspuchifai(AdoAGBD ado)
    {
        Ado = ado;
        MapBanda = new MapBanda(Ado);
    }
    public void AltaBanda(Banda banda) => MapBanda.AltaBanda(banda);
    public List<Banda> ObtenerBandas() => MapBanda.ColeccionDesdeTabla();
}