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
            this.btnDefault = new System.Windows.Forms.Button();
            this.btn360p = new System.Windows.Forms.Button();
            this.btn480p = new System.Windows.Forms.Button();
            this.btn720p = new System.Windows.Forms.Button();
            this.btn1080p = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblEpisode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.lblEpisode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDefault);
            this.panel2.Controls.Add(this.btn360p);
            this.panel2.Controls.Add(this.btn480p);
            this.panel2.Controls.Add(this.btn720p);
            this.panel2.Controls.Add(this.btn1080p);
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 780);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 76);
            this.panel2.TabIndex = 2;
            // 
            // btnDefault
            // 
            this.btnDefault.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDefault.Location = new System.Drawing.Point(520, 0);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(152, 76);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Visible = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btn360p
            // 
            this.btn360p.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn360p.Location = new System.Drawing.Point(672, 0);
            this.btn360p.Name = "btn360p";
            this.btn360p.Size = new System.Drawing.Size(152, 76);
            this.btn360p.TabIndex = 6;
            this.btn360p.Text = "360p";
            this.btn360p.UseVisualStyleBackColor = true;
            this.btn360p.Visible = false;
            this.btn360p.Click += new System.EventHandler(this.btn360p_Click);
            // 
            // btn480p
            // 
            this.btn480p.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn480p.Location = new System.Drawing.Point(824, 0);
            this.btn480p.Name = "btn480p";
            this.btn480p.Size = new System.Drawing.Size(152, 76);
            this.btn480p.TabIndex = 7;
            this.btn480p.Text = "480p";
            this.btn480p.UseVisualStyleBackColor = true;
            this.btn480p.Visible = false;
            this.btn480p.Click += new System.EventHandler(this.btn480p_Click);
            // 
            // btn720p
            // 
            this.btn720p.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn720p.Location = new System.Drawing.Point(976, 0);
            this.btn720p.Name = "btn720p";
            this.btn720p.Size = new System.Drawing.Size(152, 76);
            this.btn720p.TabIndex = 9;
            this.btn720p.Text = "720p";
            this.btn720p.UseVisualStyleBackColor = true;
            this.btn720p.Visible = false;
            this.btn720p.Click += new System.EventHandler(this.btn720p_Click);
            // 
            // btn1080p
            // 
            this.btn1080p.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1080p.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn1080p.Location = new System.Drawing.Point(1128, 0);
            this.btn1080p.Name = "btn1080p";
            this.btn1080p.Size = new System.Drawing.Size(152, 76);
            this.btn1080p.TabIndex = 8;
            this.btn1080p.Text = "1080p";
            this.btn1080p.UseVisualStyleBackColor = true;
            this.btn1080p.Visible = false;
            this.btn1080p.Click += new System.EventHandler(this.btn1080p_Click);
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPause.Location = new System.Drawing.Point(0, 0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(152, 76);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblEpisode
            // 
            this.lblEpisode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisode.Location = new System.Drawing.Point(0, 0);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblEpisode.Size = new System.Drawing.Size(348, 60);
            this.lblEpisode.TabIndex = 0;
            this.lblEpisode.Text = "Episode";
            this.lblEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEpisode.UseMnemonic = false;
            this.lblEpisode.Click += new System.EventHandler(this.lblEpisode_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblEpisode;
    }
}