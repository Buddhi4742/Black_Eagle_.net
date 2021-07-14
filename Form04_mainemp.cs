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
    
    public partial class Form04_mainemp : Form
    {
        
       public string type;
       public string name;
       int salary;
       string id;
       public Form04_mainemp(string type, string name,int salary, string id)
        {
            
            InitializeComponent();
            this.type = type;
            this.name = name;
            this.salary = salary;
            this.id = id;
        }

     

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form04_mainemp_Load(object sender, EventArgs e)
        {
           /* // TODO: This line of code loads data into the 'black_EagleDataSet.Customer_table' table. You can move, or remove it, as needed.
            this.customer_tableTableAdapter.Fill(this.black_EagleDataSet.Customer_table);
            * * */

            this.lbl_post.Text = type;

            this.lbl_empname.Text = name;

            if (this.lbl_post.Text == "Sales manager")
            {
                this.menu_addnew.Enabled = true;
                
            }

        }

      

        private void menu_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11_newitem frm = new Form11_newitem();
            frm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12_neworders frm1 = new Form12_neworders();
            frm1.ShowDialog();
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are now logged out");
            this.Dispose();
            Form01_welcome frm3 = new Form01_welcome();
            frm3.ShowDialog();
            
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10_empsalary frm4 = new Form10_empsalary(type,name,salary,id);
            frm4.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13_managesupplier frm = new Form13_managesupplier();
            frm.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14_manageitem frm1 = new Form14_manageitem();
            frm1.ShowDialog();
        }
    }
}
