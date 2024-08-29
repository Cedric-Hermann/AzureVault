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
            lblCloseForm1 = new Label();
            SuspendLayout();
            // 
            // lblCloseForm1
            // 
            lblCloseForm1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCloseForm1.AutoSize = true;
            lblCloseForm1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblCloseForm1.ForeColor = Color.FromArgb(0, 117, 214);
            lblCloseForm1.Location = new Point(108, 394);
            lblCloseForm1.Name = "lblCloseForm1";
            lblCloseForm1.Size = new Size(76, 16);
            lblCloseForm1.TabIndex = 6;
            lblCloseForm1.Text = "Schließen";
            lblCloseForm1.Click += lblCloseForm1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(292, 447);
            Controls.Add(lblCloseForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCloseForm1;
    }
}
