namespace VitaHealth
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
            this.Titulo = new System.Windows.Forms.Label();
            this.InputSenha = new System.Windows.Forms.TextBox();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LabelResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Titulo.Location = new System.Drawing.Point(224, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(84, 37);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Login";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputSenha
            // 
            this.InputSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InputSenha.Location = new System.Drawing.Point(159, 199);
            this.InputSenha.Name = "InputSenha";
            this.InputSenha.PasswordChar = '*';
            this.InputSenha.Size = new System.Drawing.Size(188, 23);
            this.InputSenha.TabIndex = 1;
            this.InputSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSenha.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.LabelSenha.Location = new System.Drawing.Point(159, 175);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(53, 21);
            this.LabelSenha.TabIndex = 2;
            this.LabelSenha.Text = "Senha";
            this.LabelSenha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelEmail.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.LabelEmail.Location = new System.Drawing.Point(159, 79);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(48, 21);
            this.LabelEmail.TabIndex = 3;
            this.LabelEmail.Text = "Email";
            this.LabelEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // InputEmail
            // 
            this.InputEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InputEmail.Location = new System.Drawing.Point(159, 103);
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(188, 23);
            this.InputEmail.TabIndex = 4;
            this.InputEmail.TextChanged += new System.EventHandler(this.InputEmail_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(209, 269);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(99, 51);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Logar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelResposta
            // 
            this.LabelResposta.AutoSize = true;
            this.LabelResposta.Location = new System.Drawing.Point(12, 335);
            this.LabelResposta.Name = "LabelResposta";
            this.LabelResposta.Size = new System.Drawing.Size(0, 15);
            this.LabelResposta.TabIndex = 6;
            this.LabelResposta.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 378);
            this.Controls.Add(this.LabelResposta);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.InputEmail);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.InputSenha);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox InputSenha;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LabelResposta;
    }
}
