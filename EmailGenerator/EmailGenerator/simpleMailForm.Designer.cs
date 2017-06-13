namespace EmailGenerator
{
    partial class simpleMailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(simpleMailForm));
            this.lblSendersEmail = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblEmailBody = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtReceiverMail = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtSenderMail = new System.Windows.Forms.TextBox();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSenderPW = new System.Windows.Forms.TextBox();
            this.lblSenderPW = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReceiverEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSendersEmail
            // 
            this.lblSendersEmail.AutoSize = true;
            this.lblSendersEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblSendersEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendersEmail.Location = new System.Drawing.Point(38, 120);
            this.lblSendersEmail.Name = "lblSendersEmail";
            this.lblSendersEmail.Size = new System.Drawing.Size(137, 15);
            this.lblSendersEmail.TabIndex = 1;
            this.lblSendersEmail.Text = "Sender\'s email address";
            this.lblSendersEmail.Click += new System.EventHandler(this.lblSendersEmail_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(38, 220);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(48, 15);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Subject";
            this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
            // 
            // lblEmailBody
            // 
            this.lblEmailBody.AutoSize = true;
            this.lblEmailBody.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailBody.Location = new System.Drawing.Point(38, 257);
            this.lblEmailBody.Name = "lblEmailBody";
            this.lblEmailBody.Size = new System.Drawing.Size(58, 15);
            this.lblEmailBody.TabIndex = 4;
            this.lblEmailBody.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(42, 388);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(133, 388);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtReceiverMail
            // 
            this.txtReceiverMail.Location = new System.Drawing.Point(203, 184);
            this.txtReceiverMail.Name = "txtReceiverMail";
            this.txtReceiverMail.Size = new System.Drawing.Size(190, 20);
            this.txtReceiverMail.TabIndex = 8;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(203, 256);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(250, 103);
            this.txtMessage.TabIndex = 9;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(203, 219);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(190, 20);
            this.txtSubject.TabIndex = 10;
            // 
            // txtSenderMail
            // 
            this.txtSenderMail.Location = new System.Drawing.Point(203, 122);
            this.txtSenderMail.Name = "txtSenderMail";
            this.txtSenderMail.Size = new System.Drawing.Size(190, 20);
            this.txtSenderMail.TabIndex = 11;
            this.txtSenderMail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblcopyright.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcopyright.Location = new System.Drawing.Point(201, 451);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(74, 10);
            this.lblcopyright.TabIndex = 12;
            this.lblcopyright.Text = "StickWithMe c 2017";
            this.lblcopyright.Click += new System.EventHandler(this.lblcopyright_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSenderPW
            // 
            this.txtSenderPW.Location = new System.Drawing.Point(203, 152);
            this.txtSenderPW.Name = "txtSenderPW";
            this.txtSenderPW.Size = new System.Drawing.Size(190, 20);
            this.txtSenderPW.TabIndex = 14;
            // 
            // lblSenderPW
            // 
            this.lblSenderPW.AutoSize = true;
            this.lblSenderPW.BackColor = System.Drawing.Color.Transparent;
            this.lblSenderPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderPW.Location = new System.Drawing.Point(38, 153);
            this.lblSenderPW.Name = "lblSenderPW";
            this.lblSenderPW.Size = new System.Drawing.Size(146, 15);
            this.lblSenderPW.TabIndex = 15;
            this.lblSenderPW.Text = "Sender\'s email password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblReceiverEmail
            // 
            this.lblReceiverEmail.AutoSize = true;
            this.lblReceiverEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiverEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverEmail.Location = new System.Drawing.Point(38, 184);
            this.lblReceiverEmail.Name = "lblReceiverEmail";
            this.lblReceiverEmail.Size = new System.Drawing.Size(145, 15);
            this.lblReceiverEmail.TabIndex = 2;
            this.lblReceiverEmail.Text = "Receiver\'s email address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 7);
            this.label1.TabIndex = 18;
            this.label1.Text = "V1.0";
            // 
            // simpleMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(491, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSenderPW);
            this.Controls.Add(this.txtSenderPW);
            this.Controls.Add(this.lblcopyright);
            this.Controls.Add(this.txtSenderMail);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtReceiverMail);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblEmailBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblReceiverEmail);
            this.Controls.Add(this.lblSendersEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "simpleMailForm";
            this.Text = "simpleMailForm";
            this.Load += new System.EventHandler(this.simpleMailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSendersEmail;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblEmailBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtReceiverMail;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtSenderMail;
        private System.Windows.Forms.Label lblcopyright;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSenderPW;
        private System.Windows.Forms.Label lblSenderPW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReceiverEmail;
        private System.Windows.Forms.Label label1;
    }
}