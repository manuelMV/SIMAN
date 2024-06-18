namespace SIMAN
{
    partial class Productos
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
            btn_Agregar = new Button();
            btn_Editar = new Button();
            btn_Aceptar = new Button();
            btn_Atras = new Button();
            txt_nombre = new TextBox();
            txt_cantidad = new TextBox();
            txt_precio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_tabla).BeginInit();
            SuspendLayout();
            // 
            // dgv_tabla
            // 
            dgv_tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tabla.Location = new Point(1461, 0);
            dgv_tabla.Name = "dgv_tabla";
            dgv_tabla.RowHeadersWidth = 102;
            dgv_tabla.Size = new Size(708, 1324);
            dgv_tabla.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(954, 43);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(188, 58);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(954, 125);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(188, 58);
            btn_Editar.TabIndex = 2;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(954, 207);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(188, 58);
            btn_Aceptar.TabIndex = 3;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Atras
            // 
            btn_Atras.Location = new Point(438, 474);
            btn_Atras.Name = "btn_Atras";
            btn_Atras.Size = new Size(188, 58);
            btn_Atras.TabIndex = 4;
            btn_Atras.Text = "Atras";
            btn_Atras.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(204, 111);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(250, 47);
            txt_nombre.TabIndex = 5;
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(204, 186);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(250, 47);
            txt_cantidad.TabIndex = 6;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(204, 261);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(250, 47);
            txt_precio.TabIndex = 7;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2170, 1325);
            Controls.Add(txt_precio);
            Controls.Add(txt_cantidad);
            Controls.Add(txt_nombre);
            Controls.Add(btn_Atras);
            Controls.Add(btn_Aceptar);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Agregar);
            Controls.Add(dgv_tabla);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_tabla;
        private Button btn_Agregar;
        private Button btn_Editar;
        private Button btn_Aceptar;
        private Button btn_Atras;
        private TextBox txt_nombre;
        private TextBox txt_cantidad;
        private TextBox txt_precio;
    }
}