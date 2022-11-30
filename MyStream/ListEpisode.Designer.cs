namespace MyStream
{
    partial class ListEpisode
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
            this.lblEpisode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEpisode
            // 
            this.lblEpisode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisode.Location = new System.Drawing.Point(0, 0);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(100, 40);
            this.lblEpisode.TabIndex = 0;
            this.lblEpisode.Text = "Episode";
            this.lblEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEpisode.UseMnemonic = false;
            this.lblEpisode.Click += new System.EventHandler(this.lblEpisode_Click);
            // 
            // ListEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblEpisode);
            this.Name = "ListEpisode";
            this.Size = new System.Drawing.Size(100, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEpisode;
    }
}
