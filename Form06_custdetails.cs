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
    public partial class Form06_custdetails : Form
    {
        public Form06_custdetails()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (this.txt_custname.Text != "" && this.txt_custuser.Text != "" && this.txt_custcomp.Text != "" && this.txt_custcontact.Text != "" && this.txt_pass.Text != "" && this.txt_repass.Text != ""
                && this.txt_pass.Text == this.txt_repass.Text)
            {
                this.btn_create.Enabled = true;
                MessageBox.Show("Validation is a Success");
                
            }
                
         else
            {

                MessageBox.Show("Validation Faild, Please Recheck all the fields");
                this.btn_create.Enabled = false;
            }


        }

        private void Form06_custdetails_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //error check
           if (this.txt_pass.Text != this.txt_repass.Text)
            {
                this.btn_create.Enabled = false;
                MessageBox.Show("The Passwords Doesnt Match, Please Re Enter");
                this.txt_pass.Text = "";
                this.txt_repass.Text = "";

            }

           //error check
           if (this.txt_custname.Text == "" || this.txt_custuser.Text == "" || this.txt_custcomp.Text == "" || this.txt_custcontact.Text == "" || this.txt_pass.Text == "" || this.txt_repass.Text == ""
              || this.txt_pass.Text =="" || this.txt_repass.Text=="")
           {
               MessageBox.Show("Please Fill all the fields");
           }
            
           //error check
            if (this.chkbx_agree.Checked== false || this.chkbx_true.Checked == false)
            {
                MessageBox.Show("You must agree to both above conditions to proceed");
            }

            //DB saving
            if (this.txt_custname.Text != "" && this.txt_custuser.Text != "" && this.txt_custcomp.Text != "" && this.txt_custcontact.Text != "" && this.txt_pass.Text != "" && this.txt_repass.Text != ""
                 && this.txt_pass.Text == this.txt_repass.Text)
            {
                //Connection Establishment and opening
                String cs= @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                String sql = "insert into Customer_table(Cust_id,Cust_name,Cust_company,Cust_contact,Cust_username,Cust_pass) values('" +this.txt_custid.Text+ "','" +this.txt_custname.Text+ "','" +this.txt_custcomp.Text+ "','" +this.txt_custcontact.Text+ "','" +this.txt_custuser.Text+ "','" +this.txt_pass.Text+"')";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.ExecuteNonQuery();

                
               // int ret = cmd.ExecuteNonQuery();

                con.Close();
                
                MessageBox.Show("Your Account is created");

                this.Close();

                Form03_custlogin frm1 = new Form03_custlogin();
                frm1.ShowDialog();


               


            }



        }
    }
}
