namespace SIMAN
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_usuario = new TextBox();
            txt_clave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(278, 35);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(217, 47);
            txt_usuario.TabIndex = 0;
            txt_usuario.Text = "paiz";
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(285, 97);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(231, 47);
            txt_clave.TabIndex = 1;
            txt_clave.Text = "1234";
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 44);
            label1.Name = "label1";
            label1.Size = new Size(115, 41);
            label1.TabIndex = 2;
            label1.Text = "usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 134);
            label2.Name = "label2";
            label2.Size = new Size(84, 41);
            label2.TabIndex = 3;
            label2.Text = "clave";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(285, 216);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(165, 97);
            btn_login.TabIndex = 4;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_clave);
            Controls.Add(txt_usuario);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private TextBox txt_clave;
        private Label label1;
        private Label label2;
        private Button btn_login;
    }
}
