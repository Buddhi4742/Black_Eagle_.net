namespace Black_Eagle_private_security_service
{
    partial class Form13_managesupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listbx_id = new System.Windows.Forms.ListBox();
            this.lbl_supname = new System.Windows.Forms.Label();
            this.btn_removesup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listbx_item = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplying Items";
            // 
            // listbx_id
            // 
            this.listbx_id.FormattingEnabled = true;
            this.listbx_id.Location = new System.Drawing.Point(192, 49);
            this.listbx_id.MultiColumn = true;
            this.listbx_id.Name = "listbx_id";
            this.listbx_id.Size = new System.Drawing.Size(97, 69);
            this.listbx_id.TabIndex = 3;
            this.listbx_id.SelectedIndexChanged += new System.EventHandler(this.listbx_id_SelectedIndexChanged);
            // 
            // lbl_supname
            // 
            this.lbl_supname.AutoSize = true;
            this.lbl_supname.Location = new System.Drawing.Point(189, 124);
            this.lbl_supname.Name = "lbl_supname";
            this.lbl_supname.Size = new System.Drawing.Size(66, 13);
            this.lbl_supname.TabIndex = 4;
            this.lbl_supname.Text = "lbl_supname";
            // 
            // btn_removesup
            // 
            this.btn_removesup.Location = new System.Drawing.Point(68, 229);
            this.btn_removesup.Name = "btn_removesup";
            this.btn_removesup.Size = new System.Drawing.Size(110, 23);
            this.btn_removesup.TabIndex = 6;
            this.btn_removesup.Text = "Remove Supplier";
            this.btn_removesup.UseVisualStyleBackColor = true;
            this.btn_removesup.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listbx_item
            // 
            this.listbx_item.FormattingEnabled = true;
            this.listbx_item.Location = new System.Drawing.Point(192, 154);
            this.listbx_item.MultiColumn = true;
            this.listbx_item.Name = "listbx_item";
            this.listbx_item.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listbx_item.Size = new System.Drawing.Size(97, 69);
            this.listbx_item.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form13_managesupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 343);
            this.Controls.Add(this.listbx_item);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_removesup);
            this.Controls.Add(this.lbl_supname);
            this.Controls.Add(this.listbx_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form13_managesupplier";
            this.Text = "Manage Sauppliers";
            this.Load += new System.EventHandler(this.Form13_managesupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbx_id;
        private System.Windows.Forms.Label lbl_supname;
        private System.Windows.Forms.Button btn_removesup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listbx_item;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}