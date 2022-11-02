namespace Espuchifai.adoET12.Test;

public class BandaTests
{
    
    public AdoTest Ado { get; set; }
    public BandaTest()
    {
        var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
        Ado = new AdoTest(adoAGBD);
    }

    [Fact]
    public void AltaBanda()
    {
        var banda = new Banda("QUEEN");
        Ado.AltaBanda(banda);
        Assert.Equal(2, banda.Id);
    }

    [Theory]
    [InlineData(1, "ACDC")]
    public void TraerBandas(byte id, string nombre)
    {
        var banda = Ado.ObtenerBandas();
        Assert.Contains(banda, x => x.Id == id && x.Nombre == nombre);
    }
}