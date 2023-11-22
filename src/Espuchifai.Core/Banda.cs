namespace Espuchifai.Core;

public class Banda
{
    public string Nombre { get; set; }
    public uint Fundacion { get; set; }
    public uint IdBanda { get; set; }

    public Banda(string nombre, uint fundacion, uint idBanda)
    {
        this.Nombre = nombre;
        this.Fundacion = fundacion;
        this.IdBanda = idBanda;
    }

    // Vacio para poder bindear con la vista
    public Banda()
    {
        IdBanda = 0;
    }
}
