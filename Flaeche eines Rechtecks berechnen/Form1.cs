using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flaeche_eines_Rechtecks_berechnen
{
		public partial class Form1 : Form
		{
			private Rechteck _rechteck = new Rechteck();
			
			public Form1()
			{
				InitializeComponent();
			}

			private void btnBeenden_Click(object sender, EventArgs e)
			{
				this.Close();
			}

			private void btnBerechnen_Click(object sender, EventArgs e)
			{
				int rhoehe = Convert.ToInt32(txtHoehe.Text);
				int rbreite = Convert.ToInt32(txtBreite.Text);

				try
				{
					txtAusgabe.Text  = _rechteck.BerechneFlaeche(rhoehe, rbreite).ToString();
				
				}
				catch (Exception ex)
				{
					MessageBox.Show("Fehler passiert: " + ex.Message); 
				}
			}
			
		}
	}

