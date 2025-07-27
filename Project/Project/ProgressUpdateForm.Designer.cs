namespace Project
{
    partial class ProgressUpdatesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressUpdatesForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblContractID = new System.Windows.Forms.Label();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.lblUpdates = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewUpdates = new System.Windows.Forms.Button();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(351, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(297, 48);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Progress Update";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblContractID
            // 
            this.lblContractID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContractID.AutoSize = true;
            this.lblContractID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContractID.Location = new System.Drawing.Point(118, 221);
            this.lblContractID.Name = "lblContractID";
            this.lblContractID.Size = new System.Drawing.Size(175, 38);
            this.lblContractID.TabIndex = 4;
            this.lblContractID.Text = "Contract ID:";
            this.lblContractID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtContractID
            // 
            this.txtContractID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtContractID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractID.ForeColor = System.Drawing.Color.Green;
            this.txtContractID.Location = new System.Drawing.Point(299, 225);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(300, 37);
            this.txtContractID.TabIndex = 5;
            this.txtContractID.TextChanged += new System.EventHandler(this.txtContractID_TextChanged);
            // 
            // lblUpdates
            // 
            this.lblUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUpdates.AutoSize = true;
            this.lblUpdates.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdates.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUpdates.Location = new System.Drawing.Point(53, 389);
            this.lblUpdates.Name = "lblUpdates";
            this.lblUpdates.Size = new System.Drawing.Size(240, 38);
            this.lblUpdates.TabIndex = 6;
            this.lblUpdates.Text = "Progress Update:";
            this.lblUpdates.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(443, 557);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 63);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = " Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewUpdates
            // 
            this.btnViewUpdates.BackColor = System.Drawing.Color.DarkCyan;
            this.btnViewUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUpdates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUpdates.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewUpdates.Location = new System.Drawing.Point(691, 217);
            this.btnViewUpdates.Name = "btnViewUpdates";
            this.btnViewUpdates.Size = new System.Drawing.Size(201, 50);
            this.btnViewUpdates.TabIndex = 46;
            this.btnViewUpdates.Text = " View Updates";
            this.btnViewUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewUpdates.UseVisualStyleBackColor = false;
            this.btnViewUpdates.Click += new System.EventHandler(this.btnViewUpdates_Click);
            // 
            // txtProgress
            // 
            this.txtProgress.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtProgress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgress.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtProgress.Location = new System.Drawing.Point(299, 302);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.Size = new System.Drawing.Size(648, 210);
            this.txtProgress.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // ProgressUpdatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(992, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.btnViewUpdates);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUpdates);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.lblContractID);
            this.Controls.Add(this.lblHeader);
            this.Name = "ProgressUpdatesForm";
            this.Text = "FreelancerProgressForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label lblUpdates;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewUpdates;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}