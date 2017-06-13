//before you run this code please follow these steps
//01 - login to your email address
//02 - go to settings
//03 - click on "Forwarding and POP/IMAP" tab
//04 - enable Status: POP 
//05 - enable Status: IMAP

//Then the sent email will be there and the application will work smoothly.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailGenerator
{
    public partial class simpleMailForm : Form
    {
        public simpleMailForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }

        //the method which handle the all functions realated to email sending procedure.
        public void emailSender()
        {   
            //in here i'm assinging the values of the textboxes to string variables for further use. 
            string sender = txtSenderMail.Text;
            string receiver = txtReceiverMail.Text;
            string message = txtMessage.Text;
            string subject = txtSubject.Text;

            try
            {
                //creating an object called mail from System.Net.Mail class
                MailMessage mail = new MailMessage();

                //creating an object called SmtpServer from  SmtpClient class and setting the email client
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //mail.From = new MailAddress("your_email_address@gmail.com");
                //mail.To.Add("to_address");
                //mail.Subject = "Test Mail";
                //mail.Body = "This is for testing SMTP mail from GMAIL";

                mail.From = new MailAddress(sender);
                mail.To.Add(receiver);
                mail.Subject = subject;
                mail.Body = message;

                //setting the port
                SmtpServer.Port = 587;

                //giving the user credentials of senders email acount.
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
               
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("Email has been sent to "+receiver);
            }
            catch (Exception ex)
            {
                //if there is any exception this will show the error message.
                MessageBox.Show(ex.Message);
            }

        }

        //Code by Dilum De Silva.

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                emailSender();
            }
            catch (Exception ex)
            {
                //if there is any exception this will show the error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        //method which delete the current content of the textboxes.
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }

                    else if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedValue = -1;
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);

            //another way of clearing the feilds 
            //txtEmpDesignation.Text = "";
            //cmbDept.SelectedIndex = -1;
        }

        private void lblcopyright_Click(object sender, EventArgs e)
        {

        }

        private void simpleMailForm_Load(object sender, EventArgs e)
        {

        }
    }
}




//Code by Dilum De Silva.

