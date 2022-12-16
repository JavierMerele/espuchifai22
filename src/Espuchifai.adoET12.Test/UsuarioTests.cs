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

        [Fact]
        public void registrarCliente()
        {
            var usuario = new Usuario("Javier", "Merele", "javiermereleet12d1@gmail.com", "manzana", 2);
            Ado.registrarCliente(usuario);
            Assert.Equal((uint)2, usuario.IdUsuario);
        }

        [Fact]
        public void TraerUsuarios()
        {
            var usuarios = Ado.ObtenerUsuarios();
            Assert.Contains(usuarios, x => x.Contrasenia == ("4444") && x.Email == ("pepe@pepita"));
        }
    }
}
