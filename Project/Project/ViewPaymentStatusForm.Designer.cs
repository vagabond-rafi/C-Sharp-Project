namespace Project
{
    partial class ViewPaymentStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPaymentStatusForm));
            this.lblContractID = new System.Windows.Forms.Label();
            this.dataGridPayments = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContractID
            // 
            this.lblContractID.AutoSize = true;
            this.lblContractID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractID.ForeColor = System.Drawing.Color.Indigo;
            this.lblContractID.Location = new System.Drawing.Point(317, 28);
            this.lblContractID.Name = "lblContractID";
            this.lblContractID.Size = new System.Drawing.Size(368, 48);
            this.lblContractID.TabIndex = 14;
            this.lblContractID.Text = "Your Payment Status";
            this.lblContractID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridPayments
            // 
            this.dataGridPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPayments.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPayments.Location = new System.Drawing.Point(2, 125);
            this.dataGridPayments.Name = "dataGridPayments";
            this.dataGridPayments.ReadOnly = true;
            this.dataGridPayments.RowHeadersWidth = 62;
            this.dataGridPayments.RowTemplate.Height = 28;
            this.dataGridPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPayments.Size = new System.Drawing.Size(961, 444);
            this.dataGridPayments.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBack.Location = new System.Drawing.Point(379, 575);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(276, 51);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "  Back to Dashboard";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ViewPaymentStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(972, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridPayments);
            this.Controls.Add(this.lblContractID);
            this.Name = "ViewPaymentStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPaymentStatusForm";
            this.Load += new System.EventHandler(this.ViewPaymentStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.DataGridView dataGridPayments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}