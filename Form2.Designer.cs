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
            panelForm2Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picForm2Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picForm2Close).BeginInit();
            SuspendLayout();
            // 
            // panelForm2Left
            // 
            panelForm2Left.BackColor = Color.FromArgb(200, 230, 255);
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
            panelForm2Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picForm2Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picForm2Close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForm2Left;
        private Panel panelForm2Top;
        private Panel panelForm2Main;
        private PictureBox picForm2Minimize;
        private PictureBox picForm2Close;
    }
}