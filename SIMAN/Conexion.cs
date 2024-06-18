
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMAN
{
    internal class Conexion
    {
        

        public static MySqlConnection sqlConnection()
        {
            string servidor = "localhost";
            string bd = "SIMAN";
            string usuario = "root";
            string contraseña = "";
            string cadena = $"server={servidor}; database={bd}; Uid={usuario}; pwd={contraseña}";
            MySqlConnection miconexion = new MySqlConnection(cadena);
            return miconexion;

        }
    }

    
}
