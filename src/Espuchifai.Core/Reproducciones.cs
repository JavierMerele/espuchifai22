namespace Espuchifai.Core;
public class Reproducciones
{
    public DateTime Reproduccion { get; set; }
    public uint IdUsuario { get; set; }
    public uint IdCancion { get; set; }

    public Reproducciones(DateTime reproduccion, uint idCancion, uint idUsuario)
    {
        this.Reproduccion = reproduccion;
        this.IdCancion = idCancion;
        this.IdUsuario = idUsuario;
    }

}

