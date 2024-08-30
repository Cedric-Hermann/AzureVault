namespace AzureVault
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblForm1Close = new Label();
            txtForm1MasterPasswortEingabe = new TextBox();
            panelForm1TextTrenner = new Panel();
            btnForm1LogIn = new Button();
            lblForm1TextBoxLeeren = new Label();
            lblForm1LoginSchriftzug = new Label();
            pictureBoxForm1Logo = new PictureBox();
            picForm1KeySymbol = new PictureBox();
            lblForm1StandardPasswortText = new Label();
            picForm1ShowPasswortSymbol = new PictureBox();
            picForm1HidePasswortSymbol = new PictureBox();
            lblForm1PasswortEingabeFeldLeerError = new Label();
            lblForm1MasterPasswortEingabeFalschError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm1Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picForm1KeySymbol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picForm1ShowPasswortSymbol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picForm1HidePasswortSymbol).BeginInit();
            SuspendLayout();
            // 
            // lblForm1Close
            // 
            lblForm1Close.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblForm1Close.AutoSize = true;
            lblForm1Close.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblForm1Close.ForeColor = Color.FromArgb(0, 117, 214);
            lblForm1Close.Location = new Point(108, 394);
            lblForm1Close.Name = "lblForm1Close";
            lblForm1Close.Size = new Size(76, 16);
            lblForm1Close.TabIndex = 6;
            lblForm1Close.Text = "Schließen";
            lblForm1Close.Click += lblCloseForm1_Click;
            // 
            // txtForm1MasterPasswortEingabe
            // 
            txtForm1MasterPasswortEingabe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtForm1MasterPasswortEingabe.BorderStyle = BorderStyle.None;
            txtForm1MasterPasswortEingabe.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            txtForm1MasterPasswortEingabe.ForeColor = Color.FromArgb(0, 117, 214);
            txtForm1MasterPasswortEingabe.Location = new Point(52, 193);
            txtForm1MasterPasswortEingabe.Multiline = true;
            txtForm1MasterPasswortEingabe.Name = "txtForm1MasterPasswortEingabe";
            txtForm1MasterPasswortEingabe.PasswordChar = '*';
            txtForm1MasterPasswortEingabe.Size = new Size(182, 25);
            txtForm1MasterPasswortEingabe.TabIndex = 0;
            // 
            // panelForm1TextTrenner
            // 
            panelForm1TextTrenner.BackColor = Color.FromArgb(0, 177, 250);
            panelForm1TextTrenner.Location = new Point(21, 224);
            panelForm1TextTrenner.Name = "panelForm1TextTrenner";
            panelForm1TextTrenner.Size = new Size(236, 1);
            panelForm1TextTrenner.TabIndex = 3;
            // 
            // btnForm1LogIn
            // 
            btnForm1LogIn.BackColor = Color.FromArgb(0, 117, 214);
            btnForm1LogIn.FlatStyle = FlatStyle.Flat;
            btnForm1LogIn.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            btnForm1LogIn.ForeColor = Color.White;
            btnForm1LogIn.Location = new Point(21, 311);
            btnForm1LogIn.Name = "btnForm1LogIn";
            btnForm1LogIn.Size = new Size(236, 33);
            btnForm1LogIn.TabIndex = 4;
            btnForm1LogIn.Text = "LOG IN";
            btnForm1LogIn.UseVisualStyleBackColor = false;
            btnForm1LogIn.Click += btnForm1LogIn_Click;
            // 
            // lblForm1TextBoxLeeren
            // 
            lblForm1TextBoxLeeren.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblForm1TextBoxLeeren.AutoSize = true;
            lblForm1TextBoxLeeren.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblForm1TextBoxLeeren.ForeColor = Color.FromArgb(0, 117, 214);
            lblForm1TextBoxLeeren.Location = new Point(171, 292);
            lblForm1TextBoxLeeren.Name = "lblForm1TextBoxLeeren";
            lblForm1TextBoxLeeren.Size = new Size(86, 16);
            lblForm1TextBoxLeeren.TabIndex = 5;
            lblForm1TextBoxLeeren.Text = "Feld leeren";
            lblForm1TextBoxLeeren.Click += lblForm1TextBoxLeeren_Click;
            // 
            // lblForm1LoginSchriftzug
            // 
            lblForm1LoginSchriftzug.AutoSize = true;
            lblForm1LoginSchriftzug.BackColor = Color.Transparent;
            lblForm1LoginSchriftzug.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            lblForm1LoginSchriftzug.ForeColor = Color.FromArgb(0, 117, 214);
            lblForm1LoginSchriftzug.Location = new Point(84, 105);
            lblForm1LoginSchriftzug.Name = "lblForm1LoginSchriftzug";
            lblForm1LoginSchriftzug.Size = new Size(114, 36);
            lblForm1LoginSchriftzug.TabIndex = 1;
            lblForm1LoginSchriftzug.Text = "LOG IN";
            // 
            // pictureBoxForm1Logo
            // 
            pictureBoxForm1Logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxForm1Logo.Image = Properties.Resources._4373272_512;
            pictureBoxForm1Logo.Location = new Point(96, 22);
            pictureBoxForm1Logo.Name = "pictureBoxForm1Logo";
            pictureBoxForm1Logo.Size = new Size(87, 71);
            pictureBoxForm1Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForm1Logo.TabIndex = 7;
            pictureBoxForm1Logo.TabStop = false;
            // 
            // picForm1KeySymbol
            // 
            picForm1KeySymbol.Image = Properties.Resources._9025798_512;
            picForm1KeySymbol.Location = new Point(21, 193);
            picForm1KeySymbol.Name = "picForm1KeySymbol";
            picForm1KeySymbol.Size = new Size(25, 25);
            picForm1KeySymbol.SizeMode = PictureBoxSizeMode.Zoom;
            picForm1KeySymbol.TabIndex = 8;
            picForm1KeySymbol.TabStop = false;
            // 
            // lblForm1StandardPasswortText
            // 
            lblForm1StandardPasswortText.AutoSize = true;
            lblForm1StandardPasswortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblForm1StandardPasswortText.ForeColor = Color.FromArgb(0, 117, 214);
            lblForm1StandardPasswortText.Location = new Point(52, 228);
            lblForm1StandardPasswortText.Name = "lblForm1StandardPasswortText";
            lblForm1StandardPasswortText.Size = new Size(182, 16);
            lblForm1StandardPasswortText.TabIndex = 8;
            lblForm1StandardPasswortText.Text = "Standardpasswort: admin";
            // 
            // picForm1ShowPasswortSymbol
            // 
            picForm1ShowPasswortSymbol.Image = Properties.Resources._9041806_512;
            picForm1ShowPasswortSymbol.Location = new Point(232, 193);
            picForm1ShowPasswortSymbol.Name = "picForm1ShowPasswortSymbol";
            picForm1ShowPasswortSymbol.Size = new Size(25, 25);
            picForm1ShowPasswortSymbol.SizeMode = PictureBoxSizeMode.Zoom;
            picForm1ShowPasswortSymbol.TabIndex = 9;
            picForm1ShowPasswortSymbol.TabStop = false;
            picForm1ShowPasswortSymbol.Click += picForm1ShowPasswortSymbol_Click;
            // 
            // picForm1HidePasswortSymbol
            // 
            picForm1HidePasswortSymbol.Image = Properties.Resources._9041858_512;
            picForm1HidePasswortSymbol.Location = new Point(232, 193);
            picForm1HidePasswortSymbol.Name = "picForm1HidePasswortSymbol";
            picForm1HidePasswortSymbol.Size = new Size(25, 25);
            picForm1HidePasswortSymbol.SizeMode = PictureBoxSizeMode.Zoom;
            picForm1HidePasswortSymbol.TabIndex = 10;
            picForm1HidePasswortSymbol.TabStop = false;
            picForm1HidePasswortSymbol.Visible = false;
            picForm1HidePasswortSymbol.Click += picForm1HidePasswortSymbol_Click;
            // 
            // lblForm1PasswortEingabeFeldLeerError
            // 
            lblForm1PasswortEingabeFeldLeerError.BackColor = Color.Transparent;
            lblForm1PasswortEingabeFeldLeerError.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblForm1PasswortEingabeFeldLeerError.ForeColor = Color.Red;
            lblForm1PasswortEingabeFeldLeerError.Location = new Point(21, 347);
            lblForm1PasswortEingabeFeldLeerError.Name = "lblForm1PasswortEingabeFeldLeerError";
            lblForm1PasswortEingabeFeldLeerError.Size = new Size(241, 23);
            lblForm1PasswortEingabeFeldLeerError.TabIndex = 11;
            lblForm1PasswortEingabeFeldLeerError.Text = "Feld darf nicht leer sein!";
            lblForm1PasswortEingabeFeldLeerError.TextAlign = ContentAlignment.MiddleCenter;
            lblForm1PasswortEingabeFeldLeerError.Visible = false;
            // 
            // lblForm1MasterPasswortEingabeFalschError
            // 
            lblForm1MasterPasswortEingabeFalschError.BackColor = Color.Transparent;
            lblForm1MasterPasswortEingabeFalschError.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblForm1MasterPasswortEingabeFalschError.ForeColor = Color.Red;
            lblForm1MasterPasswortEingabeFalschError.Location = new Point(21, 347);
            lblForm1MasterPasswortEingabeFalschError.Name = "lblForm1MasterPasswortEingabeFalschError";
            lblForm1MasterPasswortEingabeFalschError.Size = new Size(236, 23);
            lblForm1MasterPasswortEingabeFalschError.TabIndex = 12;
            lblForm1MasterPasswortEingabeFalschError.Text = "Master-Passwort falsch!";
            lblForm1MasterPasswortEingabeFalschError.TextAlign = ContentAlignment.MiddleCenter;
            lblForm1MasterPasswortEingabeFalschError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(292, 447);
            Controls.Add(lblForm1MasterPasswortEingabeFalschError);
            Controls.Add(lblForm1PasswortEingabeFeldLeerError);
            Controls.Add(picForm1HidePasswortSymbol);
            Controls.Add(picForm1ShowPasswortSymbol);
            Controls.Add(lblForm1StandardPasswortText);
            Controls.Add(picForm1KeySymbol);
            Controls.Add(pictureBoxForm1Logo);
            Controls.Add(lblForm1LoginSchriftzug);
            Controls.Add(lblForm1TextBoxLeeren);
            Controls.Add(btnForm1LogIn);
            Controls.Add(panelForm1TextTrenner);
            Controls.Add(txtForm1MasterPasswortEingabe);
            Controls.Add(lblForm1Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm1Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picForm1KeySymbol).EndInit();
            ((System.ComponentModel.ISupportInitialize)picForm1ShowPasswortSymbol).EndInit();
            ((System.ComponentModel.ISupportInitialize)picForm1HidePasswortSymbol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblForm1Close;
        private TextBox txtForm1MasterPasswortEingabe;
        private Panel panelForm1TextTrenner;
        private Button btnForm1LogIn;
        private Label lblForm1TextBoxLeeren;
        private Label lblForm1LoginSchriftzug;
        private PictureBox pictureBoxForm1Logo;
        private PictureBox picForm1KeySymbol;
        private Label lblForm1StandardPasswortText;
        private PictureBox picForm1ShowPasswortSymbol;
        private PictureBox picForm1HidePasswortSymbol;
        private Label lblForm1PasswortEingabeFeldLeerError;
        private Label lblForm1MasterPasswortEingabeFalschError;
    }
}
