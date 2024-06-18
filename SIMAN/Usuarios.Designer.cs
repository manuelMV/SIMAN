namespace SIMAN
{
    partial class Usuarios
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
            txt_User = new TextBox();
            txt_Clave = new TextBox();
            btn_Atras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_tabla).BeginInit();
            SuspendLayout();
            // 
            // dgv_tabla
            // 
            dgv_tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tabla.Location = new Point(1321, 0);
            dgv_tabla.Name = "dgv_tabla";
            dgv_tabla.RowHeadersWidth = 102;
            dgv_tabla.Size = new Size(856, 1315);
            dgv_tabla.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(606, 85);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(188, 58);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(843, 85);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(188, 58);
            btn_Editar.TabIndex = 2;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(1076, 85);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(188, 58);
            btn_Aceptar.TabIndex = 3;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
//            btn_Aceptar.Click += btn_Aceptar_Click_1;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(252, 39);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(250, 47);
            txt_User.TabIndex = 4;
            // 
            // txt_Clave
            // 
            txt_Clave.Location = new Point(252, 118);
            txt_Clave.Name = "txt_Clave";
            txt_Clave.Size = new Size(250, 47);
            txt_Clave.TabIndex = 5;
            // 
            // btn_Atras
            // 
            btn_Atras.Location = new Point(268, 293);
            btn_Atras.Name = "btn_Atras";
            btn_Atras.Size = new Size(188, 58);
            btn_Atras.TabIndex = 6;
            btn_Atras.Text = "Atras";
            btn_Atras.UseVisualStyleBackColor = true;
            btn_Atras.Click += btn_Atras_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2170, 1325);
            Controls.Add(btn_Atras);
            Controls.Add(txt_Clave);
            Controls.Add(txt_User);
            Controls.Add(btn_Aceptar);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Agregar);
            Controls.Add(dgv_tabla);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_tabla;
        private Button btn_Agregar;
        private Button btn_Editar;
        private Button btn_Aceptar;
        private TextBox txt_User;
        private TextBox txt_Clave;
        private Button btn_Atras;
    }
}