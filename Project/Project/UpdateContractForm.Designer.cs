namespace Project
{
    partial class UpdateContractForm
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
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.lblContractID = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblFreelancer = new System.Windows.Forms.Label();
            this.txtFreelancerEmail = new System.Windows.Forms.TextBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.txtPaymentStatus = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBudget
            // 
            this.txtBudget.BackColor = System.Drawing.Color.OliveDrab;
            this.txtBudget.ForeColor = System.Drawing.Color.SeaShell;
            this.txtBudget.Location = new System.Drawing.Point(222, 247);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(169, 26);
            this.txtBudget.TabIndex = 37;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitle.Location = new System.Drawing.Point(222, 183);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(169, 26);
            this.txtTitle.TabIndex = 38;
            // 
            // txtContractID
            // 
            this.txtContractID.BackColor = System.Drawing.Color.RosyBrown;
            this.txtContractID.ForeColor = System.Drawing.Color.White;
            this.txtContractID.Location = new System.Drawing.Point(222, 121);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(169, 26);
            this.txtContractID.TabIndex = 39;
            // 
            // lblContractID
            // 
            this.lblContractID.AutoSize = true;
            this.lblContractID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContractID.Location = new System.Drawing.Point(64, 114);
            this.lblContractID.Name = "lblContractID";
            this.lblContractID.Size = new System.Drawing.Size(152, 32);
            this.lblContractID.TabIndex = 41;
            this.lblContractID.Text = "Contract ID:";
            this.lblContractID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Lavender;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeader.Location = new System.Drawing.Point(308, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(449, 48);
            this.lblHeader.TabIndex = 42;
            this.lblHeader.Text = "Update Existing Contract:";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Indigo;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(425, 114);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(177, 51);
            this.btnLoad.TabIndex = 44;
            this.btnLoad.Text = "      Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBudget.Location = new System.Drawing.Point(113, 240);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(103, 32);
            this.lblBudget.TabIndex = 45;
            this.lblBudget.Text = "Budget:";
            this.lblBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(145, 176);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 32);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDeadline.Location = new System.Drawing.Point(94, 307);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(122, 32);
            this.lblDeadline.TabIndex = 47;
            this.lblDeadline.Text = "Deadline:";
            this.lblDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.CalendarTitleBackColor = System.Drawing.Color.Turquoise;
            this.dtpDeadline.CalendarTitleForeColor = System.Drawing.Color.Sienna;
            this.dtpDeadline.Location = new System.Drawing.Point(222, 312);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(200, 26);
            this.dtpDeadline.TabIndex = 48;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStatus.Location = new System.Drawing.Point(126, 371);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 32);
            this.lblStatus.TabIndex = 49;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.DarkGreen;
            this.txtStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStatus.Location = new System.Drawing.Point(222, 377);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(169, 26);
            this.txtStatus.TabIndex = 50;
            // 
            // lblFreelancer
            // 
            this.lblFreelancer.AutoSize = true;
            this.lblFreelancer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreelancer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFreelancer.Location = new System.Drawing.Point(8, 438);
            this.lblFreelancer.Name = "lblFreelancer";
            this.lblFreelancer.Size = new System.Drawing.Size(208, 32);
            this.lblFreelancer.TabIndex = 51;
            this.lblFreelancer.Text = "Freelancer Email:";
            this.lblFreelancer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFreelancerEmail
            // 
            this.txtFreelancerEmail.BackColor = System.Drawing.Color.SlateBlue;
            this.txtFreelancerEmail.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtFreelancerEmail.Location = new System.Drawing.Point(222, 444);
            this.txtFreelancerEmail.Name = "txtFreelancerEmail";
            this.txtFreelancerEmail.Size = new System.Drawing.Size(169, 26);
            this.txtFreelancerEmail.TabIndex = 52;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPaymentStatus.Location = new System.Drawing.Point(20, 505);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(196, 32);
            this.lblPaymentStatus.TabIndex = 53;
            this.lblPaymentStatus.Text = "Payment Status:";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.BackColor = System.Drawing.Color.Purple;
            this.txtPaymentStatus.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPaymentStatus.Location = new System.Drawing.Point(222, 512);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.Size = new System.Drawing.Size(169, 26);
            this.txtPaymentStatus.TabIndex = 54;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(70, 582);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(232, 53);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update Contracts";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(425, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 53);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "    Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdateContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 677);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPaymentStatus);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.txtFreelancerEmail);
            this.Controls.Add(this.lblFreelancer);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblContractID);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBudget);
            this.Name = "UpdateContractForm";
            this.Text = "UpdateContractForm";
            this.Load += new System.EventHandler(this.UpdateContractForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblFreelancer;
        private System.Windows.Forms.TextBox txtFreelancerEmail;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.TextBox txtPaymentStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}