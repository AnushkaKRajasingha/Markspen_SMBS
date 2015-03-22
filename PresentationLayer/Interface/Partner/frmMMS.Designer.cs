namespace Markspen_SMBS_V1.Interface.Partner
{
    partial class frmMMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMMS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalCashSale = new System.Windows.Forms.TextBox();
            this.txtTotalCreditSale = new System.Windows.Forms.TextBox();
            this.txtPartnerMobNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPartnerName = new System.Windows.Forms.ComboBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpMMS = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total Cash Sale";
            // 
            // txtTotalCashSale
            // 
            this.txtTotalCashSale.Location = new System.Drawing.Point(109, 52);
            this.txtTotalCashSale.Name = "txtTotalCashSale";
            this.txtTotalCashSale.Size = new System.Drawing.Size(181, 20);
            this.txtTotalCashSale.TabIndex = 21;
            // 
            // txtTotalCreditSale
            // 
            this.txtTotalCreditSale.Location = new System.Drawing.Point(109, 96);
            this.txtTotalCreditSale.Name = "txtTotalCreditSale";
            this.txtTotalCreditSale.Size = new System.Drawing.Size(181, 20);
            this.txtTotalCreditSale.TabIndex = 21;
            // 
            // txtPartnerMobNo
            // 
            this.txtPartnerMobNo.Location = new System.Drawing.Point(169, 30);
            this.txtPartnerMobNo.Name = "txtPartnerMobNo";
            this.txtPartnerMobNo.Size = new System.Drawing.Size(181, 20);
            this.txtPartnerMobNo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total Credit Sale";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpMMS);
            this.groupBox1.Controls.Add(this.txtTotalCreditSale);
            this.groupBox1.Controls.Add(this.txtTotalCashSale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 140);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Summery ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPartnerName);
            this.groupBox2.Controls.Add(this.txtPartnerMobNo);
            this.groupBox2.Location = new System.Drawing.Point(18, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 69);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Partner";
            // 
            // cboPartnerName
            // 
            this.cboPartnerName.FormattingEnabled = true;
            this.cboPartnerName.Location = new System.Drawing.Point(24, 30);
            this.cboPartnerName.Name = "cboPartnerName";
            this.cboPartnerName.Size = new System.Drawing.Size(139, 21);
            this.cboPartnerName.Sorted = true;
            this.cboPartnerName.TabIndex = 22;
            // 
            // cmdSend
            // 
            this.cmdSend.FlatAppearance.BorderSize = 0;
            this.cmdSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSend.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSend.Image = global::Markspen_SMBS_V1.Properties.Resources.SMS;
            this.cmdSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSend.Location = new System.Drawing.Point(6, 10);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(112, 52);
            this.cmdSend.TabIndex = 22;
            this.cmdSend.Text = "Send";
            this.cmdSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSend.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::Markspen_SMBS_V1.Properties.Resources.exit1;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(124, 10);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(116, 52);
            this.cmdExit.TabIndex = 25;
            this.cmdExit.Text = "Exit";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdSend);
            this.groupBox3.Controls.Add(this.cmdExit);
            this.groupBox3.Location = new System.Drawing.Point(72, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 70);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // dtpMMS
            // 
            this.dtpMMS.CustomFormat = "";
            this.dtpMMS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMMS.Location = new System.Drawing.Point(109, 17);
            this.dtpMMS.Name = "dtpMMS";
            this.dtpMMS.Size = new System.Drawing.Size(106, 20);
            this.dtpMMS.TabIndex = 29;
            // 
            // frmMMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 324);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMMS";
            this.Text = "MMS - Markspen Labels";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalCashSale;
        private System.Windows.Forms.TextBox txtTotalCreditSale;
        private System.Windows.Forms.TextBox txtPartnerMobNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboPartnerName;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpMMS;
    }
}