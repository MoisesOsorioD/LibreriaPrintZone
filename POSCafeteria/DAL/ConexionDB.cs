using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.DAL
{
    public static class ConexionDB
    {
        public static string CadenaConexion = "Server=ELMK;Database=Inventario_Printzone;Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
