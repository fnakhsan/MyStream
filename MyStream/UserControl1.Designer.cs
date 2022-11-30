namespace MyStream
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatusContent = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblReleasedContent = new System.Windows.Forms.Label();
            this.lblGenreContent = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblCategoryContent = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblSynopsisContent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 160);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(104, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.lblStatusContent);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblReleasedContent);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(240, 296);
            this.panel2.TabIndex = 13;
            // 
            // lblStatusContent
            // 
            this.lblStatusContent.AutoSize = true;
            this.lblStatusContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusContent.Location = new System.Drawing.Point(101, 187);
            this.lblStatusContent.Name = "lblStatusContent";
            this.lblStatusContent.Size = new System.Drawing.Size(46, 17);
            this.lblStatusContent.TabIndex = 13;
            this.lblStatusContent.Text = "status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(44, 187);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 17);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Released :";
            // 
            // lblReleasedContent
            // 
            this.lblReleasedContent.AutoSize = true;
            this.lblReleasedContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleasedContent.Location = new System.Drawing.Point(101, 170);
            this.lblReleasedContent.Name = "lblReleasedContent";
            this.lblReleasedContent.Size = new System.Drawing.Size(63, 17);
            this.lblReleasedContent.TabIndex = 11;
            this.lblReleasedContent.Text = "released";
            // 
            // lblGenreContent
            // 
            this.lblGenreContent.AutoSize = true;
            this.lblGenreContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreContent.Location = new System.Drawing.Point(115, 85);
            this.lblGenreContent.Name = "lblGenreContent";
            this.lblGenreContent.Size = new System.Drawing.Size(51, 20);
            this.lblGenreContent.TabIndex = 9;
            this.lblGenreContent.Text = "genre";
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynopsis.Location = new System.Drawing.Point(23, 105);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(87, 20);
            this.lblSynopsis.TabIndex = 6;
            this.lblSynopsis.Text = "Synopsis :";
            // 
            // lblCategoryContent
            // 
            this.lblCategoryContent.AutoSize = true;
            this.lblCategoryContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryContent.Location = new System.Drawing.Point(115, 62);
            this.lblCategoryContent.Name = "lblCategoryContent";
            this.lblCategoryContent.Size = new System.Drawing.Size(73, 20);
            this.lblCategoryContent.TabIndex = 5;
            this.lblCategoryContent.Text = "category";
            this.lblCategoryContent.Click += new System.EventHandler(this.lblCategoryContent_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(23, 62);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(86, 20);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category :";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(44, 85);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(65, 20);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre :";
            this.lblGenre.Click += new System.EventHandler(this.lblGenre_Click);
            // 
            // lblSynopsisContent
            // 
            this.lblSynopsisContent.AutoSize = true;
            this.lblSynopsisContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynopsisContent.Location = new System.Drawing.Point(116, 105);
            this.lblSynopsisContent.Name = "lblSynopsisContent";
            this.lblSynopsisContent.Size = new System.Drawing.Size(75, 20);
            this.lblSynopsisContent.TabIndex = 7;
            this.lblSynopsisContent.Text = "synopsis";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 39);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "title";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.lblCategory);
            this.panel3.Controls.Add(this.lblCategoryContent);
            this.panel3.Controls.Add(this.lblSynopsis);
            this.panel3.Controls.Add(this.lblSynopsisContent);
            this.panel3.Controls.Add(this.lblGenreContent);
            this.panel3.Controls.Add(this.lblGenre);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(246, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(510, 296);
            this.panel3.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::MyStream.Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz48;
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 24);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(756, 456);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReleasedContent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGenreContent;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblCategoryContent;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblSynopsisContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatusContent;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBack;
    }
}
