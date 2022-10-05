namespace Espuchifai.Core;

public class Album
{
    public string Nombre {get;set;}
    public string Lanzamiento {get;set;}
    public int idBanda {get;set;}
    public int idAlbum {get;set;}
    public int Cantidad {get;set;}
    public List<Banda> Bandas { get; private set; }

}
