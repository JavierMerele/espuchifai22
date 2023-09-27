using Espuchifai.Core;

namespace Espuchifai.adoET12;
public class Servicio
{
    public IAdo ado { get; set; }

    public Servicio(IAdo ado) => this.ado = ado;
    void AltaBanda(Banda banda)
    {
        if (string.IsNullOrEmpty(banda.Nombre))
        {
            throw new ArgumentException("Nombre no valido");
        }
        if (banda.Fundacion == 0)
        {
            throw new ArgumentException("Fundacion no valido");
        }
        if (banda.IdBanda !=0)
        {
            throw new ArgumentException("IdBanda no valido");
        }
    }
    Task AltaBandaAsync(Banda banda);
    List<Banda> ObtenerBandas();
    Task<List<Banda>> ObtenerBandaAsync();


    void AltaAlbum(Album album);
    Task AltaAlbumAsync(Album album);
    List<Album> ObtenerAlbum();
    Task<List<Album>> ObtenerAlbumAsync();

    void AltaAlbum(Album album)
    {
        if (string.IsNullOrEmpty(album.Nombre))
        {
            throw new ArgumentException("Nombre no valido");
        }
        if ()
        {
            
        }
        if (album.IdBanda != 0)
        {
            throw new ArgumentException ("IdBanda no valido");
        }
        if (album.IdAlbum != 0)
        {
            throw new ArgumentException ("idAlbum no valido");
        }
        if (album.Cantidad <= 0)
        {
            throw new ArgumentException ("Cantidad no valido");
        }

    }


    void AltaCancion(Cancion cancion);
    Task AltaCancionAsync(Cancion cancion);
    List<Cancion> ObtenerCancion();
    Task<List<Cancion>> ObtenerCancionAsync();

    void AltaCancion(Cancion cancion)
    {
        if (string.IsNullOrEmpty(cancion.Nombre))
        {
            throw new ArgumentException("Nombre no valido");
        }
        if (cancion.Orden <= 0)
        {
            throw new ArgumentException ("Orden no valida");
        }
        if (cancion.IdAlbum != 0)
        {
            throw new ArgumentException ("idAlbum no valido");
        }
        if (cancion.IdCancion != 0)
        {
            throw new ArgumentException ("idCancion no valida");
        }
        if (cancion.Cantidad < 0)
        {
            throw new ArgumentException ("Cantidad no valida");
        }



    void Reproducir(Reproducciones reproduccion);
    Task AltaReproducirAsync(Reproducciones reproduccion);
    List<Reproducciones> ObtenerReproduccion();
    Task<List<Reproducciones>> ObtenerReproduccionAsync();

    void AltaReproducir(Reproducciones reproducciones)

    {
        if (true)
        {
            
        }
        if (reproducciones.IdUsuario == 0)
        {
            throw new ArgumentException ("IdUsuario invalido");
        }
        if (reproducciones.IdCancion == 0)
        {
            throw new ArgumentException ("IdCancion no valido ");
        }
    }
        
    





    void registrarCliente(Usuario usuario);
    Task AltaregistrarClienteAsync(Usuario usuario);
    List<Usuario> ObtenerUsuarios();
    Task<List<Usuario>> ObtenerUsuarioAsync();

    void Alta

}