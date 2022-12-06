namespace MyStream
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnRecent = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtbSearch = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTop);
            this.panel1.Controls.Add(this.btnRecent);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.rtbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(642, 0);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(200, 56);
            this.btnTop.TabIndex = 3;
            this.btnTop.Text = "Top Airing";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnRecent
            // 
            this.btnRecent.Location = new System.Drawing.Point(436, 0);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(200, 56);
            this.btnRecent.TabIndex = 2;
            this.btnRecent.Text = "New Releases";
            this.btnRecent.UseVisualStyleBackColor = true;
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(318, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtbSearch
            // 
            this.rtbSearch.Location = new System.Drawing.Point(12, 12);
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.Size = new System.Drawing.Size(300, 30);
            this.rtbSearch.TabIndex = 0;
            this.rtbSearch.Text = "";
            this.rtbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbSearch_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(848, 687);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 685);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 58);
            this.panel2.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Image = global::MyStream.Properties.Resources.skip_next_FILL0_wght400_GRAD0_opsz48;
            this.btnNext.Location = new System.Drawing.Point(740, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 58);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.Image = global::MyStream.Properties.Resources.skip_previous_FILL0_wght400_GRAD0_opsz48;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(108, 58);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 743);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}

