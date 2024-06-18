namespace SIMAN
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_clientes = new Button();
            btn_Usuario = new Button();
            btn_Productos = new Button();
            dgv_Productos = new DataGridView();
            dgv_Compra = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            btn_Agregar = new Button();
            nud_cantidad = new NumericUpDown();
            btn_Eliminar = new Button();
            btn_Facturar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Compra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
            SuspendLayout();
            // 
            // btn_clientes
            // 
            btn_clientes.Location = new Point(45, 3);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(181, 63);
            btn_clientes.TabIndex = 0;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_Usuario
            // 
            btn_Usuario.Location = new Point(250, 3);
            btn_Usuario.Name = "btn_Usuario";
            btn_Usuario.Size = new Size(164, 63);
            btn_Usuario.TabIndex = 1;
            btn_Usuario.Text = "Usuarios";
            btn_Usuario.UseVisualStyleBackColor = true;
            btn_Usuario.Click += btn_Usuario_Click;
            // 
            // btn_Productos
            // 
            btn_Productos.Location = new Point(483, 8);
            btn_Productos.Name = "btn_Productos";
            btn_Productos.Size = new Size(188, 58);
            btn_Productos.TabIndex = 2;
            btn_Productos.Text = "Productos";
            btn_Productos.UseVisualStyleBackColor = true;
            btn_Productos.Click += btn_Productos_Click;
            // 
            // dgv_Productos
            // 
            dgv_Productos.AllowUserToAddRows = false;
            dgv_Productos.AllowUserToDeleteRows = false;
            dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Productos.Location = new Point(-2, 456);
            dgv_Productos.Name = "dgv_Productos";
            dgv_Productos.ReadOnly = true;
            dgv_Productos.RowHeadersWidth = 102;
            dgv_Productos.Size = new Size(1105, 1235);
            dgv_Productos.TabIndex = 3;
            // 
            // dgv_Compra
            // 
            dgv_Compra.AllowUserToAddRows = false;
            dgv_Compra.AllowUserToDeleteRows = false;
            dgv_Compra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Compra.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Cantidad, Precio });
            dgv_Compra.Location = new Point(1503, 456);
            dgv_Compra.Name = "dgv_Compra";
            dgv_Compra.ReadOnly = true;
            dgv_Compra.RowHeadersWidth = 102;
            dgv_Compra.Size = new Size(1105, 1235);
            dgv_Compra.TabIndex = 4;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 12;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 250;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 12;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 12;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 250;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 12;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 250;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(403, 350);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(188, 58);
            btn_Agregar.TabIndex = 5;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // nud_cantidad
            // 
            nud_cantidad.Location = new Point(55, 357);
            nud_cantidad.Name = "nud_cantidad";
            nud_cantidad.Size = new Size(300, 47);
            nud_cantidad.TabIndex = 6;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(1594, 350);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(188, 58);
            btn_Eliminar.TabIndex = 7;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Facturar
            // 
            btn_Facturar.Location = new Point(1892, 350);
            btn_Facturar.Name = "btn_Facturar";
            btn_Facturar.Size = new Size(188, 58);
            btn_Facturar.TabIndex = 8;
            btn_Facturar.Text = "Facturar";
            btn_Facturar.UseVisualStyleBackColor = true;
            btn_Facturar.Click += btn_Facturar_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2609, 1696);
            Controls.Add(btn_Facturar);
            Controls.Add(btn_Eliminar);
            Controls.Add(nud_cantidad);
            Controls.Add(btn_Agregar);
            Controls.Add(dgv_Compra);
            Controls.Add(dgv_Productos);
            Controls.Add(btn_Productos);
            Controls.Add(btn_Usuario);
            Controls.Add(btn_clientes);
            Name = "Home";
            Text = "Agregar";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Compra).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_clientes;
        private Button btn_Usuario;
        private Button btn_Productos;
        private DataGridView dgv_Productos;
        private DataGridView dgv_Compra;
        private Button btn_Agregar;
        private NumericUpDown nud_cantidad;
        private Button btn_Eliminar;
        private Button btn_Facturar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
    }
}