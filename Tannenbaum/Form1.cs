using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTanneZeichnen_Click(object sender, EventArgs e)
        {
            Tannenbaum t = new Tannenbaum(Convert.ToInt32(txtKronenhoehe.Text)
                , Convert.ToInt32(txtStammbreite.Text)
                , Convert.ToInt32(txtStammhoehe.Text));

            t.Zeichne();
            txtTanne.Text = t.Resultat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


