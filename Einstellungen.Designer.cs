namespace AzureVault
{
    partial class Einstellungen
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
            lblFormEinstellungenEinstellungenSchriftzug = new Label();
            SuspendLayout();
            // 
            // lblFormEinstellungenEinstellungenSchriftzug
            // 
            lblFormEinstellungenEinstellungenSchriftzug.Anchor = AnchorStyles.None;
            lblFormEinstellungenEinstellungenSchriftzug.AutoSize = true;
            lblFormEinstellungenEinstellungenSchriftzug.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            lblFormEinstellungenEinstellungenSchriftzug.ForeColor = Color.FromArgb(0, 117, 214);
            lblFormEinstellungenEinstellungenSchriftzug.Location = new Point(12, 9);
            lblFormEinstellungenEinstellungenSchriftzug.Name = "lblFormEinstellungenEinstellungenSchriftzug";
            lblFormEinstellungenEinstellungenSchriftzug.Size = new Size(215, 36);
            lblFormEinstellungenEinstellungenSchriftzug.TabIndex = 2;
            lblFormEinstellungenEinstellungenSchriftzug.Text = "Einstellungen";
            // 
            // Einstellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(553, 420);
            Controls.Add(lblFormEinstellungenEinstellungenSchriftzug);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Einstellungen";
            Text = "Einstellungen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormEinstellungenEinstellungenSchriftzug;
    }
}