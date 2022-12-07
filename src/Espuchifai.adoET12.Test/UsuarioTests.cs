using Espuchifai.Core;
using et12.edu.ar.AGBD.Ado;

namespace Espuchifai.adoET12.Test
{
    public class UsuarioTests
    {
        public AdoEspuchifai Ado { get; set; }
        public UsuarioTests()
        {
            var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
            Ado = new(adoAGBD);
        }
        public void AltaUsuario()
        {
            var usuario = new Usuario("Javier", "Merele", "javiermereleet12d1@gmail.com", "manzana", 0);
            Ado.AltaUsuario(usuario);
            Assert.Equal((uint)2, usuario.IdUsuario);
        }

        [Theory]
        [InlineData(2, "")]
        public void TraerUsuarios(string contrasenia, string email)
        {
            var usuarios = Ado.ObtenerUsuarios();
            Assert.Contains(usuarios, x => x.Contrasenia == contrasenia && x.Email == email);
        }
    }
}
