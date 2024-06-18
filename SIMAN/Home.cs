using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMAN
{
    public partial class Home : Form
    {
        Consultas consultas = new Consultas();
        string _consulta = "";
        string tbl = "";
        public Home()
        {
            InitializeComponent();
            tbl = "tbl_productos";
            dgv_Productos.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes abrirClientes = new Clientes();
            abrirClientes.Show();
            this.Hide();
        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            Usuarios abrirUsuarios = new Usuarios();
            abrirUsuarios.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Productos abrirProductos = new Productos();
            abrirProductos.Show();
            this.Hide();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            if (dgv_Productos.SelectedRows.Count > 0 && nud_cantidad.Value > 0)
            {


                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgv_Productos.SelectedRows[0];
                if (cantidad(filaSeleccionada.Cells[0].Value.ToString(), int.Parse(nud_cantidad.Value.ToString())))
                {// pasar todos los datos de la fila selecionada de dgv_Productos a dgv_Compra
                    dgv_Compra.Rows.Add(new object[] {
                    filaSeleccionada.Cells[0].Value,
                    filaSeleccionada.Cells[1].Value,
                    nud_cantidad.Value,
                    filaSeleccionada.Cells[3].Value
                });
                }
            }

        }
        public static bool cantidad(string codigo, int cantidad)
        {

            string consulta = $"SELECT * FROM tbl_productos WHERE id_productos = {codigo} AND cantidad >= {cantidad}";
            MySqlConnection miconcexcion = Conexion.sqlConnection();
            miconcexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, miconcexcion);
                cmd.ExecuteNonQuery();
                int dato = Convert.ToInt32(cmd.ExecuteScalar());
                if (dato > 0)
                {
                    return true;
                }

                MessageBox.Show(consulta);
            }
            catch
            {
                return false;
            }
            return false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Productos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_Compra.SelectedRows[0];
                dgv_Compra.Rows.Remove(filaSeleccionada);
            }
        }

        private void btn_Facturar_Click(object sender, EventArgs e)
        {
            string productos = "";
            string factura = "Factura \r\nSIMAN\r\n\r\nNombre          cantidad        precio\n";
            float total = 0;
            for (int i = 0; i < dgv_Compra.Rows.Count; i++)
            {
                total += float.Parse(dgv_Compra.Rows[i].Cells[2].Value.ToString()) * float.Parse(dgv_Compra.Rows[i].Cells[3].Value.ToString());
            }
            for (int i = 0; i < dgv_Compra.Rows.Count; i++)
            {
                productos += $"{dgv_Compra.Rows[i].Cells[1].Value.ToString()}\t\t{dgv_Compra.Rows[i].Cells[2].Value.ToString()}\t{dgv_Compra.Rows[i].Cells[3].Value.ToString()}\n";

            }
            factura += productos + $"\n\nTotal: {total}";
            for (int i = 0; i < dgv_Compra.Rows.Count; i++)
            {

                _consulta = $"UPDATE tbl_productos SET cantidad = cantidad - {dgv_Compra.Rows[i].Cells[2].Value.ToString()} WHERE id_productos = {dgv_Compra.Rows[i].Cells[0].Value.ToString()} AND cantidad > 0;";
                consultas.Query(tbl, _consulta);
            }
            MessageBox.Show(factura);
            dgv_Compra.Rows.Clear();
            dgv_Productos.DataSource = consultas.ActualizarTabla(tbl);

        }
    }
}

