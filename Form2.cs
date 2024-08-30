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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Azure Vault";
            this.Icon = new Icon("BlueLockIcon.ico");
        }


        public void loadForm(object form)
        {
            if(this.panelForm2Main.Controls.Count > 0)
            {
                this.panelForm2Main.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelForm2Main.Controls.Add(f);
            this.panelForm2Main.Tag = f;
            f.Show();
        }
        private void picForm2Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picForm2Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
