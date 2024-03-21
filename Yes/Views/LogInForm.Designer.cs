namespace Yes.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserSignInButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.KeyPictureBox = new System.Windows.Forms.PictureBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // UserSignInButton
            // 
            this.UserSignInButton.BackColor = System.Drawing.Color.Sienna;
            this.UserSignInButton.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSignInButton.Location = new System.Drawing.Point(274, 354);
            this.UserSignInButton.Name = "UserSignInButton";
            this.UserSignInButton.Size = new System.Drawing.Size(286, 59);
            this.UserSignInButton.TabIndex = 0;
            this.UserSignInButton.Text = "Login ";
            this.UserSignInButton.UseVisualStyleBackColor = false;
            this.UserSignInButton.Click += new System.EventHandler(this.UserSignInButton_Click_1);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.BurlyWood;
            this.EmailTextBox.Location = new System.Drawing.Point(300, 193);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(244, 22);
            this.EmailTextBox.TabIndex = 2;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.BurlyWood;
            this.PasswordTextBox.Location = new System.Drawing.Point(300, 248);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(244, 22);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleLabel.Location = new System.Drawing.Point(142, 51);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(569, 72);
            this.LoginTitleLabel.TabIndex = 6;
            this.LoginTitleLabel.Text = "Books Catalog System";
            // 
            // KeyPictureBox
            // 
            this.KeyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("KeyPictureBox.Image")));
            this.KeyPictureBox.Location = new System.Drawing.Point(550, 242);
            this.KeyPictureBox.Name = "KeyPictureBox";
            this.KeyPictureBox.Size = new System.Drawing.Size(34, 35);
            this.KeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KeyPictureBox.TabIndex = 7;
            this.KeyPictureBox.TabStop = false;
            this.KeyPictureBox.Click += new System.EventHandler(this.KeyPictureBox_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(228, 193);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(65, 22);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(202, 248);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(91, 22);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "Password:";
            // 
            // ExitLabel
            // 
            this.ExitLabel.Image = ((System.Drawing.Image)(resources.GetObject("ExitLabel.Image")));
            this.ExitLabel.Location = new System.Drawing.Point(757, 12);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(31, 30);
            this.ExitLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitLabel.TabIndex = 13;
            this.ExitLabel.TabStop = false;
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.KeyPictureBox);
            this.Controls.Add(this.LoginTitleLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.UserSignInButton);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserSignInButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.PictureBox KeyPictureBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.PictureBox ExitLabel;
    }
}