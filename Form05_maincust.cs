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
    public partial class Form05_maincust : Form
    {
        string name;
        string id;
        public Form05_maincust(string name,string id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }

        private void Form5_maincust_Load(object sender, EventArgs e)
        {
            this.lbl_name.Text = name;
            this.lbl_id.Text = id;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form08_custservice frm = new Form08_custservice(name,id);
            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are now logged out");
            this.Dispose();
            Form01_welcome frm2 = new Form01_welcome();
            frm2.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
