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
    public partial class Form08_custservice : Form
    {
        string name;
        string id;
        int gurd;
        int vech;
        int cost;
        int tot;
        string type;
        TimeSpan time;

        public Form08_custservice(string name,string id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            


        }

        private void Form6_custservice_Load(object sender, EventArgs e)
        {
            this.lbl_name.Text = name;
        }

        public void btn_cal_Click(object sender, EventArgs e)
        {
            
         gurd = Int32.Parse((this.nup_noguards.Value).ToString());
         vech = Int32.Parse((this.nup_novehicles.Value).ToString());

          cost=0;

            if (this.cmb_typeofservice.SelectedIndex == 0)
            {
                type = "0";
                cost = 12000;
            }
            else if (this.cmb_typeofservice.SelectedIndex == 1)
            {
                type = "1";
                cost = 20000;
            }
            else if (this.cmb_typeofservice.SelectedIndex == 2)
            {
                type = "2";
                cost = 50000;
            }
            else if (this.cmb_typeofservice.SelectedIndex == 3)
            {
                type = "3";
                cost = 100000;
            
            }
            else if (this.cmb_typeofservice.SelectedIndex == 4)
            {
                type = "4";
                cost = 30000;
            }
            
            DateTime from = this.dtp_from.Value;
            DateTime to = this.dtp_to.Value;

           time = to - from;
           this.lbl_days.Text = time.Days.ToString() + "days";

           int extra = gurd * time.Days*1000 + vech * time.Days*3000;

           tot=(extra + cost);

           this.txt_tot.Text =tot.ToString();
              

            }

        private void btn_proceednext_Click(object sender, EventArgs e)
        {
           
            Form09_Confirm frm = new Form09_Confirm(name,gurd,vech,tot,type,time,id);
            frm.ShowDialog();

           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
