using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Black_Eagle_private_security_service
{
    public partial class Form01_welcome : Form
    {
        public Form01_welcome()
        {
            InitializeComponent();
        }

        private void btn_custproc_Click(object sender, EventArgs e)
        {

            //Go to Login screen
            Form03_custlogin frm1 = new Form03_custlogin();
            frm1.ShowDialog();

        }

        private void btn_empproc_Click(object sender, EventArgs e)
        {
            //Goto Login Screen
            Form02_emplogin frm2 = new Form02_emplogin();
            frm2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form01_welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
