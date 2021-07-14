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
    public partial class Form11_newitem : Form
    {
        public Form11_newitem()
        {
            InitializeComponent();
        }

        private void Form11_newitem_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sql = "insert into Item_table(It_code,It_name,It_type,Unit_price,Sup_name,Sup_id) values('" + this.txt_itemcode.Text + "','" + this.txt_itemname.Text + "','" + this.txt_itemtype.Text + "','" + this.txt_price.Text + "','" + this.txt_supname.Text + "','" + this.txt_supid.Text + "') ";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();
                

            String sql1 = "insert into Supplier_table(Sup_name,Sup_id) values('" + this.txt_supname.Text + "','" + this.txt_supid.Text + "') ";
            SqlCommand cmd1 = new SqlCommand(sql1, con);

            cmd1.ExecuteNonQuery();


            MessageBox.Show("New Item added and New Supplier Added");

            this.Close();



        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
