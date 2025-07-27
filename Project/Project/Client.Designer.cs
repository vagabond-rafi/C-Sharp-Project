namespace Project

{
    partial class Client
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(64, 569);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(147, 70);
            this.btnadd.TabIndex = 37;
            this.btnadd.Text = "Add Client";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(327, 563);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(147, 70);
            this.btnsearch.TabIndex = 36;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(327, 444);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 70);
            this.btndelete.TabIndex = 35;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(64, 444);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 70);
            this.btnupdate.TabIndex = 34;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtrole
            // 
            this.txtrole.Location = new System.Drawing.Point(221, 381);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(282, 31);
            this.txtrole.TabIndex = 33;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(221, 189);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(282, 31);
            this.txtemail.TabIndex = 32;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(221, 248);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(282, 31);
            this.txtpass.TabIndex = 31;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(221, 121);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(282, 31);
            this.txtname.TabIndex = 30;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(221, 316);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(282, 31);
            this.txtphone.TabIndex = 29;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(221, 62);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(282, 31);
            this.txtid.TabIndex = 28;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(79, 375);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(95, 37);
            this.lblrole.TabIndex = 27;
            this.lblrole.Text = "Role:";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(53, 310);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(124, 37);
            this.lblphone.TabIndex = 26;
            this.lblphone.Text = "Phone:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(12, 242);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(176, 37);
            this.lblpassword.TabIndex = 25;
            this.lblpassword.Text = "Password:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(65, 189);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(112, 37);
            this.lblemail.TabIndex = 24;
            this.lblemail.Text = "Email:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(57, 115);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(117, 37);
            this.lblname.TabIndex = 23;
            this.lblname.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1071, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 22;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(31, 62);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(157, 37);
            this.lbluser.TabIndex = 21;
            this.lbluser.Text = "Client ID:";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnview.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnview.Location = new System.Drawing.Point(601, 563);
            this.btnview.Margin = new System.Windows.Forms.Padding(4);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(332, 58);
            this.btnview.TabIndex = 20;
            this.btnview.Text = "view";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(542, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(701, 505);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(1036, 557);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(147, 70);
            this.btnback.TabIndex = 38;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1299, 768);
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
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnback;
    }
}