namespace Markspen_SMBS_V1.Interface.Payment
{
    partial class frmCreditPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditPayment));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpRecieptDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCusName = new System.Windows.Forms.ComboBox();
            this.cboPaymentMethode = new System.Windows.Forms.ComboBox();
            this.cboCusId = new System.Windows.Forms.ComboBox();
            this.txtRecieptNo = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtChqNo = new System.Windows.Forms.TextBox();
            this.txtUnrChq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtOutstandingBal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdPay = new System.Windows.Forms.Button();
            this.dtpChqDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Customer ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpChqDate);
            this.groupBox4.Controls.Add(this.dtpRecieptDate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cboCusName);
            this.groupBox4.Controls.Add(this.cboPaymentMethode);
            this.groupBox4.Controls.Add(this.cboCusId);
            this.groupBox4.Controls.Add(this.txtRecieptNo);
            this.groupBox4.Controls.Add(this.txtBank);
            this.groupBox4.Controls.Add(this.txtChqNo);
            this.groupBox4.Controls.Add(this.txtUnrChq);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtAmount);
            this.groupBox4.Controls.Add(this.txtOutstandingBal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 302);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // dtpRecieptDate
            // 
            this.dtpRecieptDate.CustomFormat = "";
            this.dtpRecieptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecieptDate.Location = new System.Drawing.Point(433, 21);
            this.dtpRecieptDate.Name = "dtpRecieptDate";
            this.dtpRecieptDate.Size = new System.Drawing.Size(97, 20);
            this.dtpRecieptDate.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Reciept Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Customer Name";
            // 
            // cboCusName
            // 
            this.cboCusName.FormattingEnabled = true;
            this.cboCusName.Location = new System.Drawing.Point(279, 64);
            this.cboCusName.Name = "cboCusName";
            this.cboCusName.Size = new System.Drawing.Size(251, 21);
            this.cboCusName.Sorted = true;
            this.cboCusName.TabIndex = 8;
            // 
            // cboPaymentMethode
            // 
            this.cboPaymentMethode.FormattingEnabled = true;
            this.cboPaymentMethode.Location = new System.Drawing.Point(167, 132);
            this.cboPaymentMethode.Name = "cboPaymentMethode";
            this.cboPaymentMethode.Size = new System.Drawing.Size(106, 21);
            this.cboPaymentMethode.Sorted = true;
            this.cboPaymentMethode.TabIndex = 8;
            // 
            // cboCusId
            // 
            this.cboCusId.FormattingEnabled = true;
            this.cboCusId.Location = new System.Drawing.Point(99, 60);
            this.cboCusId.Name = "cboCusId";
            this.cboCusId.Size = new System.Drawing.Size(71, 21);
            this.cboCusId.Sorted = true;
            this.cboCusId.TabIndex = 8;
            // 
            // txtRecieptNo
            // 
            this.txtRecieptNo.Location = new System.Drawing.Point(99, 21);
            this.txtRecieptNo.Name = "txtRecieptNo";
            this.txtRecieptNo.Size = new System.Drawing.Size(111, 20);
            this.txtRecieptNo.TabIndex = 9;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(375, 184);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(155, 20);
            this.txtBank.TabIndex = 9;
            // 
            // txtChqNo
            // 
            this.txtChqNo.Location = new System.Drawing.Point(143, 184);
            this.txtChqNo.Name = "txtChqNo";
            this.txtChqNo.Size = new System.Drawing.Size(72, 20);
            this.txtChqNo.TabIndex = 9;
            // 
            // txtUnrChq
            // 
            this.txtUnrChq.Location = new System.Drawing.Point(424, 97);
            this.txtUnrChq.Name = "txtUnrChq";
            this.txtUnrChq.Size = new System.Drawing.Size(106, 20);
            this.txtUnrChq.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unrealized Checque";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(424, 129);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(106, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // txtOutstandingBal
            // 
            this.txtOutstandingBal.Location = new System.Drawing.Point(167, 97);
            this.txtOutstandingBal.Name = "txtOutstandingBal";
            this.txtOutstandingBal.Size = new System.Drawing.Size(106, 20);
            this.txtOutstandingBal.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "If Cheque Payment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(341, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Amount (LKR)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Payment Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Outstanding balance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bank";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(265, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "CHQ Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "CHQ No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Reciept No:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdPrint);
            this.groupBox6.Controls.Add(this.cmdExit);
            this.groupBox6.Controls.Add(this.cmdPay);
            this.groupBox6.Location = new System.Drawing.Point(99, 219);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(389, 69);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = ";";
            // 
            // cmdPrint
            // 
            this.cmdPrint.FlatAppearance.BorderSize = 0;
            this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrint.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.Image = global::Markspen_SMBS_V1.Properties.Resources.print;
            this.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrint.Location = new System.Drawing.Point(134, 10);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(107, 52);
            this.cmdPrint.TabIndex = 21;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::Markspen_SMBS_V1.Properties.Resources.exit1;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(263, 10);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(116, 52);
            this.cmdExit.TabIndex = 18;
            this.cmdExit.Text = "Exit";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // cmdPay
            // 
            this.cmdPay.FlatAppearance.BorderSize = 0;
            this.cmdPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPay.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPay.Image = global::Markspen_SMBS_V1.Properties.Resources.doller;
            this.cmdPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPay.Location = new System.Drawing.Point(5, 10);
            this.cmdPay.Name = "cmdPay";
            this.cmdPay.Size = new System.Drawing.Size(100, 52);
            this.cmdPay.TabIndex = 19;
            this.cmdPay.Text = "Pay";
            this.cmdPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPay.UseVisualStyleBackColor = true;
            // 
            // dtpChqDate
            // 
            this.dtpChqDate.CustomFormat = "";
            this.dtpChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChqDate.Location = new System.Drawing.Point(248, 184);
            this.dtpChqDate.Name = "dtpChqDate";
            this.dtpChqDate.Size = new System.Drawing.Size(106, 20);
            this.dtpChqDate.TabIndex = 32;
            // 
            // frmCreditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 312);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreditPayment";
            this.Text = "Credit Payment - Markspen labels";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboCusName;
        private System.Windows.Forms.ComboBox cboCusId;
        private System.Windows.Forms.TextBox txtChqNo;
        private System.Windows.Forms.TextBox txtUnrChq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutstandingBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdPay;
        private System.Windows.Forms.DateTimePicker dtpRecieptDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPaymentMethode;
        private System.Windows.Forms.TextBox txtRecieptNo;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpChqDate;
    }
}