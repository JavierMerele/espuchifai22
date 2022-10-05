namespace Espuchifai.Core;

public class Cancion
{
    public string Nombre {get;set;}
    public int Orden {get;set;}
    public int idAlbum {get;set;}
    public int idCancion {get;set;}
    public int Cantidad {get;set;}
    public List<Reproduccion> Reproducciones { get; private set; }

}
