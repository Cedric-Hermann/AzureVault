namespace AzureVault
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCloseForm1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            ///Programm (LogIn Fenster bzw "Form1") wird beim Klicken auf das Label "lblCloseForm1" beendet
        }

        private void lblForm1TextBoxLeeren_Click(object sender, EventArgs e)
        {
            txtForm1MasterPasswortEingabe.Clear();
            txtForm1MasterPasswortEingabe.Focus();
            ///Textfeld "txtFormMasterPasswortEingabe" wird beim Klicken auf Label "lblForm1TextBoxLeeren" geleert und fokusiert
        }

        private void picForm1HidePasswortSymbol_Click(object sender, EventArgs e)
        {
            txtForm1MasterPasswortEingabe.PasswordChar = '*';
            picForm1HidePasswortSymbol.Visible = false;
            picForm1ShowPasswortSymbol.Visible = true;
            ///Text in Textfeld "txtFormMasterPasswortEingabe" wird als Sternchen angezeigt
            ///"picForm1HidePasswortSymbol" wird unsichtbar, "picForm1ShowPasswortSymbol" wird sichtbar
        }

        private void picForm1ShowPasswortSymbol_Click(object sender, EventArgs e)
        {
            txtForm1MasterPasswortEingabe.PasswordChar = '\0';
            picForm1HidePasswortSymbol.Visible = true;
            picForm1ShowPasswortSymbol.Visible = false;
            ///Text in Textfeld "txtFormMasterPasswortEingabe" wird als normaler Text angezeigt
            ///"picForm1HidePasswortSymbol" wird sichtbar, "picForm1ShowPasswortSymbol" wird unsichtbar
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Azure Vault";
            Icon = new Icon("BlueLockIcon.ico");
            txtForm1MasterPasswortEingabe.Focus();
            AcceptButton = btnForm1LogIn;
            ///Text in Taskbar wird auf "Azure Vault" und das Icon auf "BlueLockIcon.ico" gesetzt
            ///Textfeld "txtForm1MasterPasswortEingabe" wird fokusiert und Button "btnForm1LogIn" der acceptbutton von Form1
        }

        private void btnForm1LogIn_Click(object sender, EventArgs e)
        {
            string masterSaveNameOrLocation = "mSave.txt";
            string standardMasterPasswort = "admin";
            string mPassKey = "e546c8df278cd5931069b522e6953332";
            ///Verschlüsslungskey ist offen im Code einsehbar -> weniger sicher, eventuell bessere Methode finden
            
            if(txtForm1MasterPasswortEingabe.Text.Length > 0 )
            {
                lblForm1PasswortEingabeFeldLeerError.Visible = false;
                if(File.Exists(masterSaveNameOrLocation))
                {
                    string mPass = DeAndEncryptionFunktionen.DecryptText(masterSaveNameOrLocation, mPassKey);
                    if(txtForm1MasterPasswortEingabe.Text == mPass)
                    {
                        lblForm1MasterPasswortEingabeFalschError.Visible = false;
                        new Form2().Show();
                        this.Hide();
                        ///Masterpasswort Save Datei bereits vorhanden, eingegebenes Passwort richtig
                        ///Form2 wird geöffnet und Form1 versteckt
                    }
                    else
                    {
                        lblForm1MasterPasswortEingabeFalschError.Visible = true;
                        txtForm1MasterPasswortEingabe.Clear();
                        txtForm1MasterPasswortEingabe.Focus();
                        ///Masterpasswort Save Datei bereits vorhanden, eingegebenes Passwort jedoch falsch
                        ///Entsprechende Fehlermeldung wird angezeigt und das Textfeld geleert und fokusiert
                    }
                }
                else
                {
                    DeAndEncryptionFunktionen.EncryptText(standardMasterPasswort, masterSaveNameOrLocation, mPassKey);
                    ///Masterpasswort Save Datei wird mit verschlüsseltem Standartpasswort erstellt
                    
                    string pass = DeAndEncryptionFunktionen.DecryptText(masterSaveNameOrLocation, mPassKey);
                    ///Masterpasswort in Save Datei wird entschlüsselt
                    
                    if(txtForm1MasterPasswortEingabe.Text == pass)
                    {
                        ///MessageBox.Show("Master Passwort korrekt. Zur Sicherheit ändern.");
                        lblForm1MasterPasswortEingabeFalschError.Visible = false;
                        new Form2().Show();
                        this.Hide();
                        ///Masterpasswort Save Datei wurde erstellt, eingegebenes Passwort richtig
                        ///Form2 wird geöffnet und Form1 versteckt
                    }
                    else
                    {
                        lblForm1MasterPasswortEingabeFalschError.Visible = true;
                        txtForm1MasterPasswortEingabe.Clear();
                        txtForm1MasterPasswortEingabe.Focus();
                        ///Masterpasswort Save Datei wurde erstellt, eingegebenes Passwort jedoch falsch
                        ///Entsprechende Fehlermeldung wird angezeigt und das Textfeld geleert und fokusiert
                    }
                }
            }
            else
            {
                lblForm1PasswortEingabeFeldLeerError.Visible = true;
                txtForm1MasterPasswortEingabe.Focus();
                ///Passworteingabefeld leer
                ///Entsprechende Fehlermeldung wird angezeigt und das Textfeld fokusiert
            }
        }
    }
}
