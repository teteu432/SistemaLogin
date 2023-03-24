namespace SistemaLogin
{
    partial class Tcadastro
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalvarC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.VoltarInicio = new System.Windows.Forms.Button();
            this.ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um nome de usuario";
            // 
            // SalvarC
            // 
            this.SalvarC.Location = new System.Drawing.Point(147, 147);
            this.SalvarC.Name = "SalvarC";
            this.SalvarC.Size = new System.Drawing.Size(75, 23);
            this.SalvarC.TabIndex = 2;
            this.SalvarC.Text = "Salvar";
            this.SalvarC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite uma senha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // VoltarInicio
            // 
            this.VoltarInicio.Location = new System.Drawing.Point(147, 194);
            this.VoltarInicio.Name = "VoltarInicio";
            this.VoltarInicio.Size = new System.Drawing.Size(75, 23);
            this.VoltarInicio.TabIndex = 5;
            this.VoltarInicio.Text = "Voltar";
            this.VoltarInicio.UseVisualStyleBackColor = true;
            this.VoltarInicio.Click += new System.EventHandler(this.VoltarInicio_Click);
            // 
            // ConfirmarSenha
            // 
            this.ConfirmarSenha.Location = new System.Drawing.Point(147, 112);
            this.ConfirmarSenha.Name = "ConfirmarSenha";
            this.ConfirmarSenha.Size = new System.Drawing.Size(100, 20);
            this.ConfirmarSenha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirmar Senha";
            // 
            // Tcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmarSenha);
            this.Controls.Add(this.VoltarInicio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalvarC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Tcadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tcadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalvarC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button VoltarInicio;
        private System.Windows.Forms.TextBox ConfirmarSenha;
        private System.Windows.Forms.Label label3;
    }
}