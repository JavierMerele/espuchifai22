


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
                idCancion = Convert.ToUInt32(fila["idCancion"]),
                nombre = fila["nombre"].ToString(),
                orden = Convert.ToUInt32(fila["Orden"]),
                cantidad = Convert.ToUInt32(fila["Cantidad"]),
                idAlbum = Convert.ToUInt32(fila["idAlbum"])
            };


    }
}

    