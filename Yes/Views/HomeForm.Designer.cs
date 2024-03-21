namespace Yes.Views
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.BooksFormButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TitleLable = new System.Windows.Forms.Label();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.AuthorsFormButton = new System.Windows.Forms.Button();
            this.GenresFormButton = new System.Windows.Forms.Button();
            this.ReviewsFormButton = new System.Windows.Forms.Button();
            this.ExitLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksFormButton
            // 
            this.BooksFormButton.BackColor = System.Drawing.Color.Tan;
            this.BooksFormButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksFormButton.Location = new System.Drawing.Point(312, 151);
            this.BooksFormButton.Name = "BooksFormButton";
            this.BooksFormButton.Size = new System.Drawing.Size(197, 70);
            this.BooksFormButton.TabIndex = 0;
            this.BooksFormButton.Text = "Books";
            this.BooksFormButton.UseVisualStyleBackColor = false;
            this.BooksFormButton.Click += new System.EventHandler(this.BooksFormButton_Click);
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLable.Location = new System.Drawing.Point(228, 9);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(382, 48);
            this.TitleLable.TabIndex = 7;
            this.TitleLable.Text = "Books Catalog System";
            this.TitleLable.Click += new System.EventHandler(this.TitleLable_Click);
            // 
            // PageTitleLabel
            // 
            this.PageTitleLabel.AutoSize = true;
            this.PageTitleLabel.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitleLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PageTitleLabel.Location = new System.Drawing.Point(304, 57);
            this.PageTitleLabel.Name = "PageTitleLabel";
            this.PageTitleLabel.Size = new System.Drawing.Size(194, 44);
            this.PageTitleLabel.TabIndex = 8;
            this.PageTitleLabel.Text = "Home Page";
            this.PageTitleLabel.Click += new System.EventHandler(this.PageTitleLabel_Click);
            // 
            // AuthorsFormButton
            // 
            this.AuthorsFormButton.BackColor = System.Drawing.Color.Tan;
            this.AuthorsFormButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorsFormButton.Location = new System.Drawing.Point(54, 232);
            this.AuthorsFormButton.Name = "AuthorsFormButton";
            this.AuthorsFormButton.Size = new System.Drawing.Size(197, 70);
            this.AuthorsFormButton.TabIndex = 12;
            this.AuthorsFormButton.Text = "Authors";
            this.AuthorsFormButton.UseVisualStyleBackColor = false;
            this.AuthorsFormButton.Click += new System.EventHandler(this.AuthorsFormButton_Click);
            // 
            // GenresFormButton
            // 
            this.GenresFormButton.BackColor = System.Drawing.Color.Tan;
            this.GenresFormButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenresFormButton.Location = new System.Drawing.Point(571, 232);
            this.GenresFormButton.Name = "GenresFormButton";
            this.GenresFormButton.Size = new System.Drawing.Size(197, 70);
            this.GenresFormButton.TabIndex = 13;
            this.GenresFormButton.Text = "Genres";
            this.GenresFormButton.UseVisualStyleBackColor = false;
            this.GenresFormButton.Click += new System.EventHandler(this.GenresFormButton_Click);
            // 
            // ReviewsFormButton
            // 
            this.ReviewsFormButton.BackColor = System.Drawing.Color.Tan;
            this.ReviewsFormButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewsFormButton.Location = new System.Drawing.Point(312, 343);
            this.ReviewsFormButton.Name = "ReviewsFormButton";
            this.ReviewsFormButton.Size = new System.Drawing.Size(197, 70);
            this.ReviewsFormButton.TabIndex = 14;
            this.ReviewsFormButton.Text = "Reviews";
            this.ReviewsFormButton.UseVisualStyleBackColor = false;
            this.ReviewsFormButton.Click += new System.EventHandler(this.ReviewsFormButton_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.Image = ((System.Drawing.Image)(resources.GetObject("ExitLabel.Image")));
            this.ExitLabel.Location = new System.Drawing.Point(774, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(31, 30);
            this.ExitLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitLabel.TabIndex = 15;
            this.ExitLabel.TabStop = false;
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.ReviewsFormButton);
            this.Controls.Add(this.GenresFormButton);
            this.Controls.Add(this.AuthorsFormButton);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.BooksFormButton);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.ExitLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BooksFormButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.Button AuthorsFormButton;
        private System.Windows.Forms.Button GenresFormButton;
        private System.Windows.Forms.Button ReviewsFormButton;
        private System.Windows.Forms.PictureBox ExitLabel;
    }
}