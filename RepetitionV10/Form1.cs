using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepetitionV10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkapaFaktura_Click(object sender, EventArgs e)
        {
            tbxFaktura.Text = "Faktura till " + tbxKund.Text;

            tbxFaktura.Text += "\r\n"; //Ny rad
            tbxFaktura.Text += "\r\n"; //Ny rad

            tbxFaktura.Text += tbxTimmar.Text
                + " timmar a " + tbxTimpenning.Text + " kr: ";

            int timmar, timpenning, kostnadExklMoms;

            timmar = int.Parse(tbxTimmar.Text); //Konverterar string till int
            timpenning = int.Parse(tbxTimpenning.Text);
            kostnadExklMoms = timmar * timpenning;

            tbxFaktura.Text += kostnadExklMoms;

        }
    }
}
