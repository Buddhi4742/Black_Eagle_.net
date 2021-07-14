using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Black_Eagle_private_security_service
{
    
    public partial class Form03_custlogin : Form
    {
        SqlDataReader dr;

        public Form03_custlogin()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createcust_Click(object sender, EventArgs e)
        {
            //Goto create an account
            Form06_custdetails frm5 = new Form06_custdetails();
            frm5.ShowDialog();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //Empty txt boxes
            this.txt_custpass.Text = "";
            this.txt_custuser.Text = "";

        }

        private void btn_login_cust_Click(object sender, EventArgs e)
        {
            if (this.txt_custpass.Text == "" || this.txt_custuser.Text == "")
            {
                MessageBox.Show("Please Enter your Username And Password");
            }

        if(this.txt_custpass.Text !="" && this.txt_custuser.Text !="")
        {
            //Connection Establishment and opening
            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sql = "select Cust_username,Cust_pass,Cust_name,Cust_id  from Customer_table where Cust_username='" + this.txt_custuser.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);

            dr = cmd.ExecuteReader();

            //read a record
            dr.Read();

            string user = dr.GetString(0);
            string pass = dr.GetString(1);
            string name = dr.GetString(2);
            string id = dr.GetString(3);

            if (this.txt_custuser.Text == user && this.txt_custpass.Text == pass)
            {
                MessageBox.Show("You are now Logged In");

                this.Hide();

                Form05_maincust frmc = new Form05_maincust(name,id);
                frmc.ShowDialog();

               


            }
            if (this.txt_custuser.Text != user || this.txt_custpass.Text != pass)
            {

                MessageBox.Show("Invalid Username Or Password");
            }

        }


        }

        private void Form03_custlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
