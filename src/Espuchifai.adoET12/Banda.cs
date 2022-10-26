using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System.Data;
using Espuchifai.Core;

namespace Espuchifai.AdoMySQL.Mapeadores
{
    public class MapBanda: Mapeador<Banda>
    {
        public MapBanda(AdoAGBD ado):base(ado)
        {
            Tabla = "Banda";
        }
        public override Banda ObjetoDesdeFila(DataRow fila)
            => new Banda()
            {
                idBanda = Convert.ToUInt32(fila["idUsuario"]),
                nombre = fila["nombre"].ToString(),
                fundacion = Convert.ToDateTime (fila["Fundacion"])
            };


    }
}

    