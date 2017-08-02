namespace RoyalTale2
{
    partial class RegisterForm
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
            this.registerUsernameLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerUsernameLabel
            // 
            this.registerUsernameLabel.AutoSize = true;
            this.registerUsernameLabel.Location = new System.Drawing.Point(9, 35);
            this.registerUsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerUsernameLabel.Name = "registerUsernameLabel";
            this.registerUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.registerUsernameLabel.TabIndex = 0;
            this.registerUsernameLabel.Text = "Username";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(68, 141);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(128, 24);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Complete Registration";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerUsernameTextBox
            // 
            this.registerUsernameTextBox.Location = new System.Drawing.Point(68, 32);
            this.registerUsernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerUsernameTextBox.Name = "registerUsernameTextBox";
            this.registerUsernameTextBox.Size = new System.Drawing.Size(184, 20);
            this.registerUsernameTextBox.TabIndex = 2;
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(68, 66);
            this.registerPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(184, 20);
            this.registerPasswordTextBox.TabIndex = 4;
            // 
            // registerPasswordLabel
            // 
            this.registerPasswordLabel.AutoSize = true;
            this.registerPasswordLabel.Location = new System.Drawing.Point(9, 68);
            this.registerPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerPasswordLabel.Name = "registerPasswordLabel";
            this.registerPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.registerPasswordLabel.TabIndex = 3;
            this.registerPasswordLabel.Text = "Password";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 185);
            this.Controls.Add(this.registerPasswordTextBox);
            this.Controls.Add(this.registerPasswordLabel);
            this.Controls.Add(this.registerUsernameTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerUsernameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerUsernameLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registerUsernameTextBox;
        private System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.Label registerPasswordLabel;
    }
}