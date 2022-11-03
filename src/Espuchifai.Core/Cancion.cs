namespace Espuchifai.Core;

public class Cancion
{
    public string Nombre { get; set; }
    public uint Orden { get; set; }
    public uint IdAlbum { get; set; }
    public uint IdCancion { get; set; }
    public uint Cantidad { get; set; }

    public Cancion(string nombre, uint orden, uint idAlbum, uint idCancion, uint cantidad)
    {
        this.Nombre = nombre;
        this.Orden = orden;
        this.IdAlbum = idAlbum;
        this.IdCancion = idCancion;
        this.Cantidad = cantidad;
    }
}
