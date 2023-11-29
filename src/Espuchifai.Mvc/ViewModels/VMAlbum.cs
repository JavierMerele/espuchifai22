using Espuchifai.Core;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Espuchifai.Mvc.ViewModels;

public class VMAlbum
{
    public SelectList? Bandas;
    public string? Canciones;
    public string? Nombre { get; set;}

    public DateTime Lanzamiento { get; set; }
    public uint IdAlbum { get; set; }
    public uint IdBanda { get; set; }
    public uint Cantidad { get; set;}

    public VMAlbum() {}
    public VMAlbum (IEnumerable<Banda> bandas)
    {
        Bandas = new SelectList(bandas,
                                dataTextField: nameof(Banda.Nombre),
                                dataValueField: nameof(Banda.IdBanda));
    }
    public VMAlbum(IEnumerable<Banda> bandas, Album album)
    {
        Bandas = new SelectList(bandas,
                                dataTextField: nameof(Banda.Nombre),
                                dataValueField: nameof(Banda.IdBanda));
        Nombre = album.Nombre;
        Cantidad = album.IdBanda; 
    }

    
}