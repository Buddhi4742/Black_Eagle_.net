namespace Black_Eagle_private_security_service
{
    partial class Form01_welcome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_empproc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_custproc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Black Eagle Private Security Service";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_empproc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(588, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 105);
            this.panel1.TabIndex = 6;
            // 
            // btn_empproc
            // 
            this.btn_empproc.Location = new System.Drawing.Point(8, 68);
            this.btn_empproc.Name = "btn_empproc";
            this.btn_empproc.Size = new System.Drawing.Size(144, 23);
            this.btn_empproc.TabIndex = 0;
            this.btn_empproc.Text = "Employee Proceed >>";
            this.btn_empproc.UseVisualStyleBackColor = true;
            this.btn_empproc.Click += new System.EventHandler(this.btn_empproc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Click the Button below to\r\nProceed as an Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click \"Proceed\" to  Proceed\r\nAs a Customer";
            // 
            // btn_custproc
            // 
            this.btn_custproc.Location = new System.Drawing.Point(3, 68);
            this.btn_custproc.Name = "btn_custproc";
            this.btn_custproc.Size = new System.Drawing.Size(137, 23);
            this.btn_custproc.TabIndex = 1;
            this.btn_custproc.Text = "Customer Proceed >>";
            this.btn_custproc.UseVisualStyleBackColor = true;
            this.btn_custproc.Click += new System.EventHandler(this.btn_custproc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_custproc);
            this.panel2.Location = new System.Drawing.Point(186, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 105);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form01_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form01_welcome";
            this.Text = "Welcome..!";
            this.Load += new System.EventHandler(this.Form01_welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_empproc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_custproc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

