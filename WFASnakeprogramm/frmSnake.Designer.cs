namespace WFASnakeprogramm
{
    partial class frmSnake
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbsnake = new System.Windows.Forms.PictureBox();
            this.cmdstarten = new System.Windows.Forms.Button();
            this.cmdende = new System.Windows.Forms.Button();
            this.tmschlange = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbsnake)).BeginInit();
            this.SuspendLayout();
            // 
            // pbsnake
            // 
            this.pbsnake.BackColor = System.Drawing.SystemColors.MenuText;
            this.pbsnake.Location = new System.Drawing.Point(12, 62);
            this.pbsnake.Name = "pbsnake";
            this.pbsnake.Size = new System.Drawing.Size(494, 421);
            this.pbsnake.TabIndex = 0;
            this.pbsnake.TabStop = false;
            // 
            // cmdstarten
            // 
            this.cmdstarten.ImageKey = "(Keine)";
            this.cmdstarten.Location = new System.Drawing.Point(12, 12);
            this.cmdstarten.Name = "cmdstarten";
            this.cmdstarten.Size = new System.Drawing.Size(75, 23);
            this.cmdstarten.TabIndex = 1;
            this.cmdstarten.Text = "Spielstarten";
            this.cmdstarten.UseVisualStyleBackColor = true;
            // 
            // cmdende
            // 
            this.cmdende.Location = new System.Drawing.Point(93, 12);
            this.cmdende.Name = "cmdende";
            this.cmdende.Size = new System.Drawing.Size(75, 23);
            this.cmdende.TabIndex = 2;
            this.cmdende.Text = "Spielende";
            this.cmdende.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 497);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdende);
            this.Controls.Add(this.cmdstarten);
            this.Controls.Add(this.pbsnake);
            this.KeyPreview = true;
            this.Name = "frmSnake";
            this.Text = "frmSnake";
            ((System.ComponentModel.ISupportInitialize)(this.pbsnake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbsnake;
        private System.Windows.Forms.Button cmdstarten;
        private System.Windows.Forms.Button cmdende;
        private System.Windows.Forms.Timer tmschlange;
        private System.Windows.Forms.TextBox textBox1;
    }
}

