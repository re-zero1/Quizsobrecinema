namespace Tela_inicial
{
    partial class Pergunta1
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
            this.lblpergunta1 = new System.Windows.Forms.Label();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.btnProxima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpergunta1
            // 
            this.lblpergunta1.AutoSize = true;
            this.lblpergunta1.BackColor = System.Drawing.Color.Red;
            this.lblpergunta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpergunta1.Location = new System.Drawing.Point(110, 25);
            this.lblpergunta1.Name = "lblpergunta1";
            this.lblpergunta1.Size = new System.Drawing.Size(359, 40);
            this.lblpergunta1.TabIndex = 0;
            this.lblpergunta1.Text = "Qual nome do filme em que, \r\no protagonista vai fazer Estagio No Google ";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb1.Location = new System.Drawing.Point(105, 119);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(118, 22);
            this.rdb1.TabIndex = 1;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Harry Potter";
            this.rdb1.UseVisualStyleBackColor = false;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb2.Location = new System.Drawing.Point(105, 161);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(198, 22);
            this.rdb2.TabIndex = 2;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Estagiarios Do Google";
            this.rdb2.UseVisualStyleBackColor = false;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb3.Location = new System.Drawing.Point(105, 203);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(200, 22);
            this.rdb3.TabIndex = 3;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "Correndo pela sua vida";
            this.rdb3.UseVisualStyleBackColor = false;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb4.Location = new System.Drawing.Point(105, 249);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(125, 22);
            this.rdb4.TabIndex = 4;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "American Pai";
            this.rdb4.UseVisualStyleBackColor = false;
            // 
            // btnProxima
            // 
            this.btnProxima.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxima.Location = new System.Drawing.Point(418, 249);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(145, 54);
            this.btnProxima.TabIndex = 5;
            this.btnProxima.Text = "Proxima";
            this.btnProxima.UseVisualStyleBackColor = false;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // Pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tela_inicial.Properties.Resources.cinemapagina3;
            this.ClientSize = new System.Drawing.Size(585, 304);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.lblpergunta1);
            this.Name = "Pergunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta1";
            this.Load += new System.EventHandler(this.Pergunta1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpergunta1;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.Button btnProxima;
    }
}