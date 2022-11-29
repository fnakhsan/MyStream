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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGenreContent = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblCategoryContent = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblSynopsisContent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(240, 296);
            this.panel2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Released :";
            // 
            // lblGenreContent
            // 
            this.lblGenreContent.AutoSize = true;
            this.lblGenreContent.Location = new System.Drawing.Point(114, 109);
            this.lblGenreContent.Name = "lblGenreContent";
            this.lblGenreContent.Size = new System.Drawing.Size(42, 16);
            this.lblGenreContent.TabIndex = 9;
            this.lblGenreContent.Text = "genre";
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(15, 74);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(69, 16);
            this.lblSynopsis.TabIndex = 6;
            this.lblSynopsis.Text = "Synopsis :";
            // 
            // lblCategoryContent
            // 
            this.lblCategoryContent.AutoSize = true;
            this.lblCategoryContent.Location = new System.Drawing.Point(246, 43);
            this.lblCategoryContent.Name = "lblCategoryContent";
            this.lblCategoryContent.Size = new System.Drawing.Size(60, 16);
            this.lblCategoryContent.TabIndex = 5;
            this.lblCategoryContent.Text = "category";
            this.lblCategoryContent.Click += new System.EventHandler(this.lblCategoryContent_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 43);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 16);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(33, 109);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(50, 16);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre :";
            // 
            // lblSynopsisContent
            // 
            this.lblSynopsisContent.AutoSize = true;
            this.lblSynopsisContent.Location = new System.Drawing.Point(114, 74);
            this.lblSynopsisContent.Name = "lblSynopsisContent";
            this.lblSynopsisContent.Size = new System.Drawing.Size(61, 16);
            this.lblSynopsisContent.TabIndex = 7;
            this.lblSynopsisContent.Text = "synopsis";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.lblCategory);
            this.panel3.Controls.Add(this.lblCategoryContent);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblSynopsis);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblSynopsisContent);
            this.panel3.Controls.Add(this.lblGenreContent);
            this.panel3.Controls.Add(this.lblGenre);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(246, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 296);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGenreContent;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblCategoryContent;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblSynopsisContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
