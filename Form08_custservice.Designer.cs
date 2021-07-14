namespace Black_Eagle_private_security_service
{
    partial class Form08_custservice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_name = new System.Windows.Forms.Label();
            this.cmb_typeofservice = new System.Windows.Forms.ComboBox();
            this.nup_noguards = new System.Windows.Forms.NumericUpDown();
            this.nup_novehicles = new System.Windows.Forms.NumericUpDown();
            this.btn_proceednext = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tot = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.lbl_days = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_noguards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_novehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Of Guards ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type Of the Service";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "No, Of Vehicles";
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(234, 283);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 20);
            this.dtp_from.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "To";
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(234, 321);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 20);
            this.dtp_to.TabIndex = 9;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(172, 56);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 13);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "lbl_name";
            // 
            // cmb_typeofservice
            // 
            this.cmb_typeofservice.FormattingEnabled = true;
            this.cmb_typeofservice.Items.AddRange(new object[] {
            "Individual Protection",
            "Group Protection",
            "Security For Firms",
            "Armored vehicle supply",
            "Package Securing"});
            this.cmb_typeofservice.Location = new System.Drawing.Point(174, 131);
            this.cmb_typeofservice.Name = "cmb_typeofservice";
            this.cmb_typeofservice.Size = new System.Drawing.Size(240, 21);
            this.cmb_typeofservice.TabIndex = 11;
            // 
            // nup_noguards
            // 
            this.nup_noguards.Location = new System.Drawing.Point(174, 184);
            this.nup_noguards.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nup_noguards.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_noguards.Name = "nup_noguards";
            this.nup_noguards.Size = new System.Drawing.Size(77, 20);
            this.nup_noguards.TabIndex = 12;
            this.nup_noguards.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nup_novehicles
            // 
            this.nup_novehicles.Location = new System.Drawing.Point(175, 233);
            this.nup_novehicles.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nup_novehicles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_novehicles.Name = "nup_novehicles";
            this.nup_novehicles.Size = new System.Drawing.Size(76, 20);
            this.nup_novehicles.TabIndex = 13;
            this.nup_novehicles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_proceednext
            // 
            this.btn_proceednext.Location = new System.Drawing.Point(29, 412);
            this.btn_proceednext.Name = "btn_proceednext";
            this.btn_proceednext.Size = new System.Drawing.Size(75, 23);
            this.btn_proceednext.TabIndex = 14;
            this.btn_proceednext.Text = "Proceed >>";
            this.btn_proceednext.UseVisualStyleBackColor = true;
            this.btn_proceednext.Click += new System.EventHandler(this.btn_proceednext_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(146, 412);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Complete these Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Cost";
            // 
            // txt_tot
            // 
            this.txt_tot.Location = new System.Drawing.Point(175, 369);
            this.txt_tot.Name = "txt_tot";
            this.txt_tot.Size = new System.Drawing.Size(239, 20);
            this.txt_tot.TabIndex = 18;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(262, 412);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 19;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Location = new System.Drawing.Point(117, 328);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(0, 13);
            this.lbl_days.TabIndex = 20;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(172, 95);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 22;
            this.lbl_id.Text = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID";
            // 
            // Form08_custservice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 462);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txt_tot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_proceednext);
            this.Controls.Add(this.nup_novehicles);
            this.Controls.Add(this.nup_noguards);
            this.Controls.Add(this.cmb_typeofservice);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form08_custservice";
            this.Text = "Customer Services";
            this.Load += new System.EventHandler(this.Form6_custservice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_noguards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_novehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_to;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.ComboBox cmb_typeofservice;
        public System.Windows.Forms.NumericUpDown nup_noguards;
        public System.Windows.Forms.NumericUpDown nup_novehicles;
        private System.Windows.Forms.Button btn_proceednext;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_tot;
        private System.Windows.Forms.Button btn_cal;
        public System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label10;
    }
}