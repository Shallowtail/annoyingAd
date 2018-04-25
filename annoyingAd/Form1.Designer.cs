namespace annoyingAd
{
    partial class BestAd
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
            this.components = new System.ComponentModel.Container();
            this.headline = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.desclabel = new System.Windows.Forms.Label();
            this.Moveup = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headline
            // 
            this.headline.Dock = System.Windows.Forms.DockStyle.Top;
            this.headline.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline.Location = new System.Drawing.Point(0, 0);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(315, 29);
            this.headline.TabIndex = 0;
            this.headline.Text = "You may be interested : ";
            this.headline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 238);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 320);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 35);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(202, 320);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 35);
            this.OK.TabIndex = 3;
            this.OK.Text = "ok";
            this.OK.UseMnemonic = false;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // desclabel
            // 
            this.desclabel.AutoSize = true;
            this.desclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclabel.Location = new System.Drawing.Point(13, 277);
            this.desclabel.Name = "desclabel";
            this.desclabel.Size = new System.Drawing.Size(51, 20);
            this.desclabel.TabIndex = 4;
            this.desclabel.Text = "label2";
            // 
            // Moveup
            // 
            this.Moveup.Enabled = true;
            this.Moveup.Interval = 10;
            this.Moveup.Tick += new System.EventHandler(this.Moveup_Tick);
            // 
            // BestAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 377);
            this.Controls.Add(this.desclabel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BestAd";
            this.Text = "BestAd\'s";
            this.Load += new System.EventHandler(this.BestAd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label desclabel;
        private System.Windows.Forms.Timer Moveup;
    }
}

