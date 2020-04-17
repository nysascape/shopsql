namespace databaseTesting
{
    partial class loginForm
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
            this._loginUsernameBox = new System.Windows.Forms.TextBox();
            this._loginUsernameLabel = new System.Windows.Forms.Label();
            this._loginPasswordLabel = new System.Windows.Forms.Label();
            this._loginPasswordBox = new System.Windows.Forms.TextBox();
            this._loginLoginButton = new System.Windows.Forms.Button();
            this._loginLoginIncorrectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _loginUsernameBox
            // 
            this._loginUsernameBox.Location = new System.Drawing.Point(77, 10);
            this._loginUsernameBox.Name = "_loginUsernameBox";
            this._loginUsernameBox.Size = new System.Drawing.Size(122, 20);
            this._loginUsernameBox.TabIndex = 0;
            // 
            // _loginUsernameLabel
            // 
            this._loginUsernameLabel.AutoSize = true;
            this._loginUsernameLabel.Location = new System.Drawing.Point(13, 13);
            this._loginUsernameLabel.Name = "_loginUsernameLabel";
            this._loginUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this._loginUsernameLabel.TabIndex = 1;
            this._loginUsernameLabel.Text = "Username:";
            // 
            // _loginPasswordLabel
            // 
            this._loginPasswordLabel.AutoSize = true;
            this._loginPasswordLabel.Location = new System.Drawing.Point(15, 42);
            this._loginPasswordLabel.Name = "_loginPasswordLabel";
            this._loginPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this._loginPasswordLabel.TabIndex = 2;
            this._loginPasswordLabel.Text = "Password:";
            // 
            // _loginPasswordBox
            // 
            this._loginPasswordBox.Location = new System.Drawing.Point(77, 39);
            this._loginPasswordBox.Name = "_loginPasswordBox";
            this._loginPasswordBox.Size = new System.Drawing.Size(122, 20);
            this._loginPasswordBox.TabIndex = 3;
            // 
            // _loginLoginButton
            // 
            this._loginLoginButton.Location = new System.Drawing.Point(124, 87);
            this._loginLoginButton.Name = "_loginLoginButton";
            this._loginLoginButton.Size = new System.Drawing.Size(75, 23);
            this._loginLoginButton.TabIndex = 4;
            this._loginLoginButton.Text = "Login";
            this._loginLoginButton.UseVisualStyleBackColor = true;
            this._loginLoginButton.Click += new System.EventHandler(this._loginLoginButton_Click);
            // 
            // _loginLoginIncorrectLabel
            // 
            this._loginLoginIncorrectLabel.AutoSize = true;
            this._loginLoginIncorrectLabel.ForeColor = System.Drawing.Color.DarkRed;
            this._loginLoginIncorrectLabel.Location = new System.Drawing.Point(97, 68);
            this._loginLoginIncorrectLabel.Name = "_loginLoginIncorrectLabel";
            this._loginLoginIncorrectLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._loginLoginIncorrectLabel.Size = new System.Drawing.Size(102, 13);
            this._loginLoginIncorrectLabel.TabIndex = 5;
            this._loginLoginIncorrectLabel.Text = "Username incorrect!";
            this._loginLoginIncorrectLabel.Visible = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 122);
            this.Controls.Add(this._loginLoginIncorrectLabel);
            this.Controls.Add(this._loginLoginButton);
            this.Controls.Add(this._loginPasswordBox);
            this.Controls.Add(this._loginPasswordLabel);
            this.Controls.Add(this._loginUsernameLabel);
            this.Controls.Add(this._loginUsernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "loginForm";
            this.Text = "Shop Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _loginUsernameBox;
        private System.Windows.Forms.Label _loginUsernameLabel;
        private System.Windows.Forms.Label _loginPasswordLabel;
        private System.Windows.Forms.TextBox _loginPasswordBox;
        private System.Windows.Forms.Button _loginLoginButton;
        private System.Windows.Forms.Label _loginLoginIncorrectLabel;
    }
}

