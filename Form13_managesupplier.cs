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
    public partial class Form13_managesupplier : Form
    {
        public Form13_managesupplier()
        {
            InitializeComponent();
        }

        private void Form13_managesupplier_Load(object sender, EventArgs e)
        {

            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sql = "select Sup_id from Supplier_table";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr=cmd.ExecuteReader();

            while (dr.Read())
            {
                this.listbx_id.Items.Add(dr.GetString(0));
                    


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listbx_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listbx_item.Items.Clear();

            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sql5 = "select Sup_name from Supplier_table where Sup_id='" + this.listbx_id.Text +"'";
            SqlCommand cmd1 = new SqlCommand(sql5, con);

            SqlDataReader dr1 = cmd1.ExecuteReader();

            dr1.Read();
            this.lbl_supname.Text= dr1.GetString(0);

            dr1.Close();



            String sql6 = "select It_name from Item_table where Sup_id='" + this.listbx_id.Text + "'";
            SqlCommand cmd2 = new SqlCommand(sql6, con);

            SqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
              this.listbx_item.Items.Add(dr2.GetString(0));  
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            this.errorProvider1.SetError(this.btn_removesup,"Warning ..! Are you sure you want to Remove this Supplier? . Any items supplied will be lost too.");



            if (MessageBox.Show("Warning ..! Are you sure you want to Remove this Supplier? . Any items supplied will be lost too.", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                String sql7 = "delete from Item_table where Sup_id='" + this.listbx_id.SelectedItem + "'";
                SqlCommand cmd3 = new SqlCommand(sql7, con);

                cmd3.ExecuteNonQuery();

                String sql8 = "delete from Supplier_table where Sup_id='" + this.listbx_id.SelectedItem + "'";
                SqlCommand cmd4 = new SqlCommand(sql8, con);

                cmd4.ExecuteNonQuery();

                this.Dispose();

                Form13_managesupplier frm = new Form13_managesupplier();
                frm.ShowDialog();


            }
            else
            {
                
            }



        }
    }
}
