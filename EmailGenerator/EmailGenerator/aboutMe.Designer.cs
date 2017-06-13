namespace EmailGenerator
{
    partial class aboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutMe));
            this.lblAboutMe1 = new System.Windows.Forms.Label();
            this.lblAboutMe2 = new System.Windows.Forms.Label();
            this.lblAboutMe3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAboutMe1
            // 
            this.lblAboutMe1.AutoSize = true;
            this.lblAboutMe1.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutMe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutMe1.Location = new System.Drawing.Point(41, 113);
            this.lblAboutMe1.Name = "lblAboutMe1";
            this.lblAboutMe1.Size = new System.Drawing.Size(196, 13);
            this.lblAboutMe1.TabIndex = 0;
            this.lblAboutMe1.Text = "Developed by StickWithMe Team";
            // 
            // lblAboutMe2
            // 
            this.lblAboutMe2.AutoSize = true;
            this.lblAboutMe2.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutMe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutMe2.Location = new System.Drawing.Point(80, 132);
            this.lblAboutMe2.Name = "lblAboutMe2";
            this.lblAboutMe2.Size = new System.Drawing.Size(111, 12);
            this.lblAboutMe2.TabIndex = 1;
            this.lblAboutMe2.Text = "Developer Dilum De Silva";
            // 
            // lblAboutMe3
            // 
            this.lblAboutMe3.AutoSize = true;
            this.lblAboutMe3.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutMe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutMe3.Location = new System.Drawing.Point(87, 164);
            this.lblAboutMe3.Name = "lblAboutMe3";
            this.lblAboutMe3.Size = new System.Drawing.Size(97, 9);
            this.lblAboutMe3.TabIndex = 2;
            this.lblAboutMe3.Text = "2017 c All Rights Reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 7);
            this.label1.TabIndex = 16;
            this.label1.Text = "V1.0";
            // 
            // aboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(282, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAboutMe3);
            this.Controls.Add(this.lblAboutMe2);
            this.Controls.Add(this.lblAboutMe1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutMe";
            this.Text = "aboutMe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutMe1;
        private System.Windows.Forms.Label lblAboutMe2;
        private System.Windows.Forms.Label lblAboutMe3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}