namespace AzureVault
{
    partial class Zugangsdaten
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
            lblFormZugangsdatenZugangsdatenSchriftzug = new Label();
            SuspendLayout();
            // 
            // lblFormZugangsdatenZugangsdatenSchriftzug
            // 
            lblFormZugangsdatenZugangsdatenSchriftzug.Anchor = AnchorStyles.None;
            lblFormZugangsdatenZugangsdatenSchriftzug.AutoSize = true;
            lblFormZugangsdatenZugangsdatenSchriftzug.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            lblFormZugangsdatenZugangsdatenSchriftzug.ForeColor = Color.FromArgb(0, 117, 214);
            lblFormZugangsdatenZugangsdatenSchriftzug.Location = new Point(12, 9);
            lblFormZugangsdatenZugangsdatenSchriftzug.Name = "lblFormZugangsdatenZugangsdatenSchriftzug";
            lblFormZugangsdatenZugangsdatenSchriftzug.Size = new Size(229, 36);
            lblFormZugangsdatenZugangsdatenSchriftzug.TabIndex = 3;
            lblFormZugangsdatenZugangsdatenSchriftzug.Text = "Zugangsdaten";
            // 
            // Zugangsdaten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(553, 420);
            Controls.Add(lblFormZugangsdatenZugangsdatenSchriftzug);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Zugangsdaten";
            Text = "Zugangsdaten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormZugangsdatenZugangsdatenSchriftzug;
    }
}