namespace AzureVault
{
    partial class Passwortgenerator
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
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug = new Label();
            SuspendLayout();
            // 
            // lblFormPasswortgeneratorPasswortgeneratorSchriftzug
            // 
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug.Anchor = AnchorStyles.None;
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug.AutoSize = true;
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug.ForeColor = Color.FromArgb(0, 117, 214);
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug.Location = new Point(12, 9);
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug.Name = "lblFormPasswortgeneratorPasswortgeneratorSchriftzug";
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug.Size = new Size(296, 36);
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug.TabIndex = 3;
            lblFormPasswortgeneratorPasswortgeneratorSchriftzug.Text = "Passwortgenerator";
            // 
            // Passwortgenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(553, 420);
            Controls.Add(lblFormPasswortgeneratorPasswortgeneratorSchriftzug);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Passwortgenerator";
            Text = "Passwortgenerator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormPasswortgeneratorPasswortgeneratorSchriftzug;
    }
}