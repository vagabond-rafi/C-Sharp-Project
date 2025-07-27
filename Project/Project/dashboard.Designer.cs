namespace Project
{
    partial class dashboard
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
            this.btnvprofile = new System.Windows.Forms.Button();
            this.btnprogress = new System.Windows.Forms.Button();
            this.btnvpassign = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvprofile
            // 
            this.btnvprofile.BackColor = System.Drawing.Color.Green;
            this.btnvprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvprofile.Location = new System.Drawing.Point(170, 47);
            this.btnvprofile.Margin = new System.Windows.Forms.Padding(5);
            this.btnvprofile.Name = "btnvprofile";
            this.btnvprofile.Size = new System.Drawing.Size(340, 110);
            this.btnvprofile.TabIndex = 0;
            this.btnvprofile.Text = "VIEW PROFILE";
            this.btnvprofile.UseVisualStyleBackColor = false;
            this.btnvprofile.Click += new System.EventHandler(this.btnvprofile_Click);
            // 
            // btnprogress
            // 
            this.btnprogress.BackColor = System.Drawing.Color.Blue;
            this.btnprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprogress.Location = new System.Drawing.Point(114, 297);
            this.btnprogress.Margin = new System.Windows.Forms.Padding(5);
            this.btnprogress.Name = "btnprogress";
            this.btnprogress.Size = new System.Drawing.Size(374, 105);
            this.btnprogress.TabIndex = 1;
            this.btnprogress.Text = "Update Work For Status";
            this.btnprogress.UseVisualStyleBackColor = false;
            this.btnprogress.Click += new System.EventHandler(this.btnprogress_Click);
            // 
            // btnvpassign
            // 
            this.btnvpassign.BackColor = System.Drawing.Color.Yellow;
            this.btnvpassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvpassign.Location = new System.Drawing.Point(570, 178);
            this.btnvpassign.Margin = new System.Windows.Forms.Padding(5);
            this.btnvpassign.Name = "btnvpassign";
            this.btnvpassign.Size = new System.Drawing.Size(357, 100);
            this.btnvpassign.TabIndex = 2;
            this.btnvpassign.Text = "VIEW ASSIGN CONTRACTS";
            this.btnvpassign.UseVisualStyleBackColor = false;
            this.btnvpassign.Click += new System.EventHandler(this.btnvpassign_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(1406, 870);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(233, 59);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(497, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 107);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mark Contract Ready For Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(873, 554);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1095, 614);
            this.Controls.Add(this.btnprogress);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnvpassign);
            this.Controls.Add(this.btnvprofile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FREELANCER";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvprofile;
        private System.Windows.Forms.Button btnprogress;
        private System.Windows.Forms.Button btnvpassign;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

