namespace AzureVault
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelForm2Left = new Panel();
            panelForm2Top = new Panel();
            picForm2Minimize = new PictureBox();
            picForm2Close = new PictureBox();
            panelForm2Main = new Panel();
            picForm2Logo = new PictureBox();
            lblForm2AzureVaultSchriftzug = new Label();
            btnForm2OpenFormEinstellungen = new Button();
            btnForm2OpenFormPasswortgenerator = new Button();
            btnForm2OpenFormZugangsdaten = new Button();
            panelForm2Left.SuspendLayout();
            panelForm2Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picForm2Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picForm2Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picForm2Logo).BeginInit();
            SuspendLayout();
            // 
            // panelForm2Left
            // 
            panelForm2Left.BackColor = Color.FromArgb(200, 230, 255);
            panelForm2Left.Controls.Add(btnForm2OpenFormZugangsdaten);
            panelForm2Left.Controls.Add(btnForm2OpenFormPasswortgenerator);
            panelForm2Left.Controls.Add(btnForm2OpenFormEinstellungen);
            panelForm2Left.Controls.Add(lblForm2AzureVaultSchriftzug);
            panelForm2Left.Controls.Add(picForm2Logo);
            panelForm2Left.Location = new Point(0, 30);
            panelForm2Left.Name = "panelForm2Left";
            panelForm2Left.Size = new Size(251, 420);
            panelForm2Left.TabIndex = 0;
            // 
            // panelForm2Top
            // 
            panelForm2Top.BackColor = Color.FromArgb(200, 230, 255);
            panelForm2Top.Controls.Add(picForm2Minimize);
            panelForm2Top.Controls.Add(picForm2Close);
            panelForm2Top.Location = new Point(0, 0);
            panelForm2Top.Name = "panelForm2Top";
            panelForm2Top.Size = new Size(800, 30);
            panelForm2Top.TabIndex = 1;
            // 
            // picForm2Minimize
            // 
            picForm2Minimize.BackColor = Color.Transparent;
            picForm2Minimize.Image = Properties.Resources._9041971_512;
            picForm2Minimize.Location = new Point(734, 0);
            picForm2Minimize.Name = "picForm2Minimize";
            picForm2Minimize.Size = new Size(30, 30);
            picForm2Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            picForm2Minimize.TabIndex = 1;
            picForm2Minimize.TabStop = false;
            picForm2Minimize.Click += picForm2Minimize_Click;
            // 
            // picForm2Close
            // 
            picForm2Close.BackColor = Color.Transparent;
            picForm2Close.Image = Properties.Resources._9041677_512;
            picForm2Close.Location = new Point(770, 0);
            picForm2Close.Name = "picForm2Close";
            picForm2Close.Size = new Size(30, 30);
            picForm2Close.SizeMode = PictureBoxSizeMode.Zoom;
            picForm2Close.TabIndex = 0;
            picForm2Close.TabStop = false;
            picForm2Close.Click += picForm2Close_Click;
            // 
            // panelForm2Main
            // 
            panelForm2Main.Location = new Point(247, 30);
            panelForm2Main.Name = "panelForm2Main";
            panelForm2Main.Size = new Size(553, 420);
            panelForm2Main.TabIndex = 2;
            // 
            // picForm2Logo
            // 
            picForm2Logo.BackColor = Color.Transparent;
            picForm2Logo.Image = Properties.Resources._4373272_512;
            picForm2Logo.Location = new Point(12, 3);
            picForm2Logo.Name = "picForm2Logo";
            picForm2Logo.Size = new Size(229, 151);
            picForm2Logo.SizeMode = PictureBoxSizeMode.Zoom;
            picForm2Logo.TabIndex = 0;
            picForm2Logo.TabStop = false;
            // 
            // lblForm2AzureVaultSchriftzug
            // 
            lblForm2AzureVaultSchriftzug.Font = new Font("Bauhaus 93", 30F);
            lblForm2AzureVaultSchriftzug.ForeColor = Color.FromArgb(0, 117, 214);
            lblForm2AzureVaultSchriftzug.Location = new Point(12, 157);
            lblForm2AzureVaultSchriftzug.Name = "lblForm2AzureVaultSchriftzug";
            lblForm2AzureVaultSchriftzug.Size = new Size(229, 44);
            lblForm2AzureVaultSchriftzug.TabIndex = 5;
            lblForm2AzureVaultSchriftzug.Text = "Azure Vault";
            lblForm2AzureVaultSchriftzug.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnForm2OpenFormEinstellungen
            // 
            btnForm2OpenFormEinstellungen.BackColor = Color.Transparent;
            btnForm2OpenFormEinstellungen.FlatStyle = FlatStyle.Flat;
            btnForm2OpenFormEinstellungen.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            btnForm2OpenFormEinstellungen.ForeColor = Color.FromArgb(0, 117, 214);
            btnForm2OpenFormEinstellungen.Image = Properties.Resources._9041865_32;
            btnForm2OpenFormEinstellungen.ImageAlign = ContentAlignment.MiddleLeft;
            btnForm2OpenFormEinstellungen.Location = new Point(12, 377);
            btnForm2OpenFormEinstellungen.Name = "btnForm2OpenFormEinstellungen";
            btnForm2OpenFormEinstellungen.Size = new Size(229, 33);
            btnForm2OpenFormEinstellungen.TabIndex = 4;
            btnForm2OpenFormEinstellungen.Text = "Einstellungen";
            btnForm2OpenFormEinstellungen.UseVisualStyleBackColor = false;
            btnForm2OpenFormEinstellungen.Click += btnForm2OpenFormEinstellungen_Click;
            // 
            // btnForm2OpenFormPasswortgenerator
            // 
            btnForm2OpenFormPasswortgenerator.BackColor = Color.Transparent;
            btnForm2OpenFormPasswortgenerator.FlatStyle = FlatStyle.Flat;
            btnForm2OpenFormPasswortgenerator.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            btnForm2OpenFormPasswortgenerator.ForeColor = Color.FromArgb(0, 117, 214);
            btnForm2OpenFormPasswortgenerator.Image = Properties.Resources._9041918_32;
            btnForm2OpenFormPasswortgenerator.ImageAlign = ContentAlignment.MiddleLeft;
            btnForm2OpenFormPasswortgenerator.Location = new Point(12, 338);
            btnForm2OpenFormPasswortgenerator.Name = "btnForm2OpenFormPasswortgenerator";
            btnForm2OpenFormPasswortgenerator.Size = new Size(229, 33);
            btnForm2OpenFormPasswortgenerator.TabIndex = 3;
            btnForm2OpenFormPasswortgenerator.Text = "      Passwortgenerator";
            btnForm2OpenFormPasswortgenerator.UseVisualStyleBackColor = false;
            btnForm2OpenFormPasswortgenerator.Click += btnForm2OpenFormPasswortgenerator_Click;
            // 
            // btnForm2OpenFormZugangsdaten
            // 
            btnForm2OpenFormZugangsdaten.BackColor = Color.Transparent;
            btnForm2OpenFormZugangsdaten.FlatStyle = FlatStyle.Flat;
            btnForm2OpenFormZugangsdaten.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            btnForm2OpenFormZugangsdaten.ForeColor = Color.FromArgb(0, 117, 214);
            btnForm2OpenFormZugangsdaten.Image = Properties.Resources._9041674_32;
            btnForm2OpenFormZugangsdaten.ImageAlign = ContentAlignment.MiddleLeft;
            btnForm2OpenFormZugangsdaten.Location = new Point(12, 299);
            btnForm2OpenFormZugangsdaten.Name = "btnForm2OpenFormZugangsdaten";
            btnForm2OpenFormZugangsdaten.Size = new Size(229, 33);
            btnForm2OpenFormZugangsdaten.TabIndex = 6;
            btnForm2OpenFormZugangsdaten.Text = "Einstellungen";
            btnForm2OpenFormZugangsdaten.UseVisualStyleBackColor = false;
            btnForm2OpenFormZugangsdaten.Click += btnForm2OpenFormZugangsdaten_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForm2Main);
            Controls.Add(panelForm2Top);
            Controls.Add(panelForm2Left);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panelForm2Left.ResumeLayout(false);
            panelForm2Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picForm2Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picForm2Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)picForm2Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForm2Left;
        private Panel panelForm2Top;
        private Panel panelForm2Main;
        private PictureBox picForm2Minimize;
        private PictureBox picForm2Close;
        private Label lblForm2AzureVaultSchriftzug;
        private PictureBox picForm2Logo;
        private Button btnForm2OpenFormEinstellungen;
        private Button btnForm2OpenFormZugangsdaten;
        private Button btnForm2OpenFormPasswortgenerator;
    }
}