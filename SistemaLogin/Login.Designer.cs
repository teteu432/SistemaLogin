namespace SistemaLogin
{
    partial class Login
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
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.TextBox();
            this.telaCadastro = new System.Windows.Forms.Button();
            this.VoltarInicio = new System.Windows.Forms.Button();
            this.Entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(96, 63);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(186, 29);
            this.Usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(96, 99);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(186, 31);
            this.Senha.TabIndex = 3;
            // 
            // telaCadastro
            // 
            this.telaCadastro.Location = new System.Drawing.Point(43, 223);
            this.telaCadastro.Name = "telaCadastro";
            this.telaCadastro.Size = new System.Drawing.Size(75, 23);
            this.telaCadastro.TabIndex = 4;
            this.telaCadastro.Text = "Cadastrar";
            this.telaCadastro.UseVisualStyleBackColor = true;
            this.telaCadastro.Click += new System.EventHandler(this.TelaCadastro_Click);
            // 
            // VoltarInicio
            // 
            this.VoltarInicio.Location = new System.Drawing.Point(295, 223);
            this.VoltarInicio.Name = "VoltarInicio";
            this.VoltarInicio.Size = new System.Drawing.Size(75, 23);
            this.VoltarInicio.TabIndex = 5;
            this.VoltarInicio.Text = "Voltar";
            this.VoltarInicio.UseVisualStyleBackColor = true;
            this.VoltarInicio.Click += new System.EventHandler(this.VoltarInicio_Click);
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(164, 223);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 6;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 281);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.VoltarInicio);
            this.Controls.Add(this.telaCadastro);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuario);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Button telaCadastro;
        private System.Windows.Forms.Button VoltarInicio;
        private System.Windows.Forms.Button Entrar;
    }
}