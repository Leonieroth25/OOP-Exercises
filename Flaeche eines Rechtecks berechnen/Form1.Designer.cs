namespace Flaeche_eines_Rechtecks_berechnen
{
    partial class Form1
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
            this.lblBreite = new System.Windows.Forms.Label();
            this.lblHoehe = new System.Windows.Forms.Label();
            this.txtBreite = new System.Windows.Forms.TextBox();
            this.txtHoehe = new System.Windows.Forms.TextBox();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBreite
            // 
            this.lblBreite.AutoSize = true;
            this.lblBreite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblBreite.Location = new System.Drawing.Point(50, 83);
            this.lblBreite.Name = "lblBreite";
            this.lblBreite.Size = new System.Drawing.Size(142, 17);
            this.lblBreite.TabIndex = 0;
            this.lblBreite.Text = "Breite des Rechtecks";
            // 
            // lblHoehe
            // 
            this.lblHoehe.AutoSize = true;
            this.lblHoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblHoehe.Location = new System.Drawing.Point(50, 131);
            this.lblHoehe.Name = "lblHoehe";
            this.lblHoehe.Size = new System.Drawing.Size(139, 17);
            this.lblHoehe.TabIndex = 1;
            this.lblHoehe.Text = "Höhe des Rechtecks";
            // 
            // txtBreite
            // 
            this.txtBreite.Location = new System.Drawing.Point(240, 80);
            this.txtBreite.Name = "txtBreite";
            this.txtBreite.Size = new System.Drawing.Size(100, 20);
            this.txtBreite.TabIndex = 2;
            // 
            // txtHoehe
            // 
            this.txtHoehe.Location = new System.Drawing.Point(240, 128);
            this.txtHoehe.Name = "txtHoehe";
            this.txtHoehe.Size = new System.Drawing.Size(100, 20);
            this.txtHoehe.TabIndex = 3;
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAusgabe.Location = new System.Drawing.Point(50, 237);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(120, 17);
            this.lblAusgabe.TabIndex = 4;
            this.lblAusgabe.Text = "Ausgabe (Fläche)";
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(240, 234);
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabe.TabIndex = 5;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBerechnen.Location = new System.Drawing.Point(484, 109);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(86, 39);
            this.btnBerechnen.TabIndex = 6;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBeenden.Location = new System.Drawing.Point(484, 215);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(86, 39);
            this.btnBeenden.TabIndex = 7;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 362);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.txtHoehe);
            this.Controls.Add(this.txtBreite);
            this.Controls.Add(this.lblHoehe);
            this.Controls.Add(this.lblBreite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBreite;
        private System.Windows.Forms.Label lblHoehe;
        private System.Windows.Forms.TextBox txtBreite;
        private System.Windows.Forms.TextBox txtHoehe;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnBeenden;
    }
}

