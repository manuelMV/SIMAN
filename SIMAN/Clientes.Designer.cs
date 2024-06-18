namespace SIMAN
{
    partial class Clientes
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
            dgv_tabla = new DataGridView();
            btn_Editar = new Button();
            btn_Aceptar = new Button();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Direccion = new TextBox();
            mtxt_Telefono = new MaskedTextBox();
            btn_Agregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_Atras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_tabla).BeginInit();
            SuspendLayout();
            // 
            // dgv_tabla
            // 
            dgv_tabla.AllowUserToAddRows = false;
            dgv_tabla.AllowUserToDeleteRows = false;
            dgv_tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tabla.Location = new Point(770, -1);
            dgv_tabla.Name = "dgv_tabla";
            dgv_tabla.ReadOnly = true;
            dgv_tabla.RowHeadersWidth = 102;
            dgv_tabla.Size = new Size(1400, 1400);
            dgv_tabla.TabIndex = 0;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(551, 131);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(188, 58);
            btn_Editar.TabIndex = 1;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(551, 210);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(188, 58);
            btn_Aceptar.TabIndex = 2;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_aceptar_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(222, 31);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(250, 47);
            txt_Nombre.TabIndex = 3;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(222, 93);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(250, 47);
            txt_Apellido.TabIndex = 4;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(222, 169);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(250, 47);
            txt_Direccion.TabIndex = 5;
            // 
            // mtxt_Telefono
            // 
            mtxt_Telefono.Location = new Point(222, 237);
            mtxt_Telefono.Mask = "0000-0000";
            mtxt_Telefono.Name = "mtxt_Telefono";
            mtxt_Telefono.Size = new Size(250, 47);
            mtxt_Telefono.TabIndex = 6;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(551, 42);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(188, 58);
            btn_Agregar.TabIndex = 7;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 34);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 93);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 169);
            label3.Name = "label3";
            label3.Size = new Size(143, 41);
            label3.TabIndex = 10;
            label3.Text = "DIreccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 237);
            label4.Name = "label4";
            label4.Size = new Size(155, 41);
            label4.TabIndex = 11;
            label4.Text = "Teleléfono";
            // 
            // btn_Atras
            // 
            btn_Atras.Location = new Point(242, 346);
            btn_Atras.Name = "btn_Atras";
            btn_Atras.Size = new Size(188, 58);
            btn_Atras.TabIndex = 12;
            btn_Atras.Text = "Atras";
            btn_Atras.UseVisualStyleBackColor = true;
            btn_Atras.Click += btn_Atras_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2170, 1401);
            Controls.Add(btn_Atras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Agregar);
            Controls.Add(mtxt_Telefono);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(btn_Aceptar);
            Controls.Add(btn_Editar);
            Controls.Add(dgv_tabla);
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgv_tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_tabla;
        private Button btn_Editar;
        private Button btn_Aceptar;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Direccion;
        private MaskedTextBox mtxt_Telefono;
        private Button btn_Agregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_Atras;
    }
}