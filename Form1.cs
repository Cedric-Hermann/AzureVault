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
        }

        private void lblForm1TextBoxLeeren_Click(object sender, EventArgs e)
        {
            txtForm1MasterPasswortEingabe.Clear();
            txtForm1MasterPasswortEingabe.Focus();
        }

        private void picForm1HidePasswortSymbol_Click(object sender, EventArgs e)
        {
            txtForm1MasterPasswortEingabe.PasswordChar = '*';
            picForm1HidePasswortSymbol.Visible = false;
            picForm1ShowPasswortSymbol.Visible = true;
        }

        private void picForm1ShowPasswortSymbol_Click(object sender, EventArgs e)
        {
            txtForm1MasterPasswortEingabe.PasswordChar = '\0';
            picForm1HidePasswortSymbol.Visible = true;
            picForm1ShowPasswortSymbol.Visible = false;
        }
    }
}
