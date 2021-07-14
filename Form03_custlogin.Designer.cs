namespace Black_Eagle_private_security_service
{
    partial class Form03_custlogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_custpass = new System.Windows.Forms.TextBox();
            this.txt_custuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_createcust = new System.Windows.Forms.Button();
            this.btn_login_cust = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Don\'t Have an account?";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(494, 233);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(392, 233);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 30;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_custpass
            // 
            this.txt_custpass.Location = new System.Drawing.Point(378, 178);
            this.txt_custpass.MaxLength = 15;
            this.txt_custpass.Name = "txt_custpass";
            this.txt_custpass.Size = new System.Drawing.Size(191, 20);
            this.txt_custpass.TabIndex = 29;
            // 
            // txt_custuser
            // 
            this.txt_custuser.Location = new System.Drawing.Point(378, 120);
            this.txt_custuser.MaxLength = 20;
            this.txt_custuser.Name = "txt_custuser";
            this.txt_custuser.Size = new System.Drawing.Size(191, 20);
            this.txt_custuser.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Password";
            // 
            // btn_createcust
            // 
            this.btn_createcust.Location = new System.Drawing.Point(290, 326);
            this.btn_createcust.Name = "btn_createcust";
            this.btn_createcust.Size = new System.Drawing.Size(121, 23);
            this.btn_createcust.TabIndex = 25;
            this.btn_createcust.Text = "Create Account";
            this.btn_createcust.UseVisualStyleBackColor = true;
            this.btn_createcust.Click += new System.EventHandler(this.btn_createcust_Click);
            // 
            // btn_login_cust
            // 
            this.btn_login_cust.Location = new System.Drawing.Point(290, 233);
            this.btn_login_cust.Name = "btn_login_cust";
            this.btn_login_cust.Size = new System.Drawing.Size(75, 23);
            this.btn_login_cust.TabIndex = 24;
            this.btn_login_cust.Text = "Login";
            this.btn_login_cust.UseVisualStyleBackColor = true;
            this.btn_login_cust.Click += new System.EventHandler(this.btn_login_cust_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Provide Your credentials to get customer access";
            // 
            // Form03_custlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_custpass);
            this.Controls.Add(this.txt_custuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_createcust);
            this.Controls.Add(this.btn_login_cust);
            this.Name = "Form03_custlogin";
            this.Text = "Customer Login";
            this.Load += new System.EventHandler(this.Form03_custlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_custpass;
        private System.Windows.Forms.TextBox txt_custuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_createcust;
        private System.Windows.Forms.Button btn_login_cust;
        private System.Windows.Forms.Label label4;
    }
}