namespace MyStream
{
    partial class Form3
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategoryContent = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblSynopsisContent = new System.Windows.Forms.Label();
            this.lblGenreContent = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatusContent = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblReleasedContent = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.lblCategory);
            this.panel3.Controls.Add(this.lblCategoryContent);
            this.panel3.Controls.Add(this.lblSynopsis);
            this.panel3.Controls.Add(this.lblSynopsisContent);
            this.panel3.Controls.Add(this.lblGenreContent);
            this.panel3.Controls.Add(this.lblGenre);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(143, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(214, 327);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "title";
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
            // lblSynopsisContent
            // 
            this.lblSynopsisContent.AutoSize = true;
            this.lblSynopsisContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynopsisContent.Location = new System.Drawing.Point(116, 105);
            this.lblSynopsisContent.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblSynopsisContent.Name = "lblSynopsisContent";
            this.lblSynopsisContent.Size = new System.Drawing.Size(75, 20);
            this.lblSynopsisContent.TabIndex = 7;
            this.lblSynopsisContent.Text = "synopsis";
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
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(44, 85);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(65, 20);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStatusContent);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblReleasedContent);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(143, 327);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblStatusContent
            // 
            this.lblStatusContent.AutoSize = true;
            this.lblStatusContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatusContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusContent.Location = new System.Drawing.Point(10, 215);
            this.lblStatusContent.Name = "lblStatusContent";
            this.lblStatusContent.Size = new System.Drawing.Size(46, 17);
            this.lblStatusContent.TabIndex = 13;
            this.lblStatusContent.Text = "status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 198);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 17);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Released :";
            // 
            // lblReleasedContent
            // 
            this.lblReleasedContent.AutoSize = true;
            this.lblReleasedContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReleasedContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleasedContent.Location = new System.Drawing.Point(10, 181);
            this.lblReleasedContent.Name = "lblReleasedContent";
            this.lblReleasedContent.Size = new System.Drawing.Size(63, 17);
            this.lblReleasedContent.TabIndex = 11;
            this.lblReleasedContent.Text = "released";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 327);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 123);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryContent;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblSynopsisContent;
        private System.Windows.Forms.Label lblGenreContent;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatusContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblReleasedContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}