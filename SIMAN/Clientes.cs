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
    public partial class Clientes : Form
    {
        string tbl = "tbl_cliente";
        string _consulta = "";
        Consultas consultas = new Consultas();
        public Clientes()
        {
            InitializeComponent();
            dgv_tabla.DataSource = consultas.ActualizarTabla(tbl);
            btn_Aceptar.Visible = false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            //llenar las texbox con datos del dgv_clientes
            txt_Nombre.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
            txt_Apellido.Text = dgv_tabla.CurrentRow.Cells[2].Value.ToString();
            txt_Direccion.Text = dgv_tabla.CurrentRow.Cells[3].Value.ToString();
            mtxt_Telefono.Text = dgv_tabla.CurrentRow.Cells[4].Value.ToString();
            btn_Agregar.Enabled = false;
            btn_Aceptar.Visible = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            _consulta = $"UPDATE {tbl} SET nombre = '{txt_Nombre.Text}', apellido = '{txt_Apellido.Text}', direccion = '{txt_Direccion.Text}', telefono = '{mtxt_Telefono.Text}' WHERE id_cliente = '{dgv_tabla.CurrentRow.Cells[0].Value.ToString()}'";
            consultas.Query(tbl, _consulta);
            dgv_tabla.DataSource = consultas.ActualizarTabla(tbl);
            btn_Agregar.Enabled = true;
            btn_Aceptar.Visible = false;

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            _consulta = $"DELETE FROM {tbl} WHERE id_cliente = '{dgv_tabla.CurrentRow.Cells[0].Value.ToString()}'";
            consultas.Query(tbl, _consulta);
            dgv_tabla.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            _consulta = $"INSERT INTO {tbl} VALUES (not null, '{txt_Nombre.Text}','{txt_Apellido.Text}','{txt_Direccion.Text}','{mtxt_Telefono.Text}')";
            consultas.Query(tbl, _consulta);
            dgv_tabla.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            Home abrirHome = new Home();
            abrirHome.Show();
            this.Hide();
        }
    }
}
