using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alter_berechnen
{
    public partial class Form1 : Form
    {
        private BerechnuneAlter _berechneAlter = new BerechnuneAlter();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            DateTime birthDate = new DateTime();

            birthDate = dateTimePickerGeburtsdatum.Value;
            int diffInDays = (DateTime.Today - birthDate).Days;
            int diffInYears = DateTime.Today.Year - birthDate.Year;
            int diffInMonths = diffInYears * 12;

          
            if (DateTime.Today.Month < birthDate.Month)
            {
            
                diffInYears--;
                diffInMonths -= (birthDate.Month - DateTime.Today.Month);
            }
            else if (DateTime.Today.Month == birthDate.Month && DateTime.Today.Day < birthDate.Day)
            {
                diffInYears--;
                diffInMonths--;
            }
            else if (DateTime.Today.Month > birthDate.Month)
            {
               
                diffInMonths += (DateTime.Today.Month - birthDate.Month);

                if (DateTime.Today.Day < birthDate.Day)
                  diffInMonths--;
            }

            
            if (rbTage.Checked)
                txtAlter.Text = diffInDays.ToString();
            else if (rbWochen.Checked)
                txtAlter.Text = (diffInDays / 7).ToString();
            else if (rbMonate.Checked)
                txtAlter.Text = diffInMonths.ToString();
            else if (rbJahre.Checked)
                txtAlter.Text = diffInYears.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
