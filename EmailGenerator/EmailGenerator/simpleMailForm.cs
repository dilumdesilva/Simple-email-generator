using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public void emailSender()
        {

        }

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
    }
}
