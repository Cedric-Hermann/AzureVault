using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureVault
{
    public partial class Passwortgenerator : Form
    {
        public Passwortgenerator()
        {
            InitializeComponent();
        }

        private void trackFormPasswortgeneratorPasswortLaenge_ValueChanged(object sender, EventArgs e)
        {
            lblFormPasswortgeneratorChoosenLength.Text = "Länge: " + trackFormPasswortgeneratorPasswortLaenge.Value.ToString();
        }

        private void btnFormPasswortgeneratorPasswortKopieren_Click(object sender, EventArgs e)
        {
            if (lblFormPasswortgeneratorPasswortAusgabe.Text.Length > 0)
            {
                Clipboard.SetText(lblFormPasswortgeneratorPasswortAusgabe.Text);
            }
        }

        private void btnFormPasswortgeneratorPasswortGenerieren_Click(object sender, EventArgs e)
        {
            string charset = "";
            double laenge = trackFormPasswortgeneratorPasswortLaenge.Value;
            string dopplung = "1";
            string lengthchar = "";

            if(chkFormPasswortgeneratorOptionGrossbuchstaben.Checked)
                charset += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if(chkFormPasswortgeneratorOptionKleinbuchstaben.Checked)
                charset += "abcdefghijklmnopqrstuvwxyz";
            if(chkFormPasswortgeneratorOptionZahlen.Checked)
                charset += "1234567890";
            if(chkFormPasswortgeneratorOptionSonderzeichen.Checked)
                charset += "!@#$%^&";
            if(chkFormPasswortgeneratorOptionKeineDopplung.Checked)
                dopplung = "0";

            if(charset.Length > 0)
            {
                for(int i = 1; i < laenge; i++)
                {
                    lengthchar += "1";
                }
                Random random = new Random();
                string generatedPasswort = "";
                int passwortLength = lengthchar.Length;
                if (dopplung == "0")
                {
                    if (passwortLength > charset.Length)
                    {
                        passwortLength = charset.Length;
                        for (int i = 0; i < passwortLength; i++)
                        {
                            int position = random.Next(charset.Length);
                            generatedPasswort += charset[position];
                            charset = charset.Remove(position, 1);
                        }
                        lblFormPasswortgeneratorPasswortAusgabe.Text = generatedPasswort;
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < passwortLength; i++)
                        {
                            int position = random.Next(charset.Length);
                            generatedPasswort += charset[position];
                            charset = charset.Remove(position, 1);
                        }
                        lblFormPasswortgeneratorPasswortAusgabe.Text = generatedPasswort;
                        return;
                    }
                }
                else
                {
                    for (int i = 0; i < passwortLength; i++)
                    {
                        int position = random.Next(charset.Length);
                        generatedPasswort += charset[position];
                    }
                    lblFormPasswortgeneratorPasswortAusgabe.Text = generatedPasswort;
                    return;
                }
            }
        }
    }
}
