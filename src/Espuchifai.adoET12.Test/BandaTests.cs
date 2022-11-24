using Espuchifai.Core;
using et12.edu.ar.AGBD.Ado;

namespace Espuchifai.adoET12.Test;

public class BandaTests
{

    public AdoEspuchifai Ado { get; set; }
    public BandaTests()
    {
        var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
        Ado = new(adoAGBD);
    }

    [Fact]
    public void AltaBanda()
    {
        var banda = new Banda("QUEEN", 1980, 0);
        Ado.AltaBanda(banda);
        Assert.Equal((uint)2, banda.IdBanda);
    }

    [Theory]
    [InlineData(1, "ACDC")]
    public void TraerBandas(byte id, string nombre)
    {
        var banda = Ado.ObtenerBandas();
        Assert.Contains(banda, x => x.IdBanda == id && x.Nombre == nombre);
    }
}