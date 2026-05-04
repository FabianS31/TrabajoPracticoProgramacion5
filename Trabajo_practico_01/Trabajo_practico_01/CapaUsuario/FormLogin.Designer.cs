namespace Trabajo_practico_01
{
    partial class FormLogin
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
            usuario = new Label();
            contraseña = new Label();
            usuario_texto = new TextBox();
            usuario_contraseña = new TextBox();
            boton_aceptar = new Button();
            boton_cancelar = new Button();
            Texto_presentacion = new Label();
            label4 = new Label();
            usuario_nuevo = new CheckBox();
            SuspendLayout();
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Location = new Point(36, 68);
            usuario.Margin = new Padding(2, 0, 2, 0);
            usuario.Name = "usuario";
            usuario.Size = new Size(47, 15);
            usuario.TabIndex = 1;
            usuario.Text = "Usuario";
            usuario.Click += label1_Click;
            // 
            // contraseña
            // 
            contraseña.AutoSize = true;
            contraseña.Location = new Point(36, 119);
            contraseña.Margin = new Padding(2, 0, 2, 0);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(67, 15);
            contraseña.TabIndex = 2;
            contraseña.Text = "Contraseña";
            contraseña.Click += label2_Click;
            // 
            // usuario_texto
            // 
            usuario_texto.Location = new Point(36, 85);
            usuario_texto.Margin = new Padding(2);
            usuario_texto.Name = "usuario_texto";
            usuario_texto.Size = new Size(185, 23);
            usuario_texto.TabIndex = 3;
            // 
            // usuario_contraseña
            // 
            usuario_contraseña.Location = new Point(36, 136);
            usuario_contraseña.Margin = new Padding(2);
            usuario_contraseña.Name = "usuario_contraseña";
            usuario_contraseña.PasswordChar = '*';
            usuario_contraseña.Size = new Size(185, 23);
            usuario_contraseña.TabIndex = 4;
            // 
            // boton_aceptar
            // 
            boton_aceptar.Location = new Point(137, 226);
            boton_aceptar.Margin = new Padding(2);
            boton_aceptar.Name = "boton_aceptar";
            boton_aceptar.Size = new Size(82, 23);
            boton_aceptar.TabIndex = 5;
            boton_aceptar.Text = "Aceptar";
            boton_aceptar.UseVisualStyleBackColor = true;
            boton_aceptar.Click += boton_aceptar_Click;
            // 
            // boton_cancelar
            // 
            boton_cancelar.Location = new Point(238, 226);
            boton_cancelar.Margin = new Padding(2);
            boton_cancelar.Name = "boton_cancelar";
            boton_cancelar.Size = new Size(82, 23);
            boton_cancelar.TabIndex = 6;
            boton_cancelar.Text = "Cancelar";
            boton_cancelar.UseVisualStyleBackColor = true;
            // 
            // Texto_presentacion
            // 
            Texto_presentacion.AutoSize = true;
            Texto_presentacion.Location = new Point(36, 28);
            Texto_presentacion.Margin = new Padding(2, 0, 2, 0);
            Texto_presentacion.Name = "Texto_presentacion";
            Texto_presentacion.Size = new Size(273, 15);
            Texto_presentacion.TabIndex = 7;
            Texto_presentacion.Text = "Bienvenidos a EduGes, inicie sesión para comenzar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 172);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // usuario_nuevo
            // 
            usuario_nuevo.AutoSize = true;
            usuario_nuevo.Location = new Point(40, 174);
            usuario_nuevo.Margin = new Padding(2);
            usuario_nuevo.Name = "usuario_nuevo";
            usuario_nuevo.Size = new Size(96, 19);
            usuario_nuevo.TabIndex = 9;
            usuario_nuevo.Text = "Crear usuario";
            usuario_nuevo.UseVisualStyleBackColor = true;
            usuario_nuevo.CheckedChanged += usuario_nuevo_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 270);
            Controls.Add(usuario_nuevo);
            Controls.Add(label4);
            Controls.Add(Texto_presentacion);
            Controls.Add(boton_cancelar);
            Controls.Add(boton_aceptar);
            Controls.Add(usuario_contraseña);
            Controls.Add(usuario_texto);
            Controls.Add(contraseña);
            Controls.Add(usuario);
            Margin = new Padding(2);
            Name = "FormLogin";
            Text = "Eduges";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label usuario;
        private Label contraseña;
        private TextBox usuario_texto;
        private TextBox usuario_contraseña;
        private Button boton_aceptar;
        private Button boton_cancelar;
        private Label Texto_presentacion;
        private Label label4;
        private CheckBox usuario_nuevo;
    }
}
