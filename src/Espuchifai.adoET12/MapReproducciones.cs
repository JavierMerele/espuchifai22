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

    public void AltaReproduccion(Reproducciones reproducciones)
            => EjecutarComandoCon("altaReproduccion", AltaReproduccion, reproducciones);


    public void ConfigurarAltaReproduccion(Reproducciones reproducciones)
    {
        SetComandoSP("altaReproduccion");

        BP.CrearParametro("unaReproduccion")
        .SetTipo(MySql.Data.MySqlClient.MySqlDbType.UInt32)
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
    public void postAltaCancion(Reproducciones reproducciones)
    {
        var paramidCancion = GetParametro("unidCancion");
        reproducciones.IdCancion = Convert.ToUInt32(paramidCancion.Value);
        var paramiUsuario = GetParametro("unidUsuario");
        reproducciones.IdUsuario = Convert.ToUInt32(paramiUsuario.Value);
    }
    public List<Reproducciones> ObtenerReproducciones() => ColeccionDesdeTabla();

}
