namespace Yes
{
    partial class IntroForm
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
            this.IntroTitleLabel = new System.Windows.Forms.Label();
            this.IntroFormLoad = new System.Windows.Forms.ProgressBar();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntroTitleLabel
            // 
            this.IntroTitleLabel.AutoSize = true;
            this.IntroTitleLabel.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroTitleLabel.Location = new System.Drawing.Point(129, 137);
            this.IntroTitleLabel.Name = "IntroTitleLabel";
            this.IntroTitleLabel.Size = new System.Drawing.Size(569, 72);
            this.IntroTitleLabel.TabIndex = 12;
            this.IntroTitleLabel.Text = "Books Catalog System";
            this.IntroTitleLabel.Click += new System.EventHandler(this.IntroTitleLabel_Click);
            // 
            // IntroFormLoad
            // 
            this.IntroFormLoad.Location = new System.Drawing.Point(141, 311);
            this.IntroFormLoad.Name = "IntroFormLoad";
            this.IntroFormLoad.Size = new System.Drawing.Size(533, 23);
            this.IntroFormLoad.TabIndex = 13;
            this.IntroFormLoad.Value = 100;
            this.IntroFormLoad.Click += new System.EventHandler(this.IntroFormLoad_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.Location = new System.Drawing.Point(352, 262);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(116, 28);
            this.LoadingLabel.TabIndex = 14;
            this.LoadingLabel.Text = "Loading...";
            this.LoadingLabel.Click += new System.EventHandler(this.LoadingLabel_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.IntroFormLoad);
            this.Controls.Add(this.IntroTitleLabel);
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroForm";
            this.Load += new System.EventHandler(this.IntroForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntroTitleLabel;
        private System.Windows.Forms.ProgressBar IntroFormLoad;
        private System.Windows.Forms.Label LoadingLabel;
    }
}