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
    public partial class Form10_empsalary : Form
    {
        string type;
        string name;
        int salary;
        string id;

        public Form10_empsalary(string type, string name, int salary, string id)
        {
            InitializeComponent();
            this.type = type;
            this.name = name;
            this.salary = salary;
            this.id=id;
        }


        private void Form10_empservice_Load(object sender, EventArgs e)
        {
            this.lbl_name.Text = name;
            this.lbl_ID.Text = id;
            this.lbl_salary.Text = salary.ToString(); ;
            this.lbl_type.Text = type;
        }

      

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
                
        }

        private void btn_backtomain_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form04_mainemp frm = new Form04_mainemp(type,name,salary,id);
            frm.ShowDialog();
        }

        private void btn_cal_Click(object sender, EventArgs e)
           /* Manager
Sales manager
HRM Officer
Securtiy Officer
Security Guard
Security Driver
Clerk*/
        {
            int hrs = Int32.Parse(this.nup_ot.Value.ToString());
            double otadd = hrs * 300;
            double all=0;
            
            if(this.lbl_type.Text=="Manager")    
            {
                all=salary*30/100;
            }

            else if (this.lbl_type.Text == "Sales manager")
            {
                all = salary * 27/ 100;
            }
            else if (this.lbl_type.Text == "HRM Officer")
            {
                all = salary * 24 / 100;
            }
            else if (this.lbl_type.Text == "Securtiy Officer")
            {
                all = salary * 20 / 100;
            }
            else if (this.lbl_type.Text == "Security Guard")
            {
                all = salary * 15 / 100;
            }
            else if (this.lbl_type.Text == "Security Driver")
            {
                all = salary * 10/ 100;
            }
            else if (this.lbl_type.Text == "Clerk")
            {
                all = salary * 5 / 100;
            }

            this.txt_all.Text=all.ToString();

            this.txt_EPF.Text = (salary * 10 / 100).ToString();

            this.txt_ETF.Text = (salary * 5 / 100).ToString();

            this.txt_net.Text = (salary + all+otadd - Double.Parse(this.txt_EPF.Text)).ToString();

        }

    }
}
