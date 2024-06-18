﻿using System;
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
    public partial class Productos : Form
    {

        string tbl = "tbl_productos";
        string _consulta = "";
        Consultas consultas = new Consultas();
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            //llenar las texbox con datos del dgv_clientes
            txt_nombre.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
            txt_cantidad.Text = dgv_tabla.CurrentRow.Cells[2].Value.ToString();
            txt_precio.Text = dgv_tabla.CurrentRow.Cells[3].Value.ToString();
            btn_Agregar.Enabled = false;
            btn_Aceptar.Visible = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            _consulta = $"UPDATE {tbl} SET nombre = '{txt_nombre.Text}', cantidad = '{int.Parse(txt_cantidad.Text)}', precio = {decimal.Parse(txt_precio.Text)} WHERE id_producto  = '{dgv_tabla.CurrentRow.Cells[0].Value.ToString()}'";
            consultas.Query(tbl, _consulta);
            dgv_tabla.DataSource = consultas.ActualizarTabla(tbl);
            btn_Agregar.Enabled = true;
            btn_Aceptar.Visible = false;

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            _consulta = $"DELETE FROM {tbl} WHERE id_producto = '{dgv_tabla.CurrentRow.Cells[0].Value.ToString()}'";
            consultas.Query(tbl, _consulta);
            dgv_tabla.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            _consulta = $"INSERT INTO {tbl} VALUES (not null, '{txt_nombre.Text}',{int.Parse(txt_cantidad.Text)},{decimal.Parse(txt_precio.Text)})";
            consultas.Query(tbl, _consulta);
            dgv_tabla.DataSource = consultas.ActualizarTabla(tbl);
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            Home abrirHome = new Home();
            abrirHome.Show();
            this.Close();
        }
    }
}
