using System.Data;
using Espuchifai.Core;
using et12.edu.ar.AGBD.Ado;
using et12.edu.ar.AGBD.Mapeadores;

namespace Espuchifai.AdoMySQL.Mapeadores
{
    public class MapCancion : Mapeador<Cancion>
    {
        public MapCancion(AdoAGBD ado) : base(ado)
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

        public void AltaCancion(Cancion cancion)
            => EjecutarComandoCon("altaCancion", AltaCancion, postAltaCancion, cancion);

        public void ConfigurarAltaCancion(Cancion cancion)
        {
            SetComandoSP("altaCancion");

            BP.CrearParametroSalida("unidCancion")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
            .AgregarParametro();

            BP.CrearParametro("unidAlbum")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
            .SetValor(cancion.idAlbum)
            .AgregarParametro();

            BP.CrearParametro("unnombre")
            .SetTipoVarchar(45)
            .SetValor(cancion.nombre)
            .AgregarParametro();

            BP.CrearParametro("unorden")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
            .SetValor(cancion.orden)
            .AgregarParametro();

        }
        public void postAltaCancion(Cancion cancion)
        {
            var paramidCancion = GetParametro("unidCancion");
            cancion.idCancion = Convert.ToUInt32(paramidCancion.Value);
            var paramidAlbum = GetParametro("unidAlbum");
            cancion.idAlbum = Convert.ToUInt32(paramidAlbum.Value);
        }



    }
}

