namespace Welcome_Form
{
    partial class welcomeForm
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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.bragLabel = new System.Windows.Forms.Label();
            this.computerButton = new System.Windows.Forms.Button();
            this.softwareButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.greetingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greetingLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.ForeColor = System.Drawing.Color.Blue;
            this.greetingLabel.Location = new System.Drawing.Point(100, 30);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(370, 40);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Welcome to SuperSoft";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bragLabel
            // 
            this.bragLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bragLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bragLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bragLabel.ForeColor = System.Drawing.Color.Blue;
            this.bragLabel.Location = new System.Drawing.Point(100, 90);
            this.bragLabel.Name = "bragLabel";
            this.bragLabel.Size = new System.Drawing.Size(310, 70);
            this.bragLabel.TabIndex = 1;
            this.bragLabel.Text = "The BEST Prices";
            this.bragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerButton
            // 
            this.computerButton.Location = new System.Drawing.Point(139, 277);
            this.computerButton.Name = "computerButton";
            this.computerButton.Size = new System.Drawing.Size(136, 63);
            this.computerButton.TabIndex = 2;
            this.computerButton.Text = "Best Computer";
            this.computerButton.UseVisualStyleBackColor = true;
            this.computerButton.Click += new System.EventHandler(this.showComputer);
            // 
            // softwareButton
            // 
            this.softwareButton.Location = new System.Drawing.Point(334, 277);
            this.softwareButton.Name = "softwareButton";
            this.softwareButton.Size = new System.Drawing.Size(136, 63);
            this.softwareButton.TabIndex = 3;
            this.softwareButton.Text = "Best Software";
            this.softwareButton.UseVisualStyleBackColor = true;
            this.softwareButton.Click += new System.EventHandler(this.showSoftware);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(583, 282);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(107, 52);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeApplication);
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.softwareButton);
            this.Controls.Add(this.computerButton);
            this.Controls.Add(this.bragLabel);
            this.Controls.Add(this.greetingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "welcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperSoft Software Co.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label bragLabel;
        private System.Windows.Forms.Button computerButton;
        private System.Windows.Forms.Button softwareButton;
        private System.Windows.Forms.Button quitButton;
    }
}

