namespace Tela_inicial
{
    partial class TelaFinal
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
            this.btnJogardenovo = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.txtmensagemfinal = new System.Windows.Forms.TextBox();
            this.txtpontuacaofinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJogardenovo
            // 
            this.btnJogardenovo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJogardenovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogardenovo.Location = new System.Drawing.Point(72, 204);
            this.btnJogardenovo.Name = "btnJogardenovo";
            this.btnJogardenovo.Size = new System.Drawing.Size(183, 54);
            this.btnJogardenovo.TabIndex = 8;
            this.btnJogardenovo.Text = "Jogar de Novo";
            this.btnJogardenovo.UseVisualStyleBackColor = false;
            this.btnJogardenovo.Click += new System.EventHandler(this.btnJogardenovo_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(327, 204);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(145, 54);
            this.btnEncerrar.TabIndex = 9;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // txtmensagemfinal
            // 
            this.txtmensagemfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmensagemfinal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtmensagemfinal.Location = new System.Drawing.Point(130, 24);
            this.txtmensagemfinal.Multiline = true;
            this.txtmensagemfinal.Name = "txtmensagemfinal";
            this.txtmensagemfinal.Size = new System.Drawing.Size(330, 93);
            this.txtmensagemfinal.TabIndex = 10;
            this.txtmensagemfinal.Text = "Count 4\" parabens\", \r\n3 ou 2 \"foi bem\" \r\n1 ou 0\"Precisa Estudar\" ";
            // 
            // txtpontuacaofinal
            // 
            this.txtpontuacaofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpontuacaofinal.Location = new System.Drawing.Point(130, 137);
            this.txtpontuacaofinal.Multiline = true;
            this.txtpontuacaofinal.Name = "txtpontuacaofinal";
            this.txtpontuacaofinal.Size = new System.Drawing.Size(330, 32);
            this.txtpontuacaofinal.TabIndex = 11;
            this.txtpontuacaofinal.Text = "ID_Jogador\"Sua Pontuação\" + Pontos";
            // 
            // TelaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tela_inicial.Properties.Resources.cinemapagina4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 301);
            this.Controls.Add(this.txtpontuacaofinal);
            this.Controls.Add(this.txtmensagemfinal);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnJogardenovo);
            this.Name = "TelaFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFinal";
            this.Load += new System.EventHandler(this.TelaFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogardenovo;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.TextBox txtmensagemfinal;
        private System.Windows.Forms.TextBox txtpontuacaofinal;
    }
}