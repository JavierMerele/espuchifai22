namespace Espuchifai.Core;

public class Banda
{
    public string Nombre {get;set;}
    public string Fundacion {get;set;}
    public int idBanda {get;set;}
    public List<Cancion> Canciones { get; private set; }

}
