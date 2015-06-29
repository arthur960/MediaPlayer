namespace MediaPlayer
{
    partial class PlaylistForm
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
            this.playlistadd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // playlistadd
            // 
            this.playlistadd.BackColor = System.Drawing.Color.DodgerBlue;
            this.playlistadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playlistadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistadd.ForeColor = System.Drawing.Color.Transparent;
            this.playlistadd.Location = new System.Drawing.Point(12, 12);
            this.playlistadd.Name = "playlistadd";
            this.playlistadd.Size = new System.Drawing.Size(31, 23);
            this.playlistadd.TabIndex = 0;
            this.playlistadd.Text = "+";
            this.playlistadd.UseVisualStyleBackColor = false;
            this.playlistadd.Click += new System.EventHandler(this.playlistadd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 303);
            this.listBox1.TabIndex = 1;
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MediaPlayer.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(239, 360);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.playlistadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaylistForm";
            this.Load += new System.EventHandler(this.PlaylistForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playlistadd;
        private System.Windows.Forms.ListBox listBox1;
    }
}