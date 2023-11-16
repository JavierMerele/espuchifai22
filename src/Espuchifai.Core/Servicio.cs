using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Espuchifai.Core;

namespace Espuchifai.adoET12;
public class Servicio
{
    public IAdo ado { get; set; }

    public Servicio(IAdo ado) => this.ado = ado;
    public void AltaBanda(Banda banda)
    {
        ValidarBanda(banda);
        ado.AltaBanda(banda);
    }

    private static void ValidarBanda(Banda banda)
    {
        if (string.IsNullOrEmpty(banda.Nombre))
        {
            throw new ArgumentException("Nombre no valido");
        }
        if (banda.Fundacion == 0)
        {
            throw new ArgumentException("Fundacion no valido");
        }
        if (banda.IdBanda != 0)
        {
            throw new ArgumentException("IdBanda no valido");
        }
    }

    async Task AltaBandaAsync(Banda banda)
    {
        ValidarBanda(banda);
        await ado.AltaBandaAsync(banda);
    }
    public List<Banda> ObtenerBandas() => ado.ObtenerBandas();
    
    public async Task<List<Banda>> ObtenerBandaAsync() => await ado.ObtenerBandaAsync();



    public void AltaAlbum(Album album)
    {
        ValidarAlbum(album);
        ado.AltaAlbum(album);
    }

    private void ValidarAlbum(Album album)
    {
        if (string.IsNullOrEmpty(album.Nombre))
        {
            throw new ArgumentException("Nombre no valido");
        }
        if (album.Lanzamiento > DateTime.Now)
        {
            throw new ArgumentException("Lanzamiento no valido");
        }
        if (album.IdBanda != 0)
        {
            throw new ArgumentException("IdBanda no valido");
        }
        if (album.IdAlbum != 0)
        {
            throw new ArgumentException("idAlbum no valido");
        }
        if (album.Cantidad <= 0)
        {
            throw new ArgumentException("Cantidad no valido");
        }
        
    }

    async Task AltaAlbumAsync(Album album)
    {
        ValidarAlbum(album);
        await ado.AltaAlbumAsync(album);
    }

    public List<Album> ObtenerAlbum() => ado.ObtenerAlbum();
    public async Task<List<Album>> ObtenerAlbumAsync() => await ado.ObtenerAlbumAsync();




    public void AltaCancion(Cancion cancion)
    {
        ValidarCancion(cancion);
        ado.AltaCancion(cancion);
    }

    private void ValidarCancion(Cancion cancion)
    {
        if (string.IsNullOrEmpty(cancion.Nombre))
        {
            throw new ArgumentException("Nombre no valido");
        }
        if (cancion.Orden <= 0)
        {
            throw new ArgumentException("Orden no valida");
        }
        if (cancion.IdAlbum != 0)
        {
            throw new ArgumentException("idAlbum no valido");
        }
        if (cancion.IdCancion != 0)
        {
            throw new ArgumentException("idCancion no valida");
        }
        if (cancion.Cantidad <= 0)
        {
            throw new ArgumentException("Cantidad no valida");
        }
    }

    async Task AltaCancionAsync(Cancion cancion)
    {
        ValidarCancion(cancion);
        await ado.AltaCancionAsync(cancion);
    }
    public List<Cancion> ObtenerCancion() => ado.ObtenerCancion();
    public async Task<List<Cancion>> ObtenerCancionAsync() => await ObtenerCancionAsync();



    public void AltaReproducir(Reproducciones reproducciones)
    {
        ValidadReproduccion(reproducciones);
        ado.Reproducir(reproducciones);
    }

    private void ValidadReproduccion(Reproducciones reproducciones)
    {
        if (reproducciones.Reproduccion > DateTime.Now)
        {
            throw new ArgumentException("Reproduccion no valido");
        }
        if (reproducciones.IdUsuario == 0)
        {
            throw new ArgumentException("IdUsuario no valido");
        }
        if (reproducciones.IdCancion == 0)
        {
            throw new ArgumentException("IdCancion no valido ");
        }
    }
    async Task AltaReproducirAsync (Reproducciones reproducciones)
    {
        ValidadReproduccion(reproducciones);
        await ado.AltaReproducirAsync(reproducciones);
    }
    List<Reproducciones> ObtenerReproduccion() => ado.ObtenerReproduccion();
    async Task<List<Reproducciones>> ObtenerReproduccionAsync() => await ado.ObtenerReproduccionAsync();


    public void registrarCliente (Usuario usuario)
    {
        ValidarUsuario(usuario);
        ado.registrarCliente(usuario);
    }

    private void ValidarUsuario(Usuario usuario)
    {
        if (string.IsNullOrEmpty(usuario.Nombre))
        {
            throw new ArgumentException("Nombre no valido");
        }
        if (string.IsNullOrEmpty(usuario.Apellido))
        {
            throw new ArgumentException("Apellido no valido");
        }
        if (string.IsNullOrEmpty(usuario.Email))
        {
            throw new ArgumentException("Email no valido");
        }
        if (string.IsNullOrEmpty(usuario.Contrasenia))
        {
            throw new ArgumentException("Contraseña no valido");
        }
        if (usuario.IdUsuario == 0)
        {
            throw new ArgumentException("IdUsuario no valido");
        }
    }

    async Task AltaregistrarClienteAsync (Usuario usuario)
    {
        ValidarUsuario(usuario);
        await ado.AltaregistrarClienteAsync(usuario);
    }
    List<Usuario> ObtenerUsuarios() => ado.ObtenerUsuarios();
    async Task<List<Usuario>> ObtenerUsuarioAsync() => await ado.ObtenerUsuarioAsync();
    

}