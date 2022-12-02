namespace MyStream
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn1080p = new System.Windows.Forms.Button();
            this.btn720p = new System.Windows.Forms.Button();
            this.btn480p = new System.Windows.Forms.Button();
            this.btn360p = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 60);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(1280, 720);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn1080p);
            this.panel2.Controls.Add(this.btn720p);
            this.panel2.Controls.Add(this.btn480p);
            this.panel2.Controls.Add(this.btn360p);
            this.panel2.Controls.Add(this.btnDefault);
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 780);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 76);
            this.panel2.TabIndex = 2;
            // 
            // btn1080p
            // 
            this.btn1080p.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1080p.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn1080p.Location = new System.Drawing.Point(1020, 0);
            this.btn1080p.Name = "btn1080p";
            this.btn1080p.Size = new System.Drawing.Size(152, 76);
            this.btn1080p.TabIndex = 8;
            this.btn1080p.Text = "1080p";
            this.btn1080p.UseVisualStyleBackColor = true;
            this.btn1080p.Visible = false;
            this.btn1080p.Click += new System.EventHandler(this.btn1080p_Click);
            // 
            // btn720p
            // 
            this.btn720p.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn720p.Location = new System.Drawing.Point(868, 0);
            this.btn720p.Name = "btn720p";
            this.btn720p.Size = new System.Drawing.Size(152, 76);
            this.btn720p.TabIndex = 9;
            this.btn720p.Text = "720p";
            this.btn720p.UseVisualStyleBackColor = true;
            this.btn720p.Visible = false;
            this.btn720p.Click += new System.EventHandler(this.btn720p_Click);
            // 
            // btn480p
            // 
            this.btn480p.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn480p.Location = new System.Drawing.Point(716, 0);
            this.btn480p.Name = "btn480p";
            this.btn480p.Size = new System.Drawing.Size(152, 76);
            this.btn480p.TabIndex = 7;
            this.btn480p.Text = "480p";
            this.btn480p.UseVisualStyleBackColor = true;
            this.btn480p.Visible = false;
            this.btn480p.Click += new System.EventHandler(this.btn480p_Click);
            // 
            // btn360p
            // 
            this.btn360p.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn360p.Location = new System.Drawing.Point(564, 0);
            this.btn360p.Name = "btn360p";
            this.btn360p.Size = new System.Drawing.Size(152, 76);
            this.btn360p.TabIndex = 6;
            this.btn360p.Text = "360p";
            this.btn360p.UseVisualStyleBackColor = true;
            this.btn360p.Click += new System.EventHandler(this.btn360p_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDefault.Location = new System.Drawing.Point(412, 0);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(152, 76);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Visible = false;
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPause.Location = new System.Drawing.Point(260, 0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(152, 76);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.Location = new System.Drawing.Point(108, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(152, 76);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPrevious);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(108, 76);
            this.panel4.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Image = global::MyStream.Properties.Resources.skip_previous_FILL0_wght400_GRAD0_opsz48;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(108, 76);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1172, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 76);
            this.panel3.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Image = global::MyStream.Properties.Resources.skip_next_FILL0_wght400_GRAD0_opsz48;
            this.btnNext.Location = new System.Drawing.Point(0, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 76);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 856);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn1080p;
        private System.Windows.Forms.Button btn720p;
        private System.Windows.Forms.Button btn480p;
        private System.Windows.Forms.Button btn360p;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}