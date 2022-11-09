using Espuchifai.Core;
using et12.edu.ar.AGBD.Ado;

namespace Espuchifai.adoET12.Test
{
    public class AlbumTests
    {


    public AdoEspuchifai Ado { get; set; }
    public AlbumTests()
    {
        var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
        Ado = new(adoAGBD);
    }

    [Fact]
    public void AltaAlbum()
    {
        var album = new Album("Thriller",new DateTime(1984-01-23),10,5,1);
        Ado.AltaAlbum(album);
        Assert.Equal((uint)10, album.IdAlbum);
    }

    [Theory]
    [InlineData(5,"Back in Black")]
    public void TraerAlbunes(byte id, string nombre)
    {
        var album = Ado.ObtenerAlbum();
        Assert.Contains(album, x => x.IdAlbum == id && x.Nombre == nombre);
    }
    }
}