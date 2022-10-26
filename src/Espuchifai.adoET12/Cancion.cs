


using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System.Data;
using Espuchifai.Core;

namespace Espuchifai.AdoMySQL.Mapeadores
{
    public class MapCancion: Mapeador<Cancion>
    {
        public MapCancion(AdoAGBD ado):base(ado)
        {
            Tabla = "Cancion";
        }
        public override Cancion ObjetoDesdeFila(DataRow fila)
            => new Cancion()
            {
                idCancion = Convert.ToInt32(fila["idUsuario"]),
                nombre = fila["nombre"].ToString(),
                orden = Convert.ToInt32(fila["Orden"]),
                cantidad = Convert.ToInt32(fila["Cantidad"]),
                idAlbum = Convert.ToInt32(fila["idAlbum"])
            };


    }
}

    