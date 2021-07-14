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
   

    public partial class Form02_emplogin : Form
    {
        
        
         

        public Form02_emplogin()
        {
            InitializeComponent();
        }

        private void btn_createemp_Click(object sender, EventArgs e)
        {
            Form07_empdetails frm3 = new Form07_empdetails();
            frm3.ShowDialog();
        }

     

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void btn_login_emp_Click(object sender, EventArgs e)
        {
           

            if (this.txt_emppass.Text == "" || this.txt_empuser.Text == "")
            {
                MessageBox.Show("Please Enter your Username And Password");
            }

            if (this.txt_emppass.Text != "" && this.txt_empuser.Text != "")
            {
                String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                SqlDataReader dr;

                String sql = "select Emp_username,Emp_pass,Emp_type,Emp_name,Emp_salary,Emp_id  from Employee_table where Emp_username='" + this.txt_empuser.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);

                dr = cmd.ExecuteReader();

                //read a record

                dr.Read();
               

                string user = dr.GetString(0);
                string pass = dr.GetString(1);
                 string type = dr.GetString(2);
                 string name = dr.GetString(3);
                 int salary = dr.GetInt32(4);
                 string id = dr.GetString(5);
                    

                

                       
                if (this.txt_empuser.Text == user && this.txt_emppass.Text == pass)
                {
                MessageBox.Show("You are now Logged In");

                 this.Hide();
                

                Form04_mainemp frmc = new Form04_mainemp(type,name,salary,id);
                frmc.ShowDialog();

                
                }

                 else
                {
                MessageBox.Show("Invalid Username Or Password");
                        
                }       

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txt_emppass.Text = "";
            this.txt_empuser.Text = "";

        }

        private void Form02_emplogin_Load(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btn_login_emp, "click here to login");
        }
    }
}


