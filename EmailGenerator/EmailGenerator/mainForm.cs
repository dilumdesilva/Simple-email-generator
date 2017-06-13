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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutMe objaboutMe = new aboutMe();
            objaboutMe.Show();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            simpleMailForm objsimpleMailForm = new simpleMailForm();
            objsimpleMailForm.Show();
            this.Hide();
        }
    }
}
