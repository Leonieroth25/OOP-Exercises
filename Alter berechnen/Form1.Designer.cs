namespace Alter_berechnen
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
            this.gbEinheit = new System.Windows.Forms.GroupBox();
            this.rbJahre = new System.Windows.Forms.RadioButton();
            this.rbMonate = new System.Windows.Forms.RadioButton();
            this.rbWochen = new System.Windows.Forms.RadioButton();
            this.rbTage = new System.Windows.Forms.RadioButton();
            this.gbEingabe = new System.Windows.Forms.GroupBox();
            this.dateTimePickerGeburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.lblGeburtsdatum = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.gbAusgabe = new System.Windows.Forms.GroupBox();
            this.lblAlter = new System.Windows.Forms.Label();
            this.txtAlter = new System.Windows.Forms.TextBox();
            this.gbEinheit.SuspendLayout();
            this.gbEingabe.SuspendLayout();
            this.gbAusgabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEinheit
            // 
            this.gbEinheit.Controls.Add(this.rbJahre);
            this.gbEinheit.Controls.Add(this.rbMonate);
            this.gbEinheit.Controls.Add(this.rbWochen);
            this.gbEinheit.Controls.Add(this.rbTage);
            this.gbEinheit.Location = new System.Drawing.Point(50, 64);
            this.gbEinheit.Name = "gbEinheit";
            this.gbEinheit.Size = new System.Drawing.Size(311, 52);
            this.gbEinheit.TabIndex = 11;
            this.gbEinheit.TabStop = false;
            this.gbEinheit.Text = "Einheit";
            // 
            // rbJahre
            // 
            this.rbJahre.AutoSize = true;
            this.rbJahre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rbJahre.Location = new System.Drawing.Point(6, 19);
            this.rbJahre.Name = "rbJahre";
            this.rbJahre.Size = new System.Drawing.Size(62, 21);
            this.rbJahre.TabIndex = 0;
            this.rbJahre.TabStop = true;
            this.rbJahre.Text = "Jahre";
            this.rbJahre.UseVisualStyleBackColor = true;
            // 
            // rbMonate
            // 
            this.rbMonate.AutoSize = true;
            this.rbMonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rbMonate.Location = new System.Drawing.Point(74, 19);
            this.rbMonate.Name = "rbMonate";
            this.rbMonate.Size = new System.Drawing.Size(73, 21);
            this.rbMonate.TabIndex = 3;
            this.rbMonate.TabStop = true;
            this.rbMonate.Text = "Monate";
            this.rbMonate.UseVisualStyleBackColor = true;
            // 
            // rbWochen
            // 
            this.rbWochen.AutoSize = true;
            this.rbWochen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rbWochen.Location = new System.Drawing.Point(153, 19);
            this.rbWochen.Name = "rbWochen";
            this.rbWochen.Size = new System.Drawing.Size(78, 21);
            this.rbWochen.TabIndex = 2;
            this.rbWochen.TabStop = true;
            this.rbWochen.Text = "Wochen";
            this.rbWochen.UseVisualStyleBackColor = true;
            // 
            // rbTage
            // 
            this.rbTage.AutoSize = true;
            this.rbTage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rbTage.Location = new System.Drawing.Point(237, 19);
            this.rbTage.Name = "rbTage";
            this.rbTage.Size = new System.Drawing.Size(59, 21);
            this.rbTage.TabIndex = 1;
            this.rbTage.TabStop = true;
            this.rbTage.Text = "Tage";
            this.rbTage.UseVisualStyleBackColor = true;
            // 
            // gbEingabe
            // 
            this.gbEingabe.Controls.Add(this.dateTimePickerGeburtsdatum);
            this.gbEingabe.Controls.Add(this.lblGeburtsdatum);
            this.gbEingabe.Controls.Add(this.btnBerechnen);
            this.gbEingabe.Location = new System.Drawing.Point(50, 122);
            this.gbEingabe.Name = "gbEingabe";
            this.gbEingabe.Size = new System.Drawing.Size(454, 80);
            this.gbEingabe.TabIndex = 12;
            this.gbEingabe.TabStop = false;
            this.gbEingabe.Text = "Eingabe";
            // 
            // dateTimePickerGeburtsdatum
            // 
            this.dateTimePickerGeburtsdatum.Location = new System.Drawing.Point(121, 38);
            this.dateTimePickerGeburtsdatum.Name = "dateTimePickerGeburtsdatum";
            this.dateTimePickerGeburtsdatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGeburtsdatum.TabIndex = 14;
            // 
            // lblGeburtsdatum
            // 
            this.lblGeburtsdatum.AutoSize = true;
            this.lblGeburtsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblGeburtsdatum.Location = new System.Drawing.Point(3, 41);
            this.lblGeburtsdatum.Name = "lblGeburtsdatum";
            this.lblGeburtsdatum.Size = new System.Drawing.Size(98, 17);
            this.lblGeburtsdatum.TabIndex = 4;
            this.lblGeburtsdatum.Text = "Geburtsdatum";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBerechnen.Location = new System.Drawing.Point(362, 37);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(92, 24);
            this.btnBerechnen.TabIndex = 9;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // gbAusgabe
            // 
            this.gbAusgabe.Controls.Add(this.lblAlter);
            this.gbAusgabe.Controls.Add(this.txtAlter);
            this.gbAusgabe.Location = new System.Drawing.Point(50, 208);
            this.gbAusgabe.Name = "gbAusgabe";
            this.gbAusgabe.Size = new System.Drawing.Size(454, 67);
            this.gbAusgabe.TabIndex = 13;
            this.gbAusgabe.TabStop = false;
            this.gbAusgabe.Text = "Ausgabe";
            // 
            // lblAlter
            // 
            this.lblAlter.AutoSize = true;
            this.lblAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAlter.Location = new System.Drawing.Point(3, 33);
            this.lblAlter.Name = "lblAlter";
            this.lblAlter.Size = new System.Drawing.Size(37, 17);
            this.lblAlter.TabIndex = 5;
            this.lblAlter.Text = "Alter";
            // 
            // txtAlter
            // 
            this.txtAlter.Location = new System.Drawing.Point(121, 30);
            this.txtAlter.Name = "txtAlter";
            this.txtAlter.Size = new System.Drawing.Size(200, 20);
            this.txtAlter.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 331);
            this.Controls.Add(this.gbAusgabe);
            this.Controls.Add(this.gbEingabe);
            this.Controls.Add(this.gbEinheit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEinheit.ResumeLayout(false);
            this.gbEinheit.PerformLayout();
            this.gbEingabe.ResumeLayout(false);
            this.gbEingabe.PerformLayout();
            this.gbAusgabe.ResumeLayout(false);
            this.gbAusgabe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEinheit;
        private System.Windows.Forms.RadioButton rbJahre;
        private System.Windows.Forms.RadioButton rbMonate;
        private System.Windows.Forms.RadioButton rbWochen;
        private System.Windows.Forms.RadioButton rbTage;
        private System.Windows.Forms.GroupBox gbEingabe;
        private System.Windows.Forms.Label lblGeburtsdatum;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.GroupBox gbAusgabe;
        private System.Windows.Forms.Label lblAlter;
        private System.Windows.Forms.TextBox txtAlter;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeburtsdatum;
    }
}

