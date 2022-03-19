namespace cliente
{
    partial class Form1
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
            this.entrar = new System.Windows.Forms.Button();
            this.registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usuario_consulta = new System.Windows.Forms.TextBox();
            this.partidas_ganadas = new System.Windows.Forms.RadioButton();
            this.tablones = new System.Windows.Forms.RadioButton();
            this.id_usuario = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(441, 83);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(132, 46);
            this.entrar.TabIndex = 0;
            this.entrar.Text = "Entra!";
            this.entrar.UseVisualStyleBackColor = true;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(217, 259);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(144, 41);
            this.registrar.TabIndex = 1;
            this.registrar.Text = "Registrate";
            this.registrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(198, 66);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(207, 27);
            this.usuario.TabIndex = 4;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(198, 124);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(207, 27);
            this.contraseña.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "¿No tienes una cuenta en el juego? Únete a nuestra comunidad!";
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(893, 310);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(158, 29);
            this.enviar.TabIndex = 7;
            this.enviar.Text = "Enviar Consulta";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(759, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Indroduce el nombre de usuario del jugador para hacer la consulta:";
            // 
            // usuario_consulta
            // 
            this.usuario_consulta.Location = new System.Drawing.Point(912, 102);
            this.usuario_consulta.Name = "usuario_consulta";
            this.usuario_consulta.Size = new System.Drawing.Size(125, 27);
            this.usuario_consulta.TabIndex = 12;
            // 
            // partidas_ganadas
            // 
            this.partidas_ganadas.AutoSize = true;
            this.partidas_ganadas.Location = new System.Drawing.Point(866, 202);
            this.partidas_ganadas.Name = "partidas_ganadas";
            this.partidas_ganadas.Size = new System.Drawing.Size(223, 24);
            this.partidas_ganadas.TabIndex = 13;
            this.partidas_ganadas.TabStop = true;
            this.partidas_ganadas.Text = "Número de partidas ganadas";
            this.partidas_ganadas.UseVisualStyleBackColor = true;
            // 
            // tablones
            // 
            this.tablones.AutoSize = true;
            this.tablones.Location = new System.Drawing.Point(866, 232);
            this.tablones.Name = "tablones";
            this.tablones.Size = new System.Drawing.Size(231, 24);
            this.tablones.TabIndex = 14;
            this.tablones.TabStop = true;
            this.tablones.Text = "Tablones en los que ha jugado";
            this.tablones.UseVisualStyleBackColor = true;
            // 
            // id_usuario
            // 
            this.id_usuario.AutoSize = true;
            this.id_usuario.Location = new System.Drawing.Point(866, 263);
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.Size = new System.Drawing.Size(126, 24);
            this.id_usuario.TabIndex = 15;
            this.id_usuario.TabStop = true;
            this.id_usuario.Text = "ID del jugador";
            this.id_usuario.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Escoge una de las opciones y envia tu consulta!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_usuario);
            this.Controls.Add(this.tablones);
            this.Controls.Add(this.partidas_ganadas);
            this.Controls.Add(this.usuario_consulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.entrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button entrar;
        private Button registrar;
        private Label label1;
        private Label label2;
        private TextBox usuario;
        private TextBox contraseña;
        private Label label3;
        private Button enviar;
        private Label label4;
        private TextBox usuario_consulta;
        private RadioButton partidas_ganadas;
        private RadioButton tablones;
        private RadioButton id_usuario;
        private Label label5;
    }
}