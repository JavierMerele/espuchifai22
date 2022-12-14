using Espuchifai.Core;
using et12.edu.ar.AGBD.Ado;
namespace Espuchifai.adoET12.Test
{
    public class ReproduccionTests
    {
        public AdoEspuchifai Ado { get; set; }
        public ReproduccionTests()
        {
            var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
            Ado = new(adoAGBD);
        }
        

        [Fact]
        public void AltaReproduccion()
        {
            var reproducciones = new Reproducciones(new DateTime(2022, 1, 23),1,0);
            Ado.AltaReproduccion(reproducciones);
            Assert.Equal((uint)7, reproducciones.IdCancion);
        }

        [Fact]
        public void ObtenerReproduccion(byte id, DateTime reproduccion)
        {
            var canciones = Ado.ObtenerReproduccion();
            Assert.Contains(canciones, x => x.IdCancion == id && x.Reproduccion == reproduccion);
        }


    }
}