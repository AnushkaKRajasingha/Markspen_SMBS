namespace Markspen_SMBS_V1.Interface.Inventory
{
    partial class frmAddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStock));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdDeleteFromStok = new System.Windows.Forms.Button();
            this.cmdAddToStok = new System.Windows.Forms.Button();
            this.cmdStockPrint = new System.Windows.Forms.Button();
            this.cmdStockSave = new System.Windows.Forms.Button();
            this.dtpStock = new System.Windows.Forms.DateTimePicker();
            this.cmdStockExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboItemDescription = new System.Windows.Forms.ComboBox();
            this.cboSupName = new System.Windows.Forms.ComboBox();
            this.cboItemID = new System.Windows.Forms.ComboBox();
            this.cboSupId = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 222);
            this.dataGridView1.TabIndex = 24;
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(486, 150);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(70, 20);
            this.txtBin.TabIndex = 9;
            this.txtBin.TextChanged += new System.EventHandler(this.txtBin_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(319, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Stock No";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdDeleteFromStok);
            this.groupBox4.Controls.Add(this.cmdAddToStok);
            this.groupBox4.Controls.Add(this.cmdStockPrint);
            this.groupBox4.Controls.Add(this.cmdStockSave);
            this.groupBox4.Controls.Add(this.dtpStock);
            this.groupBox4.Controls.Add(this.cmdStockExit);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.cboItemDescription);
            this.groupBox4.Controls.Add(this.cboSupName);
            this.groupBox4.Controls.Add(this.cboItemID);
            this.groupBox4.Controls.Add(this.cboSupId);
            this.groupBox4.Controls.Add(this.txtUnit);
            this.groupBox4.Controls.Add(this.txtQty);
            this.groupBox4.Controls.Add(this.txtBin);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtTotalQty);
            this.groupBox4.Controls.Add(this.txtBarcode);
            this.groupBox4.Controls.Add(this.txtStockNo);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(12, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 469);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // cmdDeleteFromStok
            // 
            this.cmdDeleteFromStok.FlatAppearance.BorderSize = 0;
            this.cmdDeleteFromStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeleteFromStok.Image = global::Markspen_SMBS_V1.Properties.Resources.Add1;
            this.cmdDeleteFromStok.Location = new System.Drawing.Point(643, 230);
            this.cmdDeleteFromStok.Name = "cmdDeleteFromStok";
            this.cmdDeleteFromStok.Size = new System.Drawing.Size(30, 30);
            this.cmdDeleteFromStok.TabIndex = 31;
            this.cmdDeleteFromStok.UseVisualStyleBackColor = true;
            // 
            // cmdAddToStok
            // 
            this.cmdAddToStok.FlatAppearance.BorderSize = 0;
            this.cmdAddToStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddToStok.Image = global::Markspen_SMBS_V1.Properties.Resources.Minus;
            this.cmdAddToStok.Location = new System.Drawing.Point(641, 177);
            this.cmdAddToStok.Name = "cmdAddToStok";
            this.cmdAddToStok.Size = new System.Drawing.Size(32, 30);
            this.cmdAddToStok.TabIndex = 30;
            this.cmdAddToStok.UseVisualStyleBackColor = true;
            // 
            // cmdStockPrint
            // 
            this.cmdStockPrint.FlatAppearance.BorderSize = 0;
            this.cmdStockPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStockPrint.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStockPrint.Image = global::Markspen_SMBS_V1.Properties.Resources.print;
            this.cmdStockPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStockPrint.Location = new System.Drawing.Point(278, 413);
            this.cmdStockPrint.Name = "cmdStockPrint";
            this.cmdStockPrint.Size = new System.Drawing.Size(107, 52);
            this.cmdStockPrint.TabIndex = 21;
            this.cmdStockPrint.Text = "Print";
            this.cmdStockPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStockPrint.UseVisualStyleBackColor = true;
            // 
            // cmdStockSave
            // 
            this.cmdStockSave.FlatAppearance.BorderSize = 0;
            this.cmdStockSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStockSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStockSave.Image = global::Markspen_SMBS_V1.Properties.Resources.Save;
            this.cmdStockSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStockSave.Location = new System.Drawing.Point(149, 413);
            this.cmdStockSave.Name = "cmdStockSave";
            this.cmdStockSave.Size = new System.Drawing.Size(112, 52);
            this.cmdStockSave.TabIndex = 19;
            this.cmdStockSave.Text = "Save";
            this.cmdStockSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStockSave.UseVisualStyleBackColor = true;
            // 
            // dtpStock
            // 
            this.dtpStock.CustomFormat = "";
            this.dtpStock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStock.Location = new System.Drawing.Point(90, 19);
            this.dtpStock.Name = "dtpStock";
            this.dtpStock.Size = new System.Drawing.Size(97, 20);
            this.dtpStock.TabIndex = 28;
            // 
            // cmdStockExit
            // 
            this.cmdStockExit.FlatAppearance.BorderSize = 0;
            this.cmdStockExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStockExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStockExit.Image = global::Markspen_SMBS_V1.Properties.Resources.exit1;
            this.cmdStockExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStockExit.Location = new System.Drawing.Point(407, 413);
            this.cmdStockExit.Name = "cmdStockExit";
            this.cmdStockExit.Size = new System.Drawing.Size(116, 52);
            this.cmdStockExit.TabIndex = 18;
            this.cmdStockExit.Text = "Exit";
            this.cmdStockExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStockExit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Stock Date";
            // 
            // cboItemDescription
            // 
            this.cboItemDescription.FormattingEnabled = true;
            this.cboItemDescription.Location = new System.Drawing.Point(90, 150);
            this.cboItemDescription.Name = "cboItemDescription";
            this.cboItemDescription.Size = new System.Drawing.Size(287, 21);
            this.cboItemDescription.Sorted = true;
            this.cboItemDescription.TabIndex = 8;
            // 
            // cboSupName
            // 
            this.cboSupName.FormattingEnabled = true;
            this.cboSupName.Location = new System.Drawing.Point(167, 64);
            this.cboSupName.Name = "cboSupName";
            this.cboSupName.Size = new System.Drawing.Size(374, 21);
            this.cboSupName.Sorted = true;
            this.cboSupName.TabIndex = 8;
            // 
            // cboItemID
            // 
            this.cboItemID.FormattingEnabled = true;
            this.cboItemID.Location = new System.Drawing.Point(13, 150);
            this.cboItemID.Name = "cboItemID";
            this.cboItemID.Size = new System.Drawing.Size(71, 21);
            this.cboItemID.Sorted = true;
            this.cboItemID.TabIndex = 8;
            // 
            // cboSupId
            // 
            this.cboSupId.FormattingEnabled = true;
            this.cboSupId.Location = new System.Drawing.Point(90, 64);
            this.cboSupId.Name = "cboSupId";
            this.cboSupId.Size = new System.Drawing.Size(71, 21);
            this.cboSupId.Sorted = true;
            this.cboSupId.TabIndex = 8;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(407, 150);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(70, 20);
            this.txtUnit.TabIndex = 9;
            this.txtUnit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(565, 150);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(70, 20);
            this.txtQty.TabIndex = 9;
            this.txtQty.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Unit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Location = new System.Drawing.Point(379, 96);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(78, 20);
            this.txtTotalQty.TabIndex = 9;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(90, 96);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(181, 20);
            this.txtBarcode.TabIndex = 9;
            // 
            // txtStockNo
            // 
            this.txtStockNo.Location = new System.Drawing.Point(380, 19);
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(161, 20);
            this.txtStockNo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Qty.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "BIN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total Qty.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Supplier";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(12, 400);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox6.Size = new System.Drawing.Size(623, 69);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = ";";
            // 
            // frmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 491);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddStock";
            this.Text = "Add Stock -Markspen Labels";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.Button cmdStockPrint;
        private System.Windows.Forms.Button cmdStockSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdStockExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtpStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboItemDescription;
        private System.Windows.Forms.ComboBox cboSupName;
        private System.Windows.Forms.ComboBox cboItemID;
        private System.Windows.Forms.ComboBox cboSupId;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDeleteFromStok;
        private System.Windows.Forms.Button cmdAddToStok;
    }
}