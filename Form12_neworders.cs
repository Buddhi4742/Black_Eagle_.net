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
    public partial class Form12_neworders : Form
    {
        double price;
        public Form12_neworders()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connection Establishment and opening
            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            
            String sql2 = "select It_name from Item_table where It_type='" + this.cmb_itemtype.SelectedItem + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, con);

            SqlDataReader dr1 = cmd2.ExecuteReader();

            while (dr1.Read())
            {
                this.cmb_itemname.Text = "";
                this.cmb_itemname.Items.Clear();
                string itemname = dr1.GetString(0);
                this.cmb_itemname.Items.Add(itemname);
                
            }

        }

        private void Form12_orders_Load(object sender, EventArgs e)
        {

            //Connection Establishment and opening
            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();



            String sq = "select It_type from Item_table";
            SqlCommand cmd1 = new SqlCommand(sq, con);

            SqlDataReader dr;
            dr = cmd1.ExecuteReader();



            while (dr.Read())
            {
                string itemtype = dr.GetString(0);
                this.cmb_itemtype.Items.Add(itemtype);

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            //Connection Establishment and opening
            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

         
            String sql = "insert into Orders(Sup_id,Order_code,It_type,Unit_price,Qty,Tot_cost) values('" + this.txt_supid.Text + "','" + this.txt_ordercode.Text + "','" + this.cmb_itemtype.SelectedItem + "','" + Double.Parse(this.txt_unitprice.Text) + "','" + Int32.Parse(this.txt_qty.Text) + "','" + Double.Parse(this.txt_totcost.Text) + "')";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("New Order added");

            this.Dispose();
        }

        

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_unitprice.Text != "" && this.txt_qty.Text != "")
            {
            
                price = Double.Parse(this.txt_unitprice.Text) * Double.Parse(this.txt_qty.Text);

                this.txt_totcost.Text = price.ToString();




            }


        }

        private void cmb_itemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connection Establishment and opening
            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            String sql3 = "select Unit_price from Item_table where It_name='" + this.cmb_itemname.SelectedItem + "'";
            SqlCommand cmd3 = new SqlCommand(sql3, con);

            SqlDataReader dr2 = cmd3.ExecuteReader();

            dr2.Read();

          this.txt_unitprice.Text=  dr2.GetString(0);

           
                


            

        }

     
    }
}
