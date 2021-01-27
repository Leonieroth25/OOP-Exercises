namespace Tannenbaum
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
            this.lblStambreite = new System.Windows.Forms.Label();
            this.lblStammhoehe = new System.Windows.Forms.Label();
            this.lblKronenhoehe = new System.Windows.Forms.Label();
            this.txtStammbreite = new System.Windows.Forms.TextBox();
            this.txtKronenhoehe = new System.Windows.Forms.TextBox();
            this.txtStammhoehe = new System.Windows.Forms.TextBox();
            this.btnTanneZeichnen = new System.Windows.Forms.Button();
            this.txtTanne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStambreite
            // 
            this.lblStambreite.AutoSize = true;
            this.lblStambreite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblStambreite.Location = new System.Drawing.Point(64, 95);
            this.lblStambreite.Name = "lblStambreite";
            this.lblStambreite.Size = new System.Drawing.Size(87, 17);
            this.lblStambreite.TabIndex = 0;
            this.lblStambreite.Text = "Stammbreite";
            // 
            // lblStammhoehe
            // 
            this.lblStammhoehe.AutoSize = true;
            this.lblStammhoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblStammhoehe.Location = new System.Drawing.Point(64, 131);
            this.lblStammhoehe.Name = "lblStammhoehe";
            this.lblStammhoehe.Size = new System.Drawing.Size(83, 17);
            this.lblStammhoehe.TabIndex = 1;
            this.lblStammhoehe.Text = "Stammhöhe";
            // 
            // lblKronenhoehe
            // 
            this.lblKronenhoehe.AutoSize = true;
            this.lblKronenhoehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblKronenhoehe.Location = new System.Drawing.Point(64, 163);
            this.lblKronenhoehe.Name = "lblKronenhoehe";
            this.lblKronenhoehe.Size = new System.Drawing.Size(86, 17);
            this.lblKronenhoehe.TabIndex = 2;
            this.lblKronenhoehe.Text = "Kronenhöhe";
            // 
            // txtStammbreite
            // 
            this.txtStammbreite.Location = new System.Drawing.Point(193, 95);
            this.txtStammbreite.Name = "txtStammbreite";
            this.txtStammbreite.Size = new System.Drawing.Size(164, 20);
            this.txtStammbreite.TabIndex = 3;
            // 
            // txtKronenhoehe
            // 
            this.txtKronenhoehe.Location = new System.Drawing.Point(193, 160);
            this.txtKronenhoehe.Name = "txtKronenhoehe";
            this.txtKronenhoehe.Size = new System.Drawing.Size(164, 20);
            this.txtKronenhoehe.TabIndex = 4;
            // 
            // txtStammhoehe
            // 
            this.txtStammhoehe.Location = new System.Drawing.Point(193, 128);
            this.txtStammhoehe.Name = "txtStammhoehe";
            this.txtStammhoehe.Size = new System.Drawing.Size(164, 20);
            this.txtStammhoehe.TabIndex = 5;
            // 
            // btnTanneZeichnen
            // 
            this.btnTanneZeichnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnTanneZeichnen.Location = new System.Drawing.Point(441, 149);
            this.btnTanneZeichnen.Name = "btnTanneZeichnen";
            this.btnTanneZeichnen.Size = new System.Drawing.Size(119, 31);
            this.btnTanneZeichnen.TabIndex = 6;
            this.btnTanneZeichnen.Text = "Tanne zeichnen";
            this.btnTanneZeichnen.UseVisualStyleBackColor = true;
            // 
            // txtTanne
            // 
            this.txtTanne.Location = new System.Drawing.Point(67, 250);
            this.txtTanne.Multiline = true;
            this.txtTanne.Name = "txtTanne";
            this.txtTanne.Size = new System.Drawing.Size(493, 402);
            this.txtTanne.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 683);
            this.Controls.Add(this.txtTanne);
            this.Controls.Add(this.btnTanneZeichnen);
            this.Controls.Add(this.txtStammhoehe);
            this.Controls.Add(this.txtKronenhoehe);
            this.Controls.Add(this.txtStammbreite);
            this.Controls.Add(this.lblKronenhoehe);
            this.Controls.Add(this.lblStammhoehe);
            this.Controls.Add(this.lblStambreite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStambreite;
        private System.Windows.Forms.Label lblStammhoehe;
        private System.Windows.Forms.Label lblKronenhoehe;
        private System.Windows.Forms.TextBox txtStammbreite;
        private System.Windows.Forms.TextBox txtKronenhoehe;
        private System.Windows.Forms.TextBox txtStammhoehe;
        private System.Windows.Forms.Button btnTanneZeichnen;
        private System.Windows.Forms.TextBox txtTanne;
    }
}

