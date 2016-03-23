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
            if (tbxKund.Text != "" && tbxTimmar.Text != "" && tbxTimpenning.Text != "")
            {
                tbxFaktura.Text = "Faktura till " + tbxKund.Text;

                tbxFaktura.Text += "\r\n"; //Ny rad
                tbxFaktura.Text += "\r\n"; //Ny rad

                tbxFaktura.Text += tbxTimmar.Text
                    + " timmar a " + tbxTimpenning.Text + " kr: ";

                int timmar, timpenning, kostnadExklMoms;

                timmar = int.Parse(tbxTimmar.Text); //Konverterar string till int
                timpenning = int.Parse(tbxTimpenning.Text);
                //                kostnadExklMoms = timmar * timpenning;

                int i = 0; //i får hålla koll på antalet iterationer/"rundor"/"varv"
                kostnadExklMoms = 0;

                while (i < timmar)
                {
                    kostnadExklMoms += timpenning;
                    i++;
                }

                tbxFaktura.Text += kostnadExklMoms;

                double moms, kostnadInklMoms;

                moms = kostnadExklMoms * 0.25;
                kostnadInklMoms = kostnadExklMoms + moms;



                tbxFaktura.Text += "\r\n";
                tbxFaktura.Text += "Moms (25 %): " + moms + " kr";

                //Rabatt
                if(checkRabatt.Checked==true)
                {
                    kostnadInklMoms -= 100;
                    tbxFaktura.Text += "Rabatt: 100 kr";
                }

                tbxFaktura.Text += "\r\n";
                tbxFaktura.Text += "Att betala: " + kostnadInklMoms;
            }
            else //Om inte alla fält är ifyllda
                MessageBox.Show("Fyll i alla fält!");


        }
    }
}
