namespace Yes.Views
{
    partial class AuthorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsForm));
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.BooksByAuthordataGridView = new System.Windows.Forms.DataGridView();
            this.BackButtonBox = new System.Windows.Forms.PictureBox();
            this.NextButtonBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AuthorNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BooksByAuthordataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButtonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByLabel.Location = new System.Drawing.Point(213, 212);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(240, 23);
            this.SearchByLabel.TabIndex = 21;
            this.SearchByLabel.Text = "Search by Author Name ";
            this.SearchByLabel.Click += new System.EventHandler(this.SearchByLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(359, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(382, 48);
            this.TitleLabel.TabIndex = 22;
            this.TitleLabel.Text = "Books Catalog System";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // PageTitleLabel
            // 
            this.PageTitleLabel.AutoSize = true;
            this.PageTitleLabel.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitleLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PageTitleLabel.Location = new System.Drawing.Point(399, 88);
            this.PageTitleLabel.Name = "PageTitleLabel";
            this.PageTitleLabel.Size = new System.Drawing.Size(294, 44);
            this.PageTitleLabel.TabIndex = 23;
            this.PageTitleLabel.Text = "Books By Authors";
            this.PageTitleLabel.Click += new System.EventHandler(this.PageTitleLabel_Click);
            // 
            // BooksByAuthordataGridView
            // 
            this.BooksByAuthordataGridView.BackgroundColor = System.Drawing.Color.Tan;
            this.BooksByAuthordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksByAuthordataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BooksByAuthordataGridView.Location = new System.Drawing.Point(546, 192);
            this.BooksByAuthordataGridView.Name = "BooksByAuthordataGridView";
            this.BooksByAuthordataGridView.RowHeadersWidth = 51;
            this.BooksByAuthordataGridView.RowTemplate.Height = 24;
            this.BooksByAuthordataGridView.Size = new System.Drawing.Size(475, 230);
            this.BooksByAuthordataGridView.TabIndex = 24;
            this.BooksByAuthordataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksByAuthordataGridView_CellContentClick);
            // 
            // BackButtonBox
            // 
            this.BackButtonBox.Image = ((System.Drawing.Image)(resources.GetObject("BackButtonBox.Image")));
            this.BackButtonBox.Location = new System.Drawing.Point(21, 12);
            this.BackButtonBox.Name = "BackButtonBox";
            this.BackButtonBox.Size = new System.Drawing.Size(74, 65);
            this.BackButtonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButtonBox.TabIndex = 25;
            this.BackButtonBox.TabStop = false;
            this.BackButtonBox.Click += new System.EventHandler(this.BackButtonBox_Click);
            // 
            // NextButtonBox
            // 
            this.NextButtonBox.Image = ((System.Drawing.Image)(resources.GetObject("NextButtonBox.Image")));
            this.NextButtonBox.Location = new System.Drawing.Point(1001, 12);
            this.NextButtonBox.Name = "NextButtonBox";
            this.NextButtonBox.Size = new System.Drawing.Size(74, 65);
            this.NextButtonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextButtonBox.TabIndex = 26;
            this.NextButtonBox.TabStop = false;
            this.NextButtonBox.Click += new System.EventHandler(this.NextButtonBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AuthorNameBox
            // 
            this.AuthorNameBox.Location = new System.Drawing.Point(217, 238);
            this.AuthorNameBox.Name = "AuthorNameBox";
            this.AuthorNameBox.Size = new System.Drawing.Size(219, 22);
            this.AuthorNameBox.TabIndex = 28;
            this.AuthorNameBox.TextChanged += new System.EventHandler(this.AuthorNameBox_TextChanged);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1087, 490);
            this.Controls.Add(this.AuthorNameBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NextButtonBox);
            this.Controls.Add(this.BackButtonBox);
            this.Controls.Add(this.BooksByAuthordataGridView);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SearchByLabel);
            this.Name = "AuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.BooksByAuthordataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButtonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.DataGridView BooksByAuthordataGridView;
        private System.Windows.Forms.PictureBox BackButtonBox;
        private System.Windows.Forms.PictureBox NextButtonBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox AuthorNameBox;
    }
}