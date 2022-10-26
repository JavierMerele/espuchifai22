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
    public void AltaBanda(Banda banda)
            => EjecutarComandoCon("altaBanda", AltaBanda ,postAltaBanda, banda);

        public void ConfigurarAltaBanda(Banda banda)
        {
            SetComandoSP("altaBanda");

            BP.CrearParametroSalida("unidBanda")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
            .AgregarParametro();

            BP.CrearParametro("unnombre")
            .SetTipoVarchar(45)
            .SetValor(banda.nombre)
            .AgregarParametro();

            BP.CrearParametro("unafundacion")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.DateTime)
            .SetValor(banda.fundacion)
            .AgregarParametro();
        }
        public void postAltaBanda(Banda banda)
        {
            var paramidBanda = GetParametro("unidBanda");
            banda.idBanda = Convert.ToUInt32(paramidBanda.Value);
        }

        public Banda BandaPorId(byte id)
        {
            SetComandoSP("BandaPorId");

            BP.CrearParametro("unIdBanda")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.Byte)
            .SetValor(id)
            .AgregarParametro();

            return ElementoDesdeSP();
        }

        public List<Banda> ObtenerBandas() => ColeccionDesdeTabla();




        }

        
    }