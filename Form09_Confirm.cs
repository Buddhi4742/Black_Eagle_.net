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
    public partial class Form09_Confirm : Form
    {
        string name;
        string id;
        int gurd;
        int vech;
        int tot;
        string type;
        TimeSpan time;

        public Form09_Confirm(string name, int gurd, int vech, int tot, string type, TimeSpan time,string id)

        {
            InitializeComponent();

            this.name = name;
            this.gurd = gurd;
            this.vech = vech;
            this.tot = tot;
            this.type = type;
            this.time = time;
            this.id = id;
            
        }

        private void Form9_Confirm_Load(object sender, EventArgs e)
        {
            this.lbl_name.Text = name;
            this.lbl_id.Text = id;
            this.lbl_nog.Text = gurd.ToString();
            this.lbl_novehi.Text = vech.ToString();
            this.lbl_totcost.Text = tot.ToString();
            this.lbl_duration.Text = (time.Days).ToString()+"Days";

            if (type == "0")
            {
                this.lbl_type.Text = "Individual Protection";

            }
            else if (type == "1")
            {
                this.lbl_type.Text = "Group Protection";

            }
            else if (type == "2")
            {
                this.lbl_type.Text = "Security for firms";

            }
            else if (type == "3")
            {
                this.lbl_type.Text = "Armored Vehicle supply";

            }
            else if (type == "4")
            {
                this.lbl_type.Text = "Package Securing";

            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            String cs = @"Data Source=BUDDHICW\SQLEXPRESS;Initial Catalog=Black_Eagle;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sql = "insert into Customer_service(Cust_id,Cust_name,Ser_type,Nog,Nov,Duration,Tot_cost) values('" + this.lbl_id.Text + "','" + this.lbl_name.Text + "', '" + this.lbl_type.Text + "', '" + this.lbl_nog.Text + "', '" + this.lbl_novehi.Text + "', '" + this.lbl_duration.Text + "', '" +Double.Parse(this.lbl_totcost.Text) + "')";  
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            // int ret = cmd.ExecuteNonQuery();

          

            MessageBox.Show("Your Request Confirmed");

            this.Close();

        }
    }
}
