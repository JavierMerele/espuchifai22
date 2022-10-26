using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System.Data;
using Espuchifai.Core;

namespace Espuchifai.AdoMySQL.Mapeadores
{
    public class MapReproduccion: Mapeador<Reproduccion>
    {
        public MapReproduccion(AdoAGBD ado):base(ado)
        {
            Tabla = "Reproduccion";
        }
        public override Reproduccion ObjetoDesdeFila(DataRow fila)
            => new Reproduccion()
            {
                idCancion = Convert.ToUInt32(fila["idCancion"]),
                idUsuario = Convert.ToUInt32(fila["idUsuario"]),
                reproduccion = Convert.ToDateTime (fila["Reproduccion"])
            };


    }
}