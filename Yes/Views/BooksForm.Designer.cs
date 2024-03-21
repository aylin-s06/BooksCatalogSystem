namespace Yes.Views
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.BooksImage = new System.Windows.Forms.PictureBox();
            this.BackButtonBox = new System.Windows.Forms.PictureBox();
            this.NextButtonBox = new System.Windows.Forms.PictureBox();
            this.BookNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButtonBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByLabel.Location = new System.Drawing.Point(31, 158);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(215, 23);
            this.SearchByLabel.TabIndex = 15;
            this.SearchByLabel.Text = "Search by Book Name";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(361, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(382, 48);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.Text = "Books Catalog System";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // PageTitleLabel
            // 
            this.PageTitleLabel.AutoSize = true;
            this.PageTitleLabel.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitleLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PageTitleLabel.Location = new System.Drawing.Point(502, 66);
            this.PageTitleLabel.Name = "PageTitleLabel";
            this.PageTitleLabel.Size = new System.Drawing.Size(121, 44);
            this.PageTitleLabel.TabIndex = 17;
            this.PageTitleLabel.Text = "Books ";
            this.PageTitleLabel.Click += new System.EventHandler(this.SearchByLabel_Click);
            // 
            // BooksdataGridView
            // 
            this.BooksdataGridView.BackgroundColor = System.Drawing.Color.Tan;
            this.BooksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BooksdataGridView.Location = new System.Drawing.Point(298, 158);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.RowHeadersWidth = 51;
            this.BooksdataGridView.RowTemplate.Height = 24;
            this.BooksdataGridView.Size = new System.Drawing.Size(767, 280);
            this.BooksdataGridView.TabIndex = 18;
            this.BooksdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksdataGridView_CellContentClick);
            // 
            // BooksImage
            // 
            this.BooksImage.Image = ((System.Drawing.Image)(resources.GetObject("BooksImage.Image")));
            this.BooksImage.Location = new System.Drawing.Point(90, 260);
            this.BooksImage.Name = "BooksImage";
            this.BooksImage.Size = new System.Drawing.Size(84, 62);
            this.BooksImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BooksImage.TabIndex = 19;
            this.BooksImage.TabStop = false;
            this.BooksImage.Click += new System.EventHandler(this.BooksImage_Click);
            // 
            // BackButtonBox
            // 
            this.BackButtonBox.Image = ((System.Drawing.Image)(resources.GetObject("BackButtonBox.Image")));
            this.BackButtonBox.Location = new System.Drawing.Point(12, 12);
            this.BackButtonBox.Name = "BackButtonBox";
            this.BackButtonBox.Size = new System.Drawing.Size(74, 65);
            this.BackButtonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButtonBox.TabIndex = 20;
            this.BackButtonBox.TabStop = false;
            this.BackButtonBox.Click += new System.EventHandler(this.BackButtonBox_Click);
            // 
            // NextButtonBox
            // 
            this.NextButtonBox.Image = ((System.Drawing.Image)(resources.GetObject("NextButtonBox.Image")));
            this.NextButtonBox.Location = new System.Drawing.Point(991, 9);
            this.NextButtonBox.Name = "NextButtonBox";
            this.NextButtonBox.Size = new System.Drawing.Size(74, 65);
            this.NextButtonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextButtonBox.TabIndex = 22;
            this.NextButtonBox.TabStop = false;
            this.NextButtonBox.Click += new System.EventHandler(this.NextButtonBox_Click);
            // 
            // BookNameBox
            // 
            this.BookNameBox.Location = new System.Drawing.Point(35, 209);
            this.BookNameBox.Name = "BookNameBox";
            this.BookNameBox.Size = new System.Drawing.Size(211, 22);
            this.BookNameBox.TabIndex = 23;
            this.BookNameBox.TextChanged += new System.EventHandler(this.BookNameBox_TextChanged);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1087, 490);
            this.Controls.Add(this.BookNameBox);
            this.Controls.Add(this.NextButtonBox);
            this.Controls.Add(this.BackButtonBox);
            this.Controls.Add(this.BooksImage);
            this.Controls.Add(this.BooksdataGridView);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SearchByLabel);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButtonBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.DataGridView BooksdataGridView;
        private System.Windows.Forms.PictureBox BooksImage;
        private System.Windows.Forms.PictureBox BackButtonBox;
        private System.Windows.Forms.PictureBox NextButtonBox;
        private System.Windows.Forms.TextBox BookNameBox;
    }
}