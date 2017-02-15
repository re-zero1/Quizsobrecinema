namespace Tela_inicial
{
    partial class Instrucoes
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
            this.lblinstrução = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinstrução
            // 
            this.lblinstrução.AutoSize = true;
            this.lblinstrução.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinstrução.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstrução.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblinstrução.Location = new System.Drawing.Point(86, 22);
            this.lblinstrução.Name = "lblinstrução";
            this.lblinstrução.Size = new System.Drawing.Size(118, 18);
            this.lblinstrução.TabIndex = 0;
            this.lblinstrução.Text = "qualquer coisa";
            this.lblinstrução.Click += new System.EventHandler(this.lblinstrução_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImage = global::Tela_inicial.Properties.Resources.cinemapagina2;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(153, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok, Vamos la";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Instrucoes
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Tela_inicial.Properties.Resources.cinemapagina2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblinstrução);
            this.Name = "Instrucoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrucoes";
            this.Load += new System.EventHandler(this.Instrucoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinstrução;
        private System.Windows.Forms.Button button1;
    }
}