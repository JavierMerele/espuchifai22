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
            Assert.Contains(usuarios, x => x.Contrasenia == ("6de757d63f193012e00d9312887012f6bf8ed2d7c6618dffb3cfb60e7f9b5e4a") && x.Email == ("gutierreez01@gmail.com"));
        }
    }
}
