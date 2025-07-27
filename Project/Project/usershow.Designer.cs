namespace Project

{
    partial class usershow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblfreelancer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblrole = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(589, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(634, 505);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(657, 546);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblfreelancer
            // 
            this.lblfreelancer.AutoSize = true;
            this.lblfreelancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfreelancer.Location = new System.Drawing.Point(5, 27);
            this.lblfreelancer.Name = "lblfreelancer";
            this.lblfreelancer.Size = new System.Drawing.Size(217, 37);
            this.lblfreelancer.TabIndex = 2;
            this.lblfreelancer.Text = "FreelancerId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1111, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(95, 92);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(117, 37);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Name:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(95, 153);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(112, 37);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "Email:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(31, 210);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(176, 37);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "Password:";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(83, 280);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(124, 37);
            this.lblphone.TabIndex = 7;
            this.lblphone.Text = "Phone:";
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(112, 350);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(95, 37);
            this.lblrole.TabIndex = 8;
            this.lblrole.Text = "Role:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(228, 27);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(282, 38);
            this.txtid.TabIndex = 9;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(228, 280);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(282, 38);
            this.txtphone.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(228, 91);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(282, 38);
            this.txtname.TabIndex = 11;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(228, 210);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(282, 38);
            this.txtpass.TabIndex = 12;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(228, 153);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(282, 38);
            this.txtemail.TabIndex = 13;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtrole
            // 
            this.txtrole.Location = new System.Drawing.Point(228, 350);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(282, 38);
            this.txtrole.TabIndex = 14;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(34, 414);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 70);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(248, 414);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 70);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(248, 514);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(147, 70);
            this.btnsearch.TabIndex = 17;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(34, 514);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(147, 70);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Add User";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(954, 537);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(130, 67);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "Back ";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // usershow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1291, 694);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtrole);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblfreelancer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usershow";
            this.Load += new System.EventHandler(this.usershow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblfreelancer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
    }
}