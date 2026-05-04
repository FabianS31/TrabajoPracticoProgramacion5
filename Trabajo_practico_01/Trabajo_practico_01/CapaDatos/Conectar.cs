using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_practico_01.CapaDatos
{
    public class Conectar
    {
        private string cadenaConexion = @"Server=DESKTOP-R1CG9JF;Database=LoginDb;User Id=sa;Password=Admin123;TrustServerCertificate=True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            return conexion;
        }

    }
}
