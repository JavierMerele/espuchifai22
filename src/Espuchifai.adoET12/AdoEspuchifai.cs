using Espuchifai.AdoMySQL.Mapeadores;
using Espuchifai.Core;
using et12.edu.ar.AGBD.Ado;

namespace Espuchifai.adoET12;
public class AdoEspuchifai
{
    public AdoAGBD Ado { get; set; }
    public MapBanda MapBanda { get; set; }
    public MapAlbum MapAlbum {get;set;}

    public MapCancion MapCancion{get;set;}
    public AdoEspuchifai(AdoAGBD ado)
    {
        Ado = ado;
        MapBanda = new MapBanda(Ado);
        MapAlbum = new MapAlbum(ado);
        MapCancion = new MapCancion(Ado);
    }
    public void AltaBanda(Banda banda) => MapBanda.AltaBanda(banda);
    public List<Banda> ObtenerBandas() => MapBanda.ColeccionDesdeTabla();

    public void AltaAlbum(Album album) => MapAlbum.AltaAlbum(album);
    public List<Album> ObtenerAlbum() => MapAlbum.ColeccionDesdeTabla();

    public void AltaCancion(Cancion cancion) => MapCancion.AltaCancion(cancion);
    
    public List<Cancion> ObtenerCancion()=> MapCancion.ColeccionDesdeTabla();
}