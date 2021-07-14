namespace Black_Eagle_private_security_service
{
    partial class Form02_emplogin
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_createemp = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_emppass = new System.Windows.Forms.TextBox();
            this.txt_empuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login_emp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Don\'t Have an account?";
            // 
            // btn_createemp
            // 
            this.btn_createemp.Location = new System.Drawing.Point(262, 323);
            this.btn_createemp.Name = "btn_createemp";
            this.btn_createemp.Size = new System.Drawing.Size(121, 23);
            this.btn_createemp.TabIndex = 33;
            this.btn_createemp.Text = "Create Account";
            this.btn_createemp.UseVisualStyleBackColor = true;
            this.btn_createemp.Click += new System.EventHandler(this.btn_createemp_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(495, 182);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(381, 182);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 31;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_emppass
            // 
            this.txt_emppass.Location = new System.Drawing.Point(363, 133);
            this.txt_emppass.MaxLength = 15;
            this.txt_emppass.Name = "txt_emppass";
            this.txt_emppass.Size = new System.Drawing.Size(191, 20);
            this.txt_emppass.TabIndex = 30;
            // 
            // txt_empuser
            // 
            this.txt_empuser.Location = new System.Drawing.Point(363, 82);
            this.txt_empuser.MaxLength = 20;
            this.txt_empuser.Name = "txt_empuser";
            this.txt_empuser.Size = new System.Drawing.Size(191, 20);
            this.txt_empuser.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Password";
            // 
            // btn_login_emp
            // 
            this.btn_login_emp.Location = new System.Drawing.Point(262, 182);
            this.btn_login_emp.Name = "btn_login_emp";
            this.btn_login_emp.Size = new System.Drawing.Size(75, 23);
            this.btn_login_emp.TabIndex = 26;
            this.btn_login_emp.Text = "Login";
            this.btn_login_emp.UseVisualStyleBackColor = true;
            this.btn_login_emp.Click += new System.EventHandler(this.btn_login_emp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Please Provide your credentials beofre Getting Access";
            // 
            // Form02_emplogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_createemp);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_emppass);
            this.Controls.Add(this.txt_empuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login_emp);
            this.Name = "Form02_emplogin";
            this.Text = "Employee Login";
            this.Load += new System.EventHandler(this.Form02_emplogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_createemp;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_emppass;
        private System.Windows.Forms.TextBox txt_empuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login_emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}