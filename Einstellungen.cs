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
    public partial class Einstellungen : Form
    {
        public Einstellungen()
        {
            InitializeComponent();
        }

        private void btnFormEinstellungenMasterPasswortChange_Click(object sender, EventArgs e)
        {
            lblFormEinstellungenMasterPasswortFeldLeerError.Visible = false;
            lblFormEinstellungenAktuellesMasterPasswortFalschError.Visible = false;
            lblFormEinstellungenNewMasterPasswortNotMatchingError.Visible = false;
            lblFormEinstellungenMasterPasswortChangedSchriftzug.Visible = false;
            string masterSaveNameOrLocation = "mSave.txt";
            string mPassKey = "e546c8df278cd5931069b522e6953332";
            string masterPasswort = DeAndEncryptionFunktionen.DecryptText(masterSaveNameOrLocation, mPassKey);
            if(txtFormEinstellungenAktuellesMasterPasswortEingabe.Text.Length > 0 && txtFormEinstellungenNewPasswortEingabe.Text.Length > 0 && txtFormEinstellungenConfirmNewPasswortEingabe.Text.Length > 0)
            {
                lblFormEinstellungenMasterPasswortFeldLeerError.Visible = false;
                if(File.Exists(masterSaveNameOrLocation))
                {
                    if(txtFormEinstellungenAktuellesMasterPasswortEingabe.Text == masterPasswort)
                    {
                        lblFormEinstellungenAktuellesMasterPasswortFalschError.Visible = false;
                        if(txtFormEinstellungenNewPasswortEingabe.Text == txtFormEinstellungenConfirmNewPasswortEingabe.Text)
                        {
                            lblFormEinstellungenNewMasterPasswortNotMatchingError.Visible = false;
                            DeAndEncryptionFunktionen.EncryptText(txtFormEinstellungenNewPasswortEingabe.Text, masterSaveNameOrLocation, mPassKey);
                            lblFormEinstellungenMasterPasswortChangedSchriftzug.Visible = true;
                        }
                        else
                        {
                            lblFormEinstellungenNewMasterPasswortNotMatchingError.Visible = true;
                        }
                    }
                    else
                    {
                        lblFormEinstellungenAktuellesMasterPasswortFalschError.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten!");
                }
            }
            else
            {
                lblFormEinstellungenMasterPasswortFeldLeerError.Visible = true;
                txtFormEinstellungenAktuellesMasterPasswortEingabe.Focus();
            }
        }
    }
}
