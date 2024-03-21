namespace Yes.Views
{
    partial class GenresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenresForm));
            this.GenresComboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            this.BooksByGenredataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.BackButtonBox = new System.Windows.Forms.PictureBox();
            this.NextButtonBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BooksByGenredataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButtonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GenresComboBox
            // 
            this.GenresComboBox.FormattingEnabled = true;
            this.GenresComboBox.Location = new System.Drawing.Point(218, 218);
            this.GenresComboBox.Name = "GenresComboBox";
            this.GenresComboBox.Size = new System.Drawing.Size(260, 24);
            this.GenresComboBox.TabIndex = 0;
            this.GenresComboBox.SelectedIndexChanged += new System.EventHandler(this.GenresComboBox_SelectedIndexChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(351, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(382, 48);
            this.TitleLabel.TabIndex = 17;
            this.TitleLabel.Text = "Books Catalog System";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // PageTitleLabel
            // 
            this.PageTitleLabel.AutoSize = true;
            this.PageTitleLabel.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitleLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PageTitleLabel.Location = new System.Drawing.Point(406, 73);
            this.PageTitleLabel.Name = "PageTitleLabel";
            this.PageTitleLabel.Size = new System.Drawing.Size(275, 44);
            this.PageTitleLabel.TabIndex = 18;
            this.PageTitleLabel.Text = "Books By Genres";
            this.PageTitleLabel.Click += new System.EventHandler(this.PageTitleLabel_Click);
            // 
            // BooksByGenredataGridView1
            // 
            this.BooksByGenredataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.BooksByGenredataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksByGenredataGridView1.Location = new System.Drawing.Point(548, 161);
            this.BooksByGenredataGridView1.Name = "BooksByGenredataGridView1";
            this.BooksByGenredataGridView1.RowHeadersWidth = 51;
            this.BooksByGenredataGridView1.RowTemplate.Height = 24;
            this.BooksByGenredataGridView1.Size = new System.Drawing.Size(443, 235);
            this.BooksByGenredataGridView1.TabIndex = 19;
            this.BooksByGenredataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksByGenredataGridView1_CellContentClick);
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByLabel.Location = new System.Drawing.Point(278, 181);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(165, 23);
            this.SearchByLabel.TabIndex = 20;
            this.SearchByLabel.Text = "Search by Genre";
            this.SearchByLabel.Click += new System.EventHandler(this.SearchByLabel_Click);
            // 
            // BackButtonBox
            // 
            this.BackButtonBox.Image = ((System.Drawing.Image)(resources.GetObject("BackButtonBox.Image")));
            this.BackButtonBox.Location = new System.Drawing.Point(29, 9);
            this.BackButtonBox.Name = "BackButtonBox";
            this.BackButtonBox.Size = new System.Drawing.Size(74, 65);
            this.BackButtonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButtonBox.TabIndex = 26;
            this.BackButtonBox.TabStop = false;
            this.BackButtonBox.Click += new System.EventHandler(this.BackButtonBox_Click);
            // 
            // NextButtonBox
            // 
            this.NextButtonBox.Image = ((System.Drawing.Image)(resources.GetObject("NextButtonBox.Image")));
            this.NextButtonBox.Location = new System.Drawing.Point(985, 9);
            this.NextButtonBox.Name = "NextButtonBox";
            this.NextButtonBox.Size = new System.Drawing.Size(74, 65);
            this.NextButtonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextButtonBox.TabIndex = 27;
            this.NextButtonBox.TabStop = false;
            this.NextButtonBox.Click += new System.EventHandler(this.NextButtonBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1087, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NextButtonBox);
            this.Controls.Add(this.BackButtonBox);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.BooksByGenredataGridView1);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.GenresComboBox);
            this.Name = "GenresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenresForm";
            this.Load += new System.EventHandler(this.GenresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksByGenredataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButtonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GenresComboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label PageTitleLabel;
        private System.Windows.Forms.DataGridView BooksByGenredataGridView1;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.PictureBox BackButtonBox;
        private System.Windows.Forms.PictureBox NextButtonBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}