namespace Reisedauer_zum_Mond
{
    partial class ReisedauerZumMond
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
            this.rbTage = new System.Windows.Forms.RadioButton();
            this.rbStunden = new System.Windows.Forms.RadioButton();
            this.lblGeschwindigkeit = new System.Windows.Forms.Label();
            this.txtGeschwindigkeit = new System.Windows.Forms.TextBox();
            this.btnReisedauerBerechnen = new System.Windows.Forms.Button();
            this.lblAusgabeReisedauer = new System.Windows.Forms.Label();
            this.txtAusgabeReisedauer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbTage
            // 
            this.rbTage.AutoSize = true;
            this.rbTage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rbTage.Location = new System.Drawing.Point(99, 97);
            this.rbTage.Name = "rbTage";
            this.rbTage.Size = new System.Drawing.Size(82, 21);
            this.rbTage.TabIndex = 0;
            this.rbTage.TabStop = true;
            this.rbTage.Text = "in Tagen";
            this.rbTage.UseVisualStyleBackColor = true;
            this.rbTage.CheckedChanged += new System.EventHandler(this.rbTage_CheckedChanged);
            // 
            // rbStunden
            // 
            this.rbStunden.AutoSize = true;
            this.rbStunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rbStunden.Location = new System.Drawing.Point(187, 97);
            this.rbStunden.Name = "rbStunden";
            this.rbStunden.Size = new System.Drawing.Size(94, 21);
            this.rbStunden.TabIndex = 1;
            this.rbStunden.TabStop = true;
            this.rbStunden.Text = "in Stunden";
            this.rbStunden.UseVisualStyleBackColor = true;
            this.rbStunden.CheckedChanged += new System.EventHandler(this.rbStunden_CheckedChanged);
            // 
            // lblGeschwindigkeit
            // 
            this.lblGeschwindigkeit.AutoSize = true;
            this.lblGeschwindigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblGeschwindigkeit.Location = new System.Drawing.Point(96, 147);
            this.lblGeschwindigkeit.Name = "lblGeschwindigkeit";
            this.lblGeschwindigkeit.Size = new System.Drawing.Size(144, 17);
            this.lblGeschwindigkeit.TabIndex = 2;
            this.lblGeschwindigkeit.Text = "Geschwindigkeit km/h";
            // 
            // txtGeschwindigkeit
            // 
            this.txtGeschwindigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtGeschwindigkeit.Location = new System.Drawing.Point(269, 144);
            this.txtGeschwindigkeit.Name = "txtGeschwindigkeit";
            this.txtGeschwindigkeit.Size = new System.Drawing.Size(100, 20);
            this.txtGeschwindigkeit.TabIndex = 3;
            this.txtGeschwindigkeit.TextChanged += new System.EventHandler(this.txtGeschwindigkeit_TextChanged);
            // 
            // btnReisedauerBerechnen
            // 
            this.btnReisedauerBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnReisedauerBerechnen.Location = new System.Drawing.Point(99, 192);
            this.btnReisedauerBerechnen.Name = "btnReisedauerBerechnen";
            this.btnReisedauerBerechnen.Size = new System.Drawing.Size(167, 40);
            this.btnReisedauerBerechnen.TabIndex = 4;
            this.btnReisedauerBerechnen.Text = "Reisedauer berechnen";
            this.btnReisedauerBerechnen.UseVisualStyleBackColor = true;
            this.btnReisedauerBerechnen.Click += new System.EventHandler(this.btnReisedauerBerechnen_Click);
            // 
            // lblAusgabeReisedauer
            // 
            this.lblAusgabeReisedauer.AutoSize = true;
            this.lblAusgabeReisedauer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAusgabeReisedauer.Location = new System.Drawing.Point(96, 300);
            this.lblAusgabeReisedauer.Name = "lblAusgabeReisedauer";
            this.lblAusgabeReisedauer.Size = new System.Drawing.Size(141, 17);
            this.lblAusgabeReisedauer.TabIndex = 5;
            this.lblAusgabeReisedauer.Text = "Ausgabe Reisedauer";
            // 
            // txtAusgabeReisedauer
            // 
            this.txtAusgabeReisedauer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAusgabeReisedauer.Location = new System.Drawing.Point(269, 297);
            this.txtAusgabeReisedauer.Name = "txtAusgabeReisedauer";
            this.txtAusgabeReisedauer.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeReisedauer.TabIndex = 6;
            // 
            // ReisedauerZumMond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 396);
            this.Controls.Add(this.txtAusgabeReisedauer);
            this.Controls.Add(this.lblAusgabeReisedauer);
            this.Controls.Add(this.btnReisedauerBerechnen);
            this.Controls.Add(this.txtGeschwindigkeit);
            this.Controls.Add(this.lblGeschwindigkeit);
            this.Controls.Add(this.rbStunden);
            this.Controls.Add(this.rbTage);
            this.Name = "ReisedauerZumMond";
            this.Text = "ReisedauerZumMond";
            this.Load += new System.EventHandler(this.ReisedauerZumMond_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTage;
        private System.Windows.Forms.RadioButton rbStunden;
        private System.Windows.Forms.Label lblGeschwindigkeit;
        private System.Windows.Forms.TextBox txtGeschwindigkeit;
        private System.Windows.Forms.Button btnReisedauerBerechnen;
        private System.Windows.Forms.Label lblAusgabeReisedauer;
        private System.Windows.Forms.TextBox txtAusgabeReisedauer;
    }
}

