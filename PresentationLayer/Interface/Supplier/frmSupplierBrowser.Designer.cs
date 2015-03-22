namespace Markspen_SMBS_V1.Interface.Supplier
{
    partial class frmSupplierBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierBrowser));
            this.gdSupplierBrowser = new System.Windows.Forms.DataGridView();
            this.cmdSupCancel = new System.Windows.Forms.Button();
            this.cmdSupOK = new System.Windows.Forms.Button();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdSupplierBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // gdSupplierBrowser
            // 
            this.gdSupplierBrowser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdSupplierBrowser.Location = new System.Drawing.Point(17, 85);
            this.gdSupplierBrowser.Name = "gdSupplierBrowser";
            this.gdSupplierBrowser.Size = new System.Drawing.Size(651, 396);
            this.gdSupplierBrowser.TabIndex = 17;
            // 
            // cmdSupCancel
            // 
            this.cmdSupCancel.Location = new System.Drawing.Point(593, 11);
            this.cmdSupCancel.Name = "cmdSupCancel";
            this.cmdSupCancel.Size = new System.Drawing.Size(75, 31);
            this.cmdSupCancel.TabIndex = 15;
            this.cmdSupCancel.Text = "Cancel";
            this.cmdSupCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSupOK
            // 
            this.cmdSupOK.Location = new System.Drawing.Point(501, 11);
            this.cmdSupOK.Name = "cmdSupOK";
            this.cmdSupOK.Size = new System.Drawing.Size(75, 31);
            this.cmdSupOK.TabIndex = 16;
            this.cmdSupOK.Text = "OK";
            this.cmdSupOK.UseVisualStyleBackColor = true;
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(129, 12);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(206, 20);
            this.txtSupID.TabIndex = 14;
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(129, 42);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(331, 20);
            this.txtSupName.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Supplier ID*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "Supplier Name*";
            // 
            // frmSupplierBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 492);
            this.Controls.Add(this.gdSupplierBrowser);
            this.Controls.Add(this.cmdSupCancel);
            this.Controls.Add(this.cmdSupOK);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupplierBrowser";
            this.Text = "Supplier Browser - Markspen Labels";
            ((System.ComponentModel.ISupportInitialize)(this.gdSupplierBrowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdSupplierBrowser;
        private System.Windows.Forms.Button cmdSupCancel;
        private System.Windows.Forms.Button cmdSupOK;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
    }
}