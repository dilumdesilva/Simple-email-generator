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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(simpleMailForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSendersEmail = new System.Windows.Forms.Label();
            this.lblReceiverEmail = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblEmailBody = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtReceiverMail = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtSenderMail = new System.Windows.Forms.TextBox();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Location = new System.Drawing.Point(119, 38);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(100, 13);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "DMS mail generator";
            // 
            // lblSendersEmail
            // 
            this.lblSendersEmail.AutoSize = true;
            this.lblSendersEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblSendersEmail.Location = new System.Drawing.Point(38, 106);
            this.lblSendersEmail.Name = "lblSendersEmail";
            this.lblSendersEmail.Size = new System.Drawing.Size(115, 13);
            this.lblSendersEmail.TabIndex = 1;
            this.lblSendersEmail.Text = "Sender\'s email address";
            // 
            // lblReceiverEmail
            // 
            this.lblReceiverEmail.AutoSize = true;
            this.lblReceiverEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiverEmail.Location = new System.Drawing.Point(38, 147);
            this.lblReceiverEmail.Name = "lblReceiverEmail";
            this.lblReceiverEmail.Size = new System.Drawing.Size(124, 13);
            this.lblReceiverEmail.TabIndex = 2;
            this.lblReceiverEmail.Text = "Receiver\'s email address";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Location = new System.Drawing.Point(38, 183);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Subject";
            // 
            // lblEmailBody
            // 
            this.lblEmailBody.AutoSize = true;
            this.lblEmailBody.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailBody.Location = new System.Drawing.Point(38, 221);
            this.lblEmailBody.Name = "lblEmailBody";
            this.lblEmailBody.Size = new System.Drawing.Size(50, 13);
            this.lblEmailBody.TabIndex = 4;
            this.lblEmailBody.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(41, 265);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(127, 265);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtReceiverMail
            // 
            this.txtReceiverMail.Location = new System.Drawing.Point(184, 144);
            this.txtReceiverMail.Name = "txtReceiverMail";
            this.txtReceiverMail.Size = new System.Drawing.Size(130, 20);
            this.txtReceiverMail.TabIndex = 8;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(184, 218);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(130, 20);
            this.txtMessage.TabIndex = 9;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(184, 180);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(130, 20);
            this.txtSubject.TabIndex = 10;
            // 
            // txtSenderMail
            // 
            this.txtSenderMail.Location = new System.Drawing.Point(184, 103);
            this.txtSenderMail.Name = "txtSenderMail";
            this.txtSenderMail.Size = new System.Drawing.Size(130, 20);
            this.txtSenderMail.TabIndex = 11;
            this.txtSenderMail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblcopyright.Font = new System.Drawing.Font("Copperplate Gothic Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcopyright.Location = new System.Drawing.Point(142, 325);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(60, 9);
            this.lblcopyright.TabIndex = 12;
            this.lblcopyright.Text = "DMS c 2017";
            // 
            // simpleMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(354, 341);
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
            this.Controls.Add(this.lblHeader);
            this.Name = "simpleMailForm";
            this.Text = "simpleMailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSendersEmail;
        private System.Windows.Forms.Label lblReceiverEmail;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblEmailBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtReceiverMail;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtSenderMail;
        private System.Windows.Forms.Label lblcopyright;
    }
}