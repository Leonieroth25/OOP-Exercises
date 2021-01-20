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
			private Berechnung _berechnung = new Berechnung();
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
					_berechnung.Berechnungen(rhoehe, rbreite);
				}
				catch (Exception ex)
				{
				}
				txtAusgabe.Text = _berechnung.Rechteckflaeche.ToString();
			}

		}
	}

