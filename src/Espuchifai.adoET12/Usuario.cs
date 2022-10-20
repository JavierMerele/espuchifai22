using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System;
using System.Data;
using System.Collections.Generic;
using Espuchifai;
using Espuchifai.Core;

namespace Espuchifai.AdoMySQL.Mapeadores
{
    public class MapUsuario: Mapeador<Usuario>
    {
        public MapUsuario(AdoAGBD ado):base(ado)
        {
            Tabla = "Usuario";
        }
        public override Usuario ObjetoDesdeFila(DataRow fila)
            => new Usuario()
            {
                idUsuario = Convert.ToByte(fila["idUsuario"]),
                nombre = fila["nombre"].ToString(),
                apellido= fila["nombre"].ToString(),
                contrasenia= fila["nombre"].ToString(),
                email= fila["nombre"].ToString()
            };


    }
}

    