using Espuchifai.Core;

namespace Espuchifai.adoET12;
public interface IAdo
{
    void AltaBanda(Banda banda);
    Task AltaBandaAsync(Banda banda);
    List<Banda> ObtenerBandas();
    Task<List<Banda>> ObtenerBandaAsync();


    void AltaAlbum(Album album);
    Task AltaAlbumAsync(Album album);
    List<Album> ObtenerAlbum();
    Task<List<Album>> ObtenerAlbumAsync();




    void AltaCancion(Cancion cancion);
    Task AltaCancionAsync(Cancion cancion);
    List<Cancion> ObtenerCancion();
    Task<List<Cancion>> ObtenerCancionAsync();




    void Reproducir(Reproducciones reproduccion);
    Task AltaReproducirAsync(Reproducciones reproduccion);
    List<Reproducciones> ObtenerReproduccion();
    Task<List<Reproducciones>> ObtenerReproduccionAsync();




    void registrarCliente(Usuario usuario);
    Task AltaregistrarClienteAsync(Usuario usuario);
    List<Usuario> ObtenerUsuarios();
    Task<List<Usuario>> ObtenerUsuarioAsync();

}