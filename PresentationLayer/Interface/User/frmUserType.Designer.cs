namespace Markspen_SMBS_V1.Interface.User
{
    partial class frmUserType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserType));
            this.gdAddUser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdCusEdit = new System.Windows.Forms.Button();
            this.cmdCusExit = new System.Windows.Forms.Button();
            this.cmdStockSave = new System.Windows.Forms.Button();
            this.chkGrantAccess = new System.Windows.Forms.CheckBox();
            this.chkAddUser = new System.Windows.Forms.CheckBox();
            this.chkPartner = new System.Windows.Forms.CheckBox();
            this.chkCreditPayment = new System.Windows.Forms.CheckBox();
            this.chkMMS = new System.Windows.Forms.CheckBox();
            this.chkSupplier = new System.Windows.Forms.CheckBox();
            this.chkViewInventory = new System.Windows.Forms.CheckBox();
            this.chkChqStatus = new System.Windows.Forms.CheckBox();
            this.chkItem = new System.Windows.Forms.CheckBox();
            this.chkPurchaseOrder = new System.Windows.Forms.CheckBox();
            this.chkStockAdj = new System.Windows.Forms.CheckBox();
            this.chkCashPayment = new System.Windows.Forms.CheckBox();
            this.chkAddInvoice = new System.Windows.Forms.CheckBox();
            this.chkApproveCredits = new System.Windows.Forms.CheckBox();
            this.chkAddStock = new System.Windows.Forms.CheckBox();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.CmdUserAdd = new System.Windows.Forms.Button();
            this.txtWholeSalePrice = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdAddUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdAddUser
            // 
            this.gdAddUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdAddUser.Location = new System.Drawing.Point(27, 45);
            this.gdAddUser.Name = "gdAddUser";
            this.gdAddUser.Size = new System.Drawing.Size(347, 106);
            this.gdAddUser.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gdAddUser);
            this.groupBox1.Controls.Add(this.CmdUserAdd);
            this.groupBox1.Controls.Add(this.txtWholeSalePrice);
            this.groupBox1.Controls.Add(this.txtUserType);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 510);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.chkGrantAccess);
            this.groupBox2.Controls.Add(this.chkAddUser);
            this.groupBox2.Controls.Add(this.chkPartner);
            this.groupBox2.Controls.Add(this.chkCreditPayment);
            this.groupBox2.Controls.Add(this.chkMMS);
            this.groupBox2.Controls.Add(this.chkSupplier);
            this.groupBox2.Controls.Add(this.chkViewInventory);
            this.groupBox2.Controls.Add(this.chkChqStatus);
            this.groupBox2.Controls.Add(this.chkItem);
            this.groupBox2.Controls.Add(this.chkPurchaseOrder);
            this.groupBox2.Controls.Add(this.chkStockAdj);
            this.groupBox2.Controls.Add(this.chkCashPayment);
            this.groupBox2.Controls.Add(this.chkAddInvoice);
            this.groupBox2.Controls.Add(this.chkApproveCredits);
            this.groupBox2.Controls.Add(this.chkAddStock);
            this.groupBox2.Controls.Add(this.chkCustomer);
            this.groupBox2.Location = new System.Drawing.Point(13, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 355);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Access Rights";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdCusEdit);
            this.groupBox3.Controls.Add(this.cmdCusExit);
            this.groupBox3.Controls.Add(this.cmdStockSave);
            this.groupBox3.Location = new System.Drawing.Point(6, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 72);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // cmdCusEdit
            // 
            this.cmdCusEdit.FlatAppearance.BorderSize = 0;
            this.cmdCusEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCusEdit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCusEdit.Image = global::Markspen_SMBS_V1.Properties.Resources.delete;
            this.cmdCusEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCusEdit.Location = new System.Drawing.Point(126, 9);
            this.cmdCusEdit.Name = "cmdCusEdit";
            this.cmdCusEdit.Size = new System.Drawing.Size(117, 57);
            this.cmdCusEdit.TabIndex = 22;
            this.cmdCusEdit.Text = "Delete";
            this.cmdCusEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCusEdit.UseVisualStyleBackColor = true;
            // 
            // cmdCusExit
            // 
            this.cmdCusExit.FlatAppearance.BorderSize = 0;
            this.cmdCusExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCusExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCusExit.Image = global::Markspen_SMBS_V1.Properties.Resources.exit;
            this.cmdCusExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCusExit.Location = new System.Drawing.Point(251, 9);
            this.cmdCusExit.Name = "cmdCusExit";
            this.cmdCusExit.Size = new System.Drawing.Size(99, 57);
            this.cmdCusExit.TabIndex = 23;
            this.cmdCusExit.Text = "Exit";
            this.cmdCusExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCusExit.UseVisualStyleBackColor = true;
            // 
            // cmdStockSave
            // 
            this.cmdStockSave.FlatAppearance.BorderSize = 0;
            this.cmdStockSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStockSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStockSave.Image = global::Markspen_SMBS_V1.Properties.Resources.Save;
            this.cmdStockSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdStockSave.Location = new System.Drawing.Point(8, 14);
            this.cmdStockSave.Name = "cmdStockSave";
            this.cmdStockSave.Size = new System.Drawing.Size(112, 52);
            this.cmdStockSave.TabIndex = 24;
            this.cmdStockSave.Text = "Save";
            this.cmdStockSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdStockSave.UseVisualStyleBackColor = true;
            // 
            // chkGrantAccess
            // 
            this.chkGrantAccess.AutoSize = true;
            this.chkGrantAccess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGrantAccess.Location = new System.Drawing.Point(218, 243);
            this.chkGrantAccess.Name = "chkGrantAccess";
            this.chkGrantAccess.Size = new System.Drawing.Size(109, 23);
            this.chkGrantAccess.TabIndex = 0;
            this.chkGrantAccess.Text = "Grant Acces";
            this.chkGrantAccess.UseVisualStyleBackColor = true;
            // 
            // chkAddUser
            // 
            this.chkAddUser.AutoSize = true;
            this.chkAddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddUser.Location = new System.Drawing.Point(218, 211);
            this.chkAddUser.Name = "chkAddUser";
            this.chkAddUser.Size = new System.Drawing.Size(90, 23);
            this.chkAddUser.TabIndex = 0;
            this.chkAddUser.Text = "Add User";
            this.chkAddUser.UseVisualStyleBackColor = true;
            // 
            // chkPartner
            // 
            this.chkPartner.AutoSize = true;
            this.chkPartner.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPartner.Location = new System.Drawing.Point(29, 243);
            this.chkPartner.Name = "chkPartner";
            this.chkPartner.Size = new System.Drawing.Size(80, 23);
            this.chkPartner.TabIndex = 0;
            this.chkPartner.Text = "Partner";
            this.chkPartner.UseVisualStyleBackColor = true;
            // 
            // chkCreditPayment
            // 
            this.chkCreditPayment.AutoSize = true;
            this.chkCreditPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreditPayment.Location = new System.Drawing.Point(218, 115);
            this.chkCreditPayment.Name = "chkCreditPayment";
            this.chkCreditPayment.Size = new System.Drawing.Size(140, 23);
            this.chkCreditPayment.TabIndex = 0;
            this.chkCreditPayment.Text = "Credit Payments";
            this.chkCreditPayment.UseVisualStyleBackColor = true;
            // 
            // chkMMS
            // 
            this.chkMMS.AutoSize = true;
            this.chkMMS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMMS.Location = new System.Drawing.Point(29, 211);
            this.chkMMS.Name = "chkMMS";
            this.chkMMS.Size = new System.Drawing.Size(64, 23);
            this.chkMMS.TabIndex = 0;
            this.chkMMS.Text = "MMS";
            this.chkMMS.UseVisualStyleBackColor = true;
            // 
            // chkSupplier
            // 
            this.chkSupplier.AutoSize = true;
            this.chkSupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSupplier.Location = new System.Drawing.Point(218, 179);
            this.chkSupplier.Name = "chkSupplier";
            this.chkSupplier.Size = new System.Drawing.Size(85, 23);
            this.chkSupplier.TabIndex = 0;
            this.chkSupplier.Text = "Supplier";
            this.chkSupplier.UseVisualStyleBackColor = true;
            // 
            // chkViewInventory
            // 
            this.chkViewInventory.AutoSize = true;
            this.chkViewInventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkViewInventory.Location = new System.Drawing.Point(29, 115);
            this.chkViewInventory.Name = "chkViewInventory";
            this.chkViewInventory.Size = new System.Drawing.Size(132, 23);
            this.chkViewInventory.TabIndex = 0;
            this.chkViewInventory.Text = "View Inventory";
            this.chkViewInventory.UseVisualStyleBackColor = true;
            // 
            // chkChqStatus
            // 
            this.chkChqStatus.AutoSize = true;
            this.chkChqStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChqStatus.Location = new System.Drawing.Point(218, 83);
            this.chkChqStatus.Name = "chkChqStatus";
            this.chkChqStatus.Size = new System.Drawing.Size(126, 23);
            this.chkChqStatus.TabIndex = 0;
            this.chkChqStatus.Text = "Cheque Status";
            this.chkChqStatus.UseVisualStyleBackColor = true;
            // 
            // chkItem
            // 
            this.chkItem.AutoSize = true;
            this.chkItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItem.Location = new System.Drawing.Point(29, 179);
            this.chkItem.Name = "chkItem";
            this.chkItem.Size = new System.Drawing.Size(59, 23);
            this.chkItem.TabIndex = 0;
            this.chkItem.Text = "Item";
            this.chkItem.UseVisualStyleBackColor = true;
            // 
            // chkPurchaseOrder
            // 
            this.chkPurchaseOrder.AutoSize = true;
            this.chkPurchaseOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPurchaseOrder.Location = new System.Drawing.Point(218, 147);
            this.chkPurchaseOrder.Name = "chkPurchaseOrder";
            this.chkPurchaseOrder.Size = new System.Drawing.Size(134, 23);
            this.chkPurchaseOrder.TabIndex = 0;
            this.chkPurchaseOrder.Text = "Purchase Order";
            this.chkPurchaseOrder.UseVisualStyleBackColor = true;
            // 
            // chkStockAdj
            // 
            this.chkStockAdj.AutoSize = true;
            this.chkStockAdj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStockAdj.Location = new System.Drawing.Point(29, 83);
            this.chkStockAdj.Name = "chkStockAdj";
            this.chkStockAdj.Size = new System.Drawing.Size(149, 23);
            this.chkStockAdj.TabIndex = 0;
            this.chkStockAdj.Text = "Stock Adjestment";
            this.chkStockAdj.UseVisualStyleBackColor = true;
            // 
            // chkCashPayment
            // 
            this.chkCashPayment.AutoSize = true;
            this.chkCashPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCashPayment.Location = new System.Drawing.Point(218, 51);
            this.chkCashPayment.Name = "chkCashPayment";
            this.chkCashPayment.Size = new System.Drawing.Size(124, 23);
            this.chkCashPayment.TabIndex = 0;
            this.chkCashPayment.Text = "Cash Payment";
            this.chkCashPayment.UseVisualStyleBackColor = true;
            // 
            // chkAddInvoice
            // 
            this.chkAddInvoice.AutoSize = true;
            this.chkAddInvoice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddInvoice.Location = new System.Drawing.Point(29, 147);
            this.chkAddInvoice.Name = "chkAddInvoice";
            this.chkAddInvoice.Size = new System.Drawing.Size(109, 23);
            this.chkAddInvoice.TabIndex = 0;
            this.chkAddInvoice.Text = "Add Invoice";
            this.chkAddInvoice.UseVisualStyleBackColor = true;
            // 
            // chkApproveCredits
            // 
            this.chkApproveCredits.AutoSize = true;
            this.chkApproveCredits.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApproveCredits.Location = new System.Drawing.Point(218, 19);
            this.chkApproveCredits.Name = "chkApproveCredits";
            this.chkApproveCredits.Size = new System.Drawing.Size(138, 23);
            this.chkApproveCredits.TabIndex = 0;
            this.chkApproveCredits.Text = "Approve Credits";
            this.chkApproveCredits.UseVisualStyleBackColor = true;
            // 
            // chkAddStock
            // 
            this.chkAddStock.AutoSize = true;
            this.chkAddStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddStock.Location = new System.Drawing.Point(29, 51);
            this.chkAddStock.Name = "chkAddStock";
            this.chkAddStock.Size = new System.Drawing.Size(98, 23);
            this.chkAddStock.TabIndex = 0;
            this.chkAddStock.Text = "Add Stock";
            this.chkAddStock.UseVisualStyleBackColor = true;
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomer.Location = new System.Drawing.Point(29, 19);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(97, 23);
            this.chkCustomer.TabIndex = 0;
            this.chkCustomer.Text = "Customer ";
            this.chkCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdUserAdd
            // 
            this.CmdUserAdd.FlatAppearance.BorderSize = 0;
            this.CmdUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdUserAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdUserAdd.Image = global::Markspen_SMBS_V1.Properties.Resources.Minus;
            this.CmdUserAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdUserAdd.Location = new System.Drawing.Point(276, 11);
            this.CmdUserAdd.Name = "CmdUserAdd";
            this.CmdUserAdd.Size = new System.Drawing.Size(77, 34);
            this.CmdUserAdd.TabIndex = 18;
            this.CmdUserAdd.Text = "Add";
            this.CmdUserAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdUserAdd.UseVisualStyleBackColor = true;
            // 
            // txtWholeSalePrice
            // 
            this.txtWholeSalePrice.AutoSize = true;
            this.txtWholeSalePrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWholeSalePrice.Location = new System.Drawing.Point(32, 19);
            this.txtWholeSalePrice.Name = "txtWholeSalePrice";
            this.txtWholeSalePrice.Size = new System.Drawing.Size(61, 15);
            this.txtWholeSalePrice.TabIndex = 6;
            this.txtWholeSalePrice.Text = "User Type";
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(106, 19);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(164, 20);
            this.txtUserType.TabIndex = 8;
            // 
            // frmUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 524);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserType";
            this.Text = "Add UserType -Markspen Labels";
            this.UserIsAllowed += new System.EventHandler(this.frmUserType_UserIsAllowed);
            ((System.ComponentModel.ISupportInitialize)(this.gdAddUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdAddUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CmdUserAdd;
        private System.Windows.Forms.Label txtWholeSalePrice;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdCusEdit;
        private System.Windows.Forms.Button cmdCusExit;
        private System.Windows.Forms.Button cmdStockSave;
        private System.Windows.Forms.CheckBox chkGrantAccess;
        private System.Windows.Forms.CheckBox chkAddUser;
        private System.Windows.Forms.CheckBox chkPartner;
        private System.Windows.Forms.CheckBox chkCreditPayment;
        private System.Windows.Forms.CheckBox chkMMS;
        private System.Windows.Forms.CheckBox chkSupplier;
        private System.Windows.Forms.CheckBox chkViewInventory;
        private System.Windows.Forms.CheckBox chkChqStatus;
        private System.Windows.Forms.CheckBox chkItem;
        private System.Windows.Forms.CheckBox chkPurchaseOrder;
        private System.Windows.Forms.CheckBox chkStockAdj;
        private System.Windows.Forms.CheckBox chkCashPayment;
        private System.Windows.Forms.CheckBox chkAddInvoice;
        private System.Windows.Forms.CheckBox chkApproveCredits;
        private System.Windows.Forms.CheckBox chkAddStock;
        private System.Windows.Forms.CheckBox chkCustomer;
    }
}