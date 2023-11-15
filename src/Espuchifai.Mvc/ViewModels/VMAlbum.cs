using Espuchifai.Core;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Espuchifai.Mvc.ViewModels;

public class VMAlbum
{
    SelectList? Bandas;
    string? Canciones;
    string? Nombre { get; set;}

    DateTime Lanzamiento { get; set; }
    uint idAlbum { get; set; }
    uint idBanda { get; set; }
    uint Cantidad { get; set;}

    public VMAlbum() {}
    public VMAlbum (IEnumerable<Banda> bandas)
    {
        bandas = new SelectList(bandas,
                                dataTextField: nameof(Banda.Nombre),
                                dataValueField: nameof(Banda.IdBanda));
    }
    public VMAlbum(IEnumerable<Banda> bandas, Album album)
    {
        bandas = new SelectList(bandas,
                                dataTextField: nameof(Banda.Nombre),
                                dataValueField: nameof(Banda.IdBanda));
        Nombre = album.Nombre;
        Cantidad = album.IdBanda; 
    }

    
}