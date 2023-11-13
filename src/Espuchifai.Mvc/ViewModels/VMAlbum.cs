using Microsoft.AspNetCore.Mvc.Rendering;

namespace Espuchifai.Mvc.ViewModels;

public class VMAlbum
{
    SelectList? Bandas;
    string? Canciones;
    string Nombre {get; set}

    DatatimeLanzamiento { get; set; }

    
}