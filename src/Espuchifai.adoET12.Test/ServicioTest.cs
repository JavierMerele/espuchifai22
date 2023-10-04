using System.Data.OleDb;
using System.Net.Mail;
using System.Reflection;
using Espuchifai.Core;
using et12.edu.ar.AGBD.Ado;

namespace Espuchifai.adoET12.Test;

public class ServicioTest
{
    private readonly Servicio _servicio;
    public ServicioTest()
    {
        var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
        var ado = new AdoEspuchifai(adoAGBD!);
        _servicio = new Servicio(ado);
    }

    [Fact]
    public void BandaFalla()
    {
        Banda duaLipa = new Banda("", 10, 1);
        var excep = Assert.Throws<ArgumentException>(()=>_servicio.AltaBanda(duaLipa));
        Assert.Equal("Nombre no valido", excep.Message);
    }
    [Fact]
    public void AlbumFalla()
    {
        Album Justice = new Album("", new DateTime(2025,04,14), 8, 3, 5);
        var excep = Assert.Throws<ArgumentException>(()=>_servicio.AltaAlbum(Justice));
        Assert.Equal("Nombre no valido", excep.Message);
    }
    [Fact]
    public void CancionFalla()
    {
        Cancion volunta = new Cancion ("", 0, 1, 3, 0);
        var excep = Assert.Throws<ArgumentException>(()=>_servicio.AltaCancion(volunta));
        Assert.Equal("Nombre no valido",excep.Message);
    }
    [Fact]
    public void Reproduccion()
    {
        Reproducciones lal = new Reproducciones(new DateTime(2026, 04, 14),1, 8);
        var excep = Assert.Throws<ArgumentException>(()=>_servicio.AltaReproducir(lal));
        Assert.Equal("Reproduccion no valido", excep.Message);

    }
    [Fact]
    public void UsuarioFalla()
    {
        Usuario tito = new Usuario("","Calderon","tegitocalde@gmail.com", "tegi112", 1 );
        var excep = Assert.Throws<ArgumentException>(()=>_servicio.registrarCliente(tito));
        Assert.Equal("Nombre no valido", excep.Message);
    }
}
