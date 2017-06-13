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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(117, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(164, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = " Email generator";
            // 
            // lblSendersEmail
            // 
            this.lblSendersEmail.AutoSize = true;
            this.lblSendersEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblSendersEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendersEmail.Location = new System.Drawing.Point(26, 82);
            this.lblSendersEmail.Name = "lblSendersEmail";
            this.lblSendersEmail.Size = new System.Drawing.Size(137, 15);
            this.lblSendersEmail.TabIndex = 1;
            this.lblSendersEmail.Text = "Sender\'s email address";
            // 
            // lblReceiverEmail
            // 
            this.lblReceiverEmail.AutoSize = true;
            this.lblReceiverEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiverEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverEmail.Location = new System.Drawing.Point(26, 123);
            this.lblReceiverEmail.Name = "lblReceiverEmail";
            this.lblReceiverEmail.Size = new System.Drawing.Size(145, 15);
            this.lblReceiverEmail.TabIndex = 2;
            this.lblReceiverEmail.Text = "Receiver\'s email address";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(26, 159);
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
            this.lblEmailBody.Location = new System.Drawing.Point(26, 196);
            this.lblEmailBody.Name = "lblEmailBody";
            this.lblEmailBody.Size = new System.Drawing.Size(58, 15);
            this.lblEmailBody.TabIndex = 4;
            this.lblEmailBody.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(29, 305);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(121, 305);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtReceiverMail
            // 
            this.txtReceiverMail.Location = new System.Drawing.Point(191, 122);
            this.txtReceiverMail.Name = "txtReceiverMail";
            this.txtReceiverMail.Size = new System.Drawing.Size(190, 20);
            this.txtReceiverMail.TabIndex = 8;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(191, 196);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(190, 78);
            this.txtMessage.TabIndex = 9;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(191, 158);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(190, 20);
            this.txtSubject.TabIndex = 10;
            // 
            // txtSenderMail
            // 
            this.txtSenderMail.Location = new System.Drawing.Point(191, 81);
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
            this.lblcopyright.Location = new System.Drawing.Point(169, 364);
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
            // simpleMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(417, 383);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "simpleMailForm";
            this.Text = "simpleMailForm";
            this.Load += new System.EventHandler(this.simpleMailForm_Load);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}