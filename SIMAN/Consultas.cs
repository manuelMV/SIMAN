using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMAN
{
    internal class Consultas
    {
        public DataTable ActualizarTabla(string tbl)
        {
            MySqlConnection miconcexcion = Conexion.sqlConnection();
            miconcexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM {tbl}", miconcexcion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                MessageBox.Show("ERROR");
                return null;
            }
        }
        public DataTable Buscardato(string consulta)
        {
            MySqlConnection miconcexcion = Conexion.sqlConnection();
            miconcexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, miconcexcion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                MessageBox.Show("ERROR");
                return null;
            }
        }

        public void Query(string tbl, string _consulta)
        {
            MySqlConnection miconcexcion = Conexion.sqlConnection();
            miconcexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(_consulta, miconcexcion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }
        }
    }
}
