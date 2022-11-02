namespace Espuchifai.Core;

public class Album
{
    public string Nombre { get; set; }
    public DateTime Lanzamiento { get; set; }
    public uint IdBanda { get; set; }
    public uint IdAlbum { get; set; }
    public uint Cantidad { get; set; }

    public Album(string nombre , uint fundacion , uint idBanda)
    {
        this.Nombre = nombre;
        this.Fundacion = fundacion;
        this.IdBanda = idBanda;
    }
}
