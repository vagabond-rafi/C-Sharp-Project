namespace Project
{
    partial class AssignFreelancerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignFreelancerForm));
            this.txtFreelancerEmail = new System.Windows.Forms.TextBox();
            this.lblFreelancerEmail = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblContractID = new System.Windows.Forms.Label();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFreelancerEmail
            // 
            this.txtFreelancerEmail.BackColor = System.Drawing.Color.Pink;
            this.txtFreelancerEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreelancerEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFreelancerEmail.Location = new System.Drawing.Point(539, 288);
            this.txtFreelancerEmail.Name = "txtFreelancerEmail";
            this.txtFreelancerEmail.Size = new System.Drawing.Size(300, 37);
            this.txtFreelancerEmail.TabIndex = 4;
            // 
            // lblFreelancerEmail
            // 
            this.lblFreelancerEmail.AutoSize = true;
            this.lblFreelancerEmail.BackColor = System.Drawing.Color.DarkGreen;
            this.lblFreelancerEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreelancerEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFreelancerEmail.Location = new System.Drawing.Point(325, 288);
            this.lblFreelancerEmail.Name = "lblFreelancerEmail";
            this.lblFreelancerEmail.Size = new System.Drawing.Size(208, 32);
            this.lblFreelancerEmail.TabIndex = 5;
            this.lblFreelancerEmail.Text = "Freelancer Email:";
            this.lblFreelancerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFreelancerEmail.Click += new System.EventHandler(this.lblFreelancerEmail_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Indigo;
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAssign.Location = new System.Drawing.Point(344, 417);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(275, 71);
            this.btnAssign.TabIndex = 11;
            this.btnAssign.Text = "   Assign Freelancer";
            this.btnAssign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBack.Location = new System.Drawing.Point(660, 417);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 71);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "   Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblContractID
            // 
            this.lblContractID.AutoSize = true;
            this.lblContractID.BackColor = System.Drawing.Color.Snow;
            this.lblContractID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractID.ForeColor = System.Drawing.Color.Navy;
            this.lblContractID.Location = new System.Drawing.Point(381, 143);
            this.lblContractID.Name = "lblContractID";
            this.lblContractID.Size = new System.Drawing.Size(152, 32);
            this.lblContractID.TabIndex = 13;
            this.lblContractID.Text = "Contract ID:";
            this.lblContractID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContractID.Click += new System.EventHandler(this.lblContractID_Click);
            // 
            // txtContractID
            // 
            this.txtContractID.BackColor = System.Drawing.Color.Thistle;
            this.txtContractID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtContractID.Location = new System.Drawing.Point(539, 143);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(300, 37);
            this.txtContractID.TabIndex = 14;
            this.txtContractID.TextChanged += new System.EventHandler(this.txtContractID_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Assign Freelancer";
            // 
            // AssignFreelancerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(908, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.lblContractID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblFreelancerEmail);
            this.Controls.Add(this.txtFreelancerEmail);
            this.Name = "AssignFreelancerForm";
            this.Text = "AssignFreelancerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFreelancerEmail;
        private System.Windows.Forms.Label lblFreelancerEmail;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}