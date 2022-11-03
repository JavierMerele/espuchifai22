namespace Espuchifai.Core;

public class Album
{
    public string Nombre { get; set; }
    public DateTime Lanzamiento { get; set; }
    public uint IdBanda { get; set; }
    public uint IdAlbum { get; set; }
    public uint Cantidad { get; set; }

    public Album(string nombre, DateTime lanzamiento, uint idBanda, uint idAlbum, uint cantidad)
    {
        this.Nombre = nombre;
        this.Lanzamiento = lanzamiento;
        this.IdBanda = idBanda;
        this.IdAlbum = idAlbum;
        this.Cantidad = cantidad;
    }
}
