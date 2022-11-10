using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System.Data;
using Espuchifai.Core;

namespace Espuchifai.AdoMySQL.Mapeadores
{
    public class MapUsuario : Mapeador<Usuario>
    {
        public MapUsuario(AdoAGBD ado) : base(ado)
        {
            Tabla = "Usuario";
        }
        public override Usuario ObjetoDesdeFila(DataRow fila)
            => new Usuario
            (
                idUsuario: Convert.ToUInt32(fila["idUsuario"]),
                nombre: fila["nombre"].ToString()!,
                apellido: fila["apellido"].ToString()!,
                contrasenia: fila["contrasenia"].ToString()!,
                email: fila["email"].ToString()!
            );
        public void AltaUsuario(Usuario usuario)
                => EjecutarComandoCon("altaReproduccion", AltaUsuario, postAltaUsuario, usuario);


        public void ConfigurarAltaReproduccion(Usuario usuario)
        {
            SetComandoSP("altaUsuario");

            BP.CrearParametro("unidUsuario")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
            .AgregarParametro();

            BP.CrearParametro("unNombre")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
            .SetValor(usuario.Nombre)
            .AgregarParametro();

            BP.CrearParametro("unApellido")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
            .SetValor(usuario.Apellido)
            .AgregarParametro();

            BP.CrearParametro("unaContrasenia")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
            .SetValor(usuario.Contrasenia)
            .AgregarParametro();

            BP.CrearParametro("unEmail")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
            .SetValor(usuario.Email)
            .AgregarParametro();

        }
        public void postAltaUsuario(Usuario usuario)
        {
            var paramiUsuario = GetParametro("unidUsuario");
            usuario.IdUsuario = Convert.ToUInt32(paramiUsuario.Value);
        }
        public List<Usuario> ObtenerUsuarios() => ColeccionDesdeTabla();

    }

}

