using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace AzureVault
{
    public partial class Zugangsdaten : Form
    {
        public Zugangsdaten()
        {
            InitializeComponent();
        }

        private void lblFormZugangsdatenTextfelderClear_Click(object sender, EventArgs e)
        {
            txtFormZugangsdatenTitelTextfeld.Clear();
            txtFormZugangsdatenUsernameTextfeld.Clear();
            txtFormZugangsdatenPasswortTextfeld.Clear();
            txtFormZugangsdatenUrlTextfeld.Clear();
            txtFormZugangsdatenTitelTextfeld.Focus();
        }

        private void trackFormZugangsdatenChooseATresorNumberValue_Changed(object sender, EventArgs e)
        {
            lblFormZugangsdatenChosenTresorNumber.Text = trackFormZugangsdatenChooseATresorNumber.Value.ToString();
        }

        private void picFormZugangsdatenShowPasswort_Click(object sender, EventArgs e)
        {
            txtFormZugangsdatenPasswortTextfeld.PasswordChar = '\0';
            picFormZugangsdatenShowPasswort.Visible = false;
            picFormZugangsdatenHidePasswort.Visible = true;
        }

        private void picFormZugangsdatenHidePasswort_Click(object sender, EventArgs e)
        {
            txtFormZugangsdatenPasswortTextfeld.PasswordChar = '*';
            picFormZugangsdatenShowPasswort.Visible = true;
            picFormZugangsdatenHidePasswort.Visible = false;
        }

        private void picFormZugangsdatenCopyUsername_Click(object sender, EventArgs e)
        {
            if (txtFormZugangsdatenUsernameTextfeld.Text.Length > 0)
            {
                Clipboard.SetText(txtFormZugangsdatenUsernameTextfeld.Text);
            }
        }

        private void picFormZugangsdatenCopyPasswort_Click(object sender, EventArgs e)
        {
            if (txtFormZugangsdatenPasswortTextfeld.Text.Length > 0)
            {
                Clipboard.SetText(txtFormZugangsdatenPasswortTextfeld.Text);
            }
        }

        private void picFormZugangsdatenOpenUrl_Click(object sender, EventArgs e)
        {
            string url = txtFormZugangsdatenUrlTextfeld.Text;
            if (url.StartsWith("https://"))
            {
                if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else
                {
                    MessageBox.Show("Keine gültige Url.");
                }
            }
            else
            {
                string newurl = "https://" + url;
                if (Uri.IsWellFormedUriString(newurl, UriKind.Absolute))
                {
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {newurl}") { CreateNoWindow = true });
                }
                else
                {
                    MessageBox.Show("Keine gültige Url.");
                }
            }
        }

        private void btnFormZugangsdatenDatenSpeichern_Click(object sender, EventArgs e)
        {
            string idForTitelKey = "keyForTitel";
            string idForUsernameKey = "keyForUsername";
            string idForPasswortKey = "keyForPasswort";
            string idForUrlKey = "keyForUrl";

            string titelKey = KeyFunktionen.GetCryptionKeys(idForTitelKey);
            string usernameKey = KeyFunktionen.GetCryptionKeys(idForUsernameKey);
            string passwordKey = KeyFunktionen.GetCryptionKeys(idForPasswortKey);
            string urlKey = KeyFunktionen.GetCryptionKeys(idForUrlKey);

            ///string titelKey = "7a573c0747f57a677852cdf78937c7e6";
            ///string usernameKey = "b332ed1f8aac7451a5a6e2ec3f8029fa";
            ///string passwordKey = "6dcd4ce23d88e2ee95838f7b014b628e";
            ///string urlKey = "3fa85f64c2f680956a4f0a2e0a36f5ab";
            lblFormZugangsdatenDatenGespeichertSchriftzug.Visible = false;
            lblFormZugangsdatenUsernameLeerSchriftzug.Visible = false;
            lblFormZugangsdatenPasswortLeerSchriftzug.Visible = false;
            lblFormZugangsdatenDatenDeletedSchriftzug.Visible = false;
            string titelSaveFile = "tiSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            string usernameSaveFile = "usSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            string passwortSaveFile = "pwSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            string urlSaveFile = "urSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            if(txtFormZugangsdatenUsernameTextfeld.Text.Length > 0 )
            {
                lblFormZugangsdatenUsernameLeerSchriftzug.Visible = false;
                if(txtFormZugangsdatenPasswortTextfeld.Text.Length > 0 )
                {
                    lblFormZugangsdatenPasswortLeerSchriftzug.Visible = false;
                    if(!File.Exists(titelSaveFile) || !File.Exists(usernameSaveFile) || !File.Exists(passwortSaveFile) || !File.Exists(urlSaveFile))
                    {
                        DeAndEncryptionFunktionen.EncryptText(txtFormZugangsdatenTitelTextfeld.Text, titelSaveFile, titelKey);
                        DeAndEncryptionFunktionen.EncryptText(txtFormZugangsdatenUsernameTextfeld.Text, usernameSaveFile, usernameKey);
                        DeAndEncryptionFunktionen.EncryptText(txtFormZugangsdatenPasswortTextfeld.Text, passwortSaveFile, passwordKey);
                        DeAndEncryptionFunktionen.EncryptText(txtFormZugangsdatenUrlTextfeld.Text, urlSaveFile, urlKey);
                        lblFormZugangsdatenDatenGespeichertSchriftzug.Visible = true;
                    }
                    else
                    {
                        var result = MessageBox.Show("Gewählter Tresor beinhaltet bereits gespeicherte Daten. Möchten Sie diese überschreiben (permanent)?", "Daten überschreiben?", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            DeAndEncryptionFunktionen.EncryptText(txtFormZugangsdatenTitelTextfeld.Text, titelSaveFile, titelKey);
                            DeAndEncryptionFunktionen.EncryptText(txtFormZugangsdatenUsernameTextfeld.Text, usernameSaveFile, usernameKey);
                            DeAndEncryptionFunktionen.EncryptText(txtFormZugangsdatenPasswortTextfeld.Text, passwortSaveFile, passwordKey);
                            DeAndEncryptionFunktionen.EncryptText(txtFormZugangsdatenUrlTextfeld.Text, urlSaveFile, urlKey);
                            lblFormZugangsdatenDatenGespeichertSchriftzug.Visible = true;
                        }
                    }
                }
                else
                {
                    lblFormZugangsdatenPasswortLeerSchriftzug.Visible = true;
                }
            }
            else
            {
                if(txtFormZugangsdatenPasswortTextfeld.Text.Length == 0)
                {
                    lblFormZugangsdatenPasswortLeerSchriftzug.Visible = true;
                }
                lblFormZugangsdatenUsernameLeerSchriftzug.Visible = true;
            }
        }

        private void btnFormZugangsdatenDatenLaden_Click(object sender, EventArgs e)
        {
            string idForTitelKey = "keyForTitel";
            string idForUsernameKey = "keyForUsername";
            string idForPasswortKey = "keyForPasswort";
            string idForUrlKey = "keyForUrl";

            string titelKey = KeyFunktionen.GetCryptionKeys(idForTitelKey);
            string usernameKey = KeyFunktionen.GetCryptionKeys(idForUsernameKey);
            string passwordKey = KeyFunktionen.GetCryptionKeys(idForPasswortKey);
            string urlKey = KeyFunktionen.GetCryptionKeys(idForUrlKey);

            ///string titelKey = "7a573c0747f57a677852cdf78937c7e6";
            ///string usernameKey = "b332ed1f8aac7451a5a6e2ec3f8029fa";
            ///string passwordKey = "6dcd4ce23d88e2ee95838f7b014b628e";
            ///string urlKey = "3fa85f64c2f680956a4f0a2e0a36f5ab";
            lblFormZugangsdatenDatenGespeichertSchriftzug.Visible = false;
            lblFormZugangsdatenUsernameLeerSchriftzug.Visible = false;
            lblFormZugangsdatenPasswortLeerSchriftzug.Visible = false;
            lblFormZugangsdatenDatenDeletedSchriftzug.Visible = false;
            string titelSaveFile = "tiSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            string usernameSaveFile = "usSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            string passwortSaveFile = "pwSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            string urlSaveFile = "urSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            if(File.Exists(titelSaveFile))
            {
                txtFormZugangsdatenTitelTextfeld.Text = DeAndEncryptionFunktionen.DecryptText(titelSaveFile, titelKey);
            }
            else
            {
                txtFormZugangsdatenTitelTextfeld.Clear();
            }

            if(File.Exists(usernameSaveFile))
            {
                txtFormZugangsdatenUsernameTextfeld.Text = DeAndEncryptionFunktionen.DecryptText(usernameSaveFile, usernameKey);
            }
            else
            {
                txtFormZugangsdatenUsernameTextfeld.Clear();
            }

            if(File.Exists(passwortSaveFile))
            {
                txtFormZugangsdatenPasswortTextfeld.Text = DeAndEncryptionFunktionen.DecryptText(passwortSaveFile, passwordKey);
            }
            else
            {
                txtFormZugangsdatenPasswortTextfeld.Clear();
            }

            if(File.Exists(urlSaveFile))
            {
                txtFormZugangsdatenUrlTextfeld.Text = DeAndEncryptionFunktionen.DecryptText(urlSaveFile, urlKey);
            }
            else
            {
                txtFormZugangsdatenUrlTextfeld.Clear();
            }
        }

        private void btnFormZugangsdatenDatenDelete_Click(object sender, EventArgs e)
        {
            lblFormZugangsdatenDatenGespeichertSchriftzug.Visible = false;
            lblFormZugangsdatenUsernameLeerSchriftzug.Visible = false;
            lblFormZugangsdatenPasswortLeerSchriftzug.Visible = false;
            lblFormZugangsdatenDatenDeletedSchriftzug.Visible = false;
            string titelSaveFile = "tiSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            string usernameSaveFile = "usSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            string passwortSaveFile = "pwSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            string urlSaveFile = "urSave" + trackFormZugangsdatenChooseATresorNumber.Value.ToString() + ".txt";
            var result = MessageBox.Show("Das löschen der Daten ist permanent. Möchten Sie fortfahren?", "Löschen bestätigen", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                File.Delete(titelSaveFile);
                File.Delete(usernameSaveFile);
                File.Delete(passwortSaveFile);
                File.Delete(urlSaveFile);
                txtFormZugangsdatenTitelTextfeld.Clear();
                txtFormZugangsdatenUsernameTextfeld.Clear();
                txtFormZugangsdatenPasswortTextfeld.Clear();
                txtFormZugangsdatenUrlTextfeld.Clear();
                lblFormZugangsdatenDatenDeletedSchriftzug.Visible = true;
                txtFormZugangsdatenTitelTextfeld.Focus();
            }
        }

        private void picFormZugangsdatenGeneratePasswort_Click(object sender, EventArgs e)
        {
            string idForCharsetKey = "keyForCharset";
            string idForLaengeKey = "keyForLaenge";
            string idForDopplungKey = "keyForDopplung";

            ///string charsetKey = "pn6d6v4mr2nc30pvkp8sa7r89g01o2ps";
            ///string laengeKey = "j30en3rc18knn9nbprbov9od58xwh12q";
            ///string dopplungenKey = "c3fgo5jsuk2vgh490rrwgcm2g669e7hr";
            
            string charsetSettingsFile = "chaSave.txt";
            string laengeSettingsFile = "laeSave.txt";
            string dopplungenSettingsFile = "dupSave.txt";

            string charset = DeAndEncryptionFunktionen.DecryptText(charsetSettingsFile, KeyFunktionen.GetCryptionKeys(idForCharsetKey));
            string laenge = DeAndEncryptionFunktionen.DecryptText(laengeSettingsFile, KeyFunktionen.GetCryptionKeys(idForLaengeKey));
            string dopplungen = DeAndEncryptionFunktionen.DecryptText(dopplungenSettingsFile, KeyFunktionen.GetCryptionKeys(idForDopplungKey));

            ///string charset = File.ReadAllText(charsetSettingsFile);
            ///string laenge = File.ReadAllText(laengeSettingsFile);
            ///string dopplungen = File.ReadAllText(dopplungenSettingsFile);

            if (charset.Length > 0)
            {
                Random random = new Random();
                string generatedPasswort = "";
                int passwortLength = laenge.Length;
                if(dopplungen == "0")
                {
                    if(passwortLength > charset.Length)
                    {
                        passwortLength = charset.Length;
                        for(int i = 0; i < passwortLength; i++)
                        {
                            int position = random.Next(charset.Length);
                            generatedPasswort += charset[position];
                            charset = charset.Remove(position, 1);
                        }
                        txtFormZugangsdatenPasswortTextfeld.Text = generatedPasswort;
                        return;
                    }
                    else
                    {
                        for(int i = 0; i < passwortLength; i++)
                        {
                            int position = random.Next(charset.Length);
                            generatedPasswort += charset[position];
                            charset = charset.Remove(position, 1);
                        }
                        txtFormZugangsdatenPasswortTextfeld.Text = generatedPasswort;
                        return;
                    }
                }
                else
                {
                    for(int i = 0; i < passwortLength; i++)
                    {
                        int position = random.Next(charset.Length);
                        generatedPasswort += charset[position];
                    }
                    txtFormZugangsdatenPasswortTextfeld.Text = generatedPasswort;
                    return;
                }
            }
        }
    }
}
