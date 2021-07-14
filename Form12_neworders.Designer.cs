namespace Black_Eagle_private_security_service
{
    partial class Form12_neworders
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
            this.Qty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_supid = new System.Windows.Forms.TextBox();
            this.txt_ordercode = new System.Windows.Forms.TextBox();
            this.cmb_itemtype = new System.Windows.Forms.ComboBox();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totcost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_itemname = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier ID";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(50, 245);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(23, 13);
            this.Qty.TabIndex = 3;
            this.Qty.Text = "Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Item Type";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(51, 320);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(217, 320);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 39;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(217, 242);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(195, 20);
            this.txt_qty.TabIndex = 40;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // txt_supid
            // 
            this.txt_supid.Location = new System.Drawing.Point(217, 45);
            this.txt_supid.Name = "txt_supid";
            this.txt_supid.Size = new System.Drawing.Size(195, 20);
            this.txt_supid.TabIndex = 41;
            // 
            // txt_ordercode
            // 
            this.txt_ordercode.Location = new System.Drawing.Point(217, 85);
            this.txt_ordercode.Name = "txt_ordercode";
            this.txt_ordercode.Size = new System.Drawing.Size(195, 20);
            this.txt_ordercode.TabIndex = 42;
            // 
            // cmb_itemtype
            // 
            this.cmb_itemtype.FormattingEnabled = true;
            this.cmb_itemtype.Location = new System.Drawing.Point(217, 126);
            this.cmb_itemtype.Name = "cmb_itemtype";
            this.cmb_itemtype.Size = new System.Drawing.Size(195, 21);
            this.cmb_itemtype.TabIndex = 43;
            this.cmb_itemtype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Location = new System.Drawing.Point(217, 201);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(195, 20);
            this.txt_unitprice.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total Cost";
            // 
            // txt_totcost
            // 
            this.txt_totcost.Location = new System.Drawing.Point(217, 282);
            this.txt_totcost.Name = "txt_totcost";
            this.txt_totcost.Size = new System.Drawing.Size(195, 20);
            this.txt_totcost.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Item Name";
            // 
            // cmb_itemname
            // 
            this.cmb_itemname.FormattingEnabled = true;
            this.cmb_itemname.Location = new System.Drawing.Point(217, 165);
            this.cmb_itemname.Name = "cmb_itemname";
            this.cmb_itemname.Size = new System.Drawing.Size(195, 21);
            this.cmb_itemname.TabIndex = 49;
            this.cmb_itemname.SelectedIndexChanged += new System.EventHandler(this.cmb_itemname_SelectedIndexChanged);
            // 
            // Form12_neworders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 366);
            this.Controls.Add(this.cmb_itemname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_totcost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_unitprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_itemtype);
            this.Controls.Add(this.txt_ordercode);
            this.Controls.Add(this.txt_supid);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form12_neworders";
            this.Text = "New Order";
            this.Load += new System.EventHandler(this.Form12_orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_supid;
        private System.Windows.Forms.TextBox txt_ordercode;
        private System.Windows.Forms.ComboBox cmb_itemtype;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totcost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_itemname;

        public System.EventHandler txt_totcost_TextChanged { get; set; }
    }
}