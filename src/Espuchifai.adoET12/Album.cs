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
                idAlbum = Convert.ToInt32(fila["idAlbum"]),
                cantidad = fila["Cantidad"].ToInt32(),
                idBanda = Convert.ToInt32 (fila["idBanda"]),
                lanzamiento = Convert.ToDateTime (fila["Lanzamiento"]),
                nombre = Convert.ToString (fila["Nombre"])
            };


    }
}