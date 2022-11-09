using Espuchifai.Core;
using et12.edu.ar.AGBD.Ado;
namespace Espuchifai.adoET12.Test
{
    public class CancionTests
    {
        public AdoEspuchifai Ado { get; set; }
    public CancionTests()
    {
        var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
        Ado = new(adoAGBD);
    }

    [Fact]
    public void AltaCancion()
    {
        var cancion = new Cancion("Shape of You",1,5,16,2);
        Ado.AltaCancion(cancion);
        Assert.Equal((uint)10, cancion.IdCancion);
    }

    [Theory]
    [InlineData(15,"Gimme a Bullet")]
    public void TraerCanciones(byte id, string nombre)
    {
        var cancions = Ado.ObtenerCancion();
        Assert.Contains(cancions, x => x.IdCancion == id && x.Nombre == nombre);
    }

    }
}