using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System.Data;
using Espuchifai.Core;

namespace Espuchifai.AdoMySQL.Mapeadores;
public class MapReproducciones : Mapeador<Reproducciones>
{
    public MapReproducciones(AdoAGBD ado) : base(ado)
    {
        Tabla = "Reproducciones";
    }
    public override Reproducciones ObjetoDesdeFila(DataRow fila)
        => new Reproducciones
        (
            idCancion: Convert.ToUInt32(fila["idCancion"]),
            idUsuario: Convert.ToUInt32(fila["idUsuario"]),
            reproduccion: Convert.ToDateTime(fila["Reproduccion"])
        );

    public void Reproducir(Reproducciones reproducciones)
            => EjecutarComandoCon("reproducir", ConfigurarReproducir, reproducciones);


    public void ConfigurarReproducir(Reproducciones reproducciones)
    {
        SetComandoSP("reproducir");

        BP.CrearParametroSalida("unaReproduccion")
        .SetTipo(MySql.Data.MySqlClient.MySqlDbType.DateTime)
        .AgregarParametro();

        BP.CrearParametro("unidUsuario")
        .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
        .SetValor(reproducciones.IdUsuario)
        .AgregarParametro();

        BP.CrearParametro("unidCancion")
        .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
        .SetValor(reproducciones.IdCancion)
        .AgregarParametro();

    }
    public List<Reproducciones> ObtenerReproducciones() => ColeccionDesdeTabla();

}
