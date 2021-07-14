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
    public partial class Form07_empdetails : Form
    {
        public Form07_empdetails()
        {
            InitializeComponent();
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
            if (this.txt_empname.Text == "" || this.txt_empuser.Text == "" || this.txt_empid.Text == "" || this.txt_add.Text == "" || this.txt_pass.Text == "" || this.txt_repass.Text == ""
              || this.txt_pass.Text == "" || this.txt_repass.Text == "")
            {
                MessageBox.Show("Please Fill all the fields");
            }

            //error check
            if (this.chkbx_agree.Checked == false || this.chkbx_true.Checked == false)
            {
                MessageBox.Show("You must agree to both above conditions to proceed");
            }


            if (this.txt_empname.Text != "" && this.txt_empuser.Text != "" && this.txt_add.Text != "" && this.txt_pass.Text != "" && this.txt_pass.Text != "" && this.txt_repass.Text != ""
               && this.txt_pass.Text == this.txt_repass.Text && this.chkbx_agree.Checked == true && this.chkbx_true.Checked == true)
            {
                //Connection Establishment and opening
                String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                String sql = "insert into Employee_table(Emp_id,Emp_name,Emp_type,Emp_add,Emp_salary,Emp_username,Emp_pass) values('" + this.txt_empid.Text + "','" + this.txt_empname.Text + "','" + this.cmb_emptype.SelectedItem+ "','" + this.txt_add.Text + "','"+this.txt_sal.Text+"','" + this.txt_empuser.Text + "','" + this.txt_pass.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.ExecuteNonQuery();

                con.Close();
                

                MessageBox.Show("Your Account is created");

                this.Close();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txt_empname.Text = "";
            this.txt_empuser.Text = "";
            this.txt_pass.Text = "";
            this.txt_repass.Text = "";
            this.txt_add.Text = "";
            this.txt_empid.Text = "";
            this.txt_sal.Text = "";

            

                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (this.txt_empname.Text != "" && this.txt_empuser.Text != "" && this.txt_add.Text != "" && this.txt_pass.Text != "" && this.txt_pass.Text != "" && this.txt_repass.Text != ""
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

        private void cmb_emptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_emptype.SelectedIndex == 0)
            {
                this.txt_sal.Text= (40000).ToString();

            }
            else if (this.cmb_emptype.SelectedIndex == 1)
            {
                this.txt_sal.Text = (35000).ToString();
            }
            else if (this.cmb_emptype.SelectedIndex == 2)
            {
                this.txt_sal.Text = (30000).ToString();
            }
            else if (this.cmb_emptype.SelectedIndex == 3)
            {
                this.txt_sal.Text = (25000).ToString();
            }
            else if (this.cmb_emptype.SelectedIndex == 4)
            {
                this.txt_sal.Text = (20000).ToString();
            }
            else if (this.cmb_emptype.SelectedIndex == 5)
            {
                this.txt_sal.Text = (20000).ToString();
            }
            else if (this.cmb_emptype.SelectedIndex == 6)
            {
                this.txt_sal.Text = (15000).ToString();
            }
          


        }
    }
}
