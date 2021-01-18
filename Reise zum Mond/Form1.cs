using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reisedauer_zum_Mond
{

    public partial class ReisedauerZumMond : Form
    {
        private Berechnung _berechnung = new Berechnung();

        public ReisedauerZumMond()
        {
            InitializeComponent();
        }


        private void ReisedauerZumMond_Load(object sender, EventArgs e)
        {

        }

        private void txtGeschwindigkeit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReisedauerBerechnen_Click(object sender, EventArgs e)
        {
            int eingabe = Convert.ToInt32(txtGeschwindigkeit.Text);
            _berechnung.Eingabe(eingabe);

            txtAusgabeReisedauer.Text = _berechnung.Result.ToString();


            if (rbStunden.Checked == true)
            {
                _berechnung.Result = 384400 / eingabe;
            }
            else
            {
                _berechnung.Result = 384400 / eingabe / 24;
            }

        }

        private void rbStunden_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbTage_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
   
}
