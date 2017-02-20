namespace Tela_inicial
{
    partial class Paginainicial
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
            this.lblQuiz = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnComeca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuiz
            // 
            this.lblQuiz.AutoSize = true;
            this.lblQuiz.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQuiz.Location = new System.Drawing.Point(206, 9);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(97, 37);
            this.lblQuiz.TabIndex = 30;
            this.lblQuiz.Text = "QUIZ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblNome.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.Location = new System.Drawing.Point(26, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(94, 32);
            this.lblNome.TabIndex = 31;
            this.lblNome.Text = "NOME";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblSobrenome.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSobrenome.Location = new System.Drawing.Point(26, 127);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(139, 32);
            this.lblSobrenome.TabIndex = 32;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(26, 172);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 32);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(197, 81);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 32);
            this.txtNome.TabIndex = 34;
            this.txtNome.Text = "Digite seu nome";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(197, 127);
            this.txtSobrenome.Multiline = true;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(254, 32);
            this.txtSobrenome.TabIndex = 35;
            this.txtSobrenome.Text = "Digite seu Sobrenome";
            this.txtSobrenome.Enter += new System.EventHandler(this.txtSobrenome_Enter);
            this.txtSobrenome.Leave += new System.EventHandler(this.txtSobrenome_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(197, 172);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 32);
            this.txtEmail.TabIndex = 36;
            this.txtEmail.Text = "Digite seu Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnComeca
            // 
            this.btnComeca.BackColor = System.Drawing.SystemColors.Info;
            this.btnComeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComeca.Location = new System.Drawing.Point(176, 232);
            this.btnComeca.Name = "btnComeca";
            this.btnComeca.Size = new System.Drawing.Size(188, 65);
            this.btnComeca.TabIndex = 37;
            this.btnComeca.Text = "Começar";
            this.btnComeca.UseVisualStyleBackColor = false;
            this.btnComeca.Click += new System.EventHandler(this.btnComeca_Click);
            // 
            // Paginainicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tela_inicial.Properties.Resources.cinemainicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.ControlBox = false;
            this.Controls.Add(this.btnComeca);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblQuiz);
            this.Name = "Paginainicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paginainicial";
            this.Load += new System.EventHandler(this.Paginainicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblQuiz;
        internal System.Windows.Forms.Label lblNome;
        internal System.Windows.Forms.Label lblSobrenome;
        internal System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnComeca;
    }
}

