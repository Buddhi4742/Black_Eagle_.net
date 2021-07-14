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
    public partial class Form14_manageitem : Form
    {
        public Form14_manageitem()
        {
            InitializeComponent();
        }

        private void Form14_manageitem_Load(object sender, EventArgs e)
        {
            

            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sql = "select It_code,It_name,It_type,Sup_id,Sup_name from Item_table";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())

            {   
                this.listbx_itcode.Items.Add(dr.GetString(0));

            }


        }

        private void listbx_itcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sql1 = "select It_name,It_type,Sup_id,Sup_name from Item_table where It_code='"+this.listbx_itcode.SelectedItem+"'";
            SqlCommand cmd1 = new SqlCommand(sql1, con);

            SqlDataReader dr = cmd1.ExecuteReader();
            dr.Read();

            this.lbl_itname.Text = dr.GetString(0);
            this.lbl_ittype.Text = dr.GetString(1);
            this.lbl_supid.Text = dr.GetString(2);
            this.lbl_supname.Text = dr.GetString(3);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning ..! Are you sure you want to Remove this Item? Certain Suppliers will be removed too.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                String sql7 = "delete from Item_table where It_code='" + this.listbx_itcode.SelectedItem + "'";
                SqlCommand cmd3 = new SqlCommand(sql7, con);

                cmd3.ExecuteNonQuery();
                

                String sql8 = "delete from Supplier_table where Sup_id='" + this.lbl_supid.Text + "'";
                SqlCommand cmd4 = new SqlCommand(sql8, con);

                cmd4.ExecuteNonQuery();

                this.Close();


                Form14_manageitem frm = new Form14_manageitem();
                frm.ShowDialog();

          
    
 
            }
            else
            {

            }

        }
    }
}
