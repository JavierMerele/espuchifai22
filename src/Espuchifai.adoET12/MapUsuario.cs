using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System.Data;
using Espuchifai.Core;

namespace Espuchifai.AdoMySQL.Mapeadores
{
    public class MapUsuario: Mapeador<Usuario>
    {
        public MapUsuario(AdoAGBD ado):base(ado)
        {
            Tabla = "Usuario";
        }
        public override Usuario ObjetoDesdeFila(DataRow fila)
            => new Usuario()
            {
                idUsuario = Convert.ToUInt32(fila["idUsuario"]),
                nombre = fila["nombre"].ToString(),
                apellido= fila["apellido"].ToString(),
                contrasenia= fila["contrasenia"].ToString(),
                email= fila["email"].ToString()
            };


    }
}

    