using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System.Data;
using Espuchifai.Core;

namespace Espuchifai.AdoMySQL.Mapeadores
{
    public class MapAlbum: Mapeador<Album>
    {
        public MapAlbum(AdoAGBD ado):base(ado)
        {
            Tabla = "Album";
        }
        public override Album ObjetoDesdeFila(DataRow fila)
            => new Album()
            {
                idAlbum = Convert.ToUInt32(fila["idAlbum"]),
                cantidad = Convert.ToUInt32 (fila["Cantidad"]),
                idBanda = Convert.ToUInt32 (fila["idBanda"]),
                lanzamiento = Convert.ToDateTime (fila["Lanzamiento"]),
                nombre = Convert.ToString (fila["Nombre"])
            };


    }
}