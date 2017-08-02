namespace RoyalTale2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.updateButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.filelocationLabel = new System.Windows.Forms.Label();
            this.filelocationBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.gameFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.updateProgressBar = new System.Windows.Forms.ProgressBar();
            this.getClientButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.updateOldMethodCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.updateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.updateButton.Location = new System.Drawing.Point(-2, 39);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 40);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.startButton.Location = new System.Drawing.Point(667, 499);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 40);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.exitButton.Location = new System.Drawing.Point(16, 496);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(151, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // filelocationLabel
            // 
            this.filelocationLabel.AutoSize = true;
            this.filelocationLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filelocationLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filelocationLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.filelocationLabel.Location = new System.Drawing.Point(322, 512);
            this.filelocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filelocationLabel.Name = "filelocationLabel";
            this.filelocationLabel.Size = new System.Drawing.Size(105, 17);
            this.filelocationLabel.TabIndex = 6;
            this.filelocationLabel.Text = "File Location";
            // 
            // filelocationBox
            // 
            this.filelocationBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filelocationBox.ForeColor = System.Drawing.Color.LavenderBlush;
            this.filelocationBox.Location = new System.Drawing.Point(430, 510);
            this.filelocationBox.Margin = new System.Windows.Forms.Padding(2);
            this.filelocationBox.Name = "filelocationBox";
            this.filelocationBox.Size = new System.Drawing.Size(120, 20);
            this.filelocationBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.searchButton.Location = new System.Drawing.Point(553, 509);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox.ForeColor = System.Drawing.Color.LavenderBlush;
            this.checkBox.Location = new System.Drawing.Point(0, 12);
            this.checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(74, 17);
            this.checkBox.TabIndex = 12;
            this.checkBox.Text = "Fullscreen";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // gameFileDialog
            // 
            this.gameFileDialog.FileName = "LaTaleClient.exe";
            this.gameFileDialog.Filter = "Executable|*.exe";
            // 
            // updateProgressBar
            // 
            this.updateProgressBar.Location = new System.Drawing.Point(0, 85);
            this.updateProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.updateProgressBar.Name = "updateProgressBar";
            this.updateProgressBar.Size = new System.Drawing.Size(118, 23);
            this.updateProgressBar.TabIndex = 13;
            // 
            // getClientButton
            // 
            this.getClientButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.getClientButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getClientButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.getClientButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getClientButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.getClientButton.Location = new System.Drawing.Point(16, 401);
            this.getClientButton.Margin = new System.Windows.Forms.Padding(2);
            this.getClientButton.Name = "getClientButton";
            this.getClientButton.Size = new System.Drawing.Size(151, 30);
            this.getClientButton.TabIndex = 14;
            this.getClientButton.Text = " Get Client";
            this.getClientButton.UseVisualStyleBackColor = false;
            this.getClientButton.Click += new System.EventHandler(this.getClientButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RoyalTale2.Properties.Resources.logo4roy;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = global::RoyalTale2.Properties.Resources.logo4roy;
            this.pictureBox1.Location = new System.Drawing.Point(239, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // registerButton
            // 
            this.registerButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.registerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.registerButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.registerButton.Location = new System.Drawing.Point(16, 448);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(151, 30);
            this.registerButton.TabIndex = 16;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // updateOldMethodCheckBox
            // 
            this.updateOldMethodCheckBox.AutoSize = true;
            this.updateOldMethodCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateOldMethodCheckBox.ForeColor = System.Drawing.Color.LavenderBlush;
            this.updateOldMethodCheckBox.Location = new System.Drawing.Point(0, 115);
            this.updateOldMethodCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateOldMethodCheckBox.Name = "updateOldMethodCheckBox";
            this.updateOldMethodCheckBox.Size = new System.Drawing.Size(81, 17);
            this.updateOldMethodCheckBox.TabIndex = 17;
            this.updateOldMethodCheckBox.Text = "Old Method";
            this.updateOldMethodCheckBox.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 552);
            this.Controls.Add(this.updateOldMethodCheckBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.getClientButton);
            this.Controls.Add(this.updateProgressBar);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.filelocationBox);
            this.Controls.Add(this.filelocationLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.updateButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(813, 591);
            this.MinimumSize = new System.Drawing.Size(813, 591);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label filelocationLabel;
        private System.Windows.Forms.TextBox filelocationBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.OpenFileDialog gameFileDialog;
        private System.Windows.Forms.ProgressBar updateProgressBar;
        private System.Windows.Forms.Button getClientButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.CheckBox updateOldMethodCheckBox;
    }
}

