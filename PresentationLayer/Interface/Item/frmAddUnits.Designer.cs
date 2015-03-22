namespace Markspen_SMBS_V1.Interface.Item
{
    partial class frmAddUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUnits));
            this.txtWholeSalePrice = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.CmdUnitAdd = new System.Windows.Forms.Button();
            this.gdAddUnit = new System.Windows.Forms.DataGridView();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdIDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdAddUnit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWholeSalePrice
            // 
            this.txtWholeSalePrice.AutoSize = true;
            this.txtWholeSalePrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWholeSalePrice.Location = new System.Drawing.Point(6, 19);
            this.txtWholeSalePrice.Name = "txtWholeSalePrice";
            this.txtWholeSalePrice.Size = new System.Drawing.Size(66, 15);
            this.txtWholeSalePrice.TabIndex = 6;
            this.txtWholeSalePrice.Text = "Unit Name";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(80, 19);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(164, 20);
            this.txtUnitName.TabIndex = 8;
            // 
            // CmdUnitAdd
            // 
            this.CmdUnitAdd.FlatAppearance.BorderSize = 0;
            this.CmdUnitAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdUnitAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdUnitAdd.Image = global::Markspen_SMBS_V1.Properties.Resources.Minus;
            this.CmdUnitAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdUnitAdd.Location = new System.Drawing.Point(250, 11);
            this.CmdUnitAdd.Name = "CmdUnitAdd";
            this.CmdUnitAdd.Size = new System.Drawing.Size(77, 34);
            this.CmdUnitAdd.TabIndex = 18;
            this.CmdUnitAdd.Text = "Add";
            this.CmdUnitAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdUnitAdd.UseVisualStyleBackColor = true;
            // 
            // gdAddUnit
            // 
            this.gdAddUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdAddUnit.Location = new System.Drawing.Point(12, 59);
            this.gdAddUnit.Name = "gdAddUnit";
            this.gdAddUnit.Size = new System.Drawing.Size(306, 135);
            this.gdAddUnit.TabIndex = 19;
            // 
            // cmdSave
            // 
            this.cmdSave.FlatAppearance.BorderSize = 0;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Image = global::Markspen_SMBS_V1.Properties.Resources.Save;
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.Location = new System.Drawing.Point(12, 200);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(112, 52);
            this.cmdSave.TabIndex = 31;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::Markspen_SMBS_V1.Properties.Resources.exit;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(245, 200);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(99, 52);
            this.cmdExit.TabIndex = 33;
            this.cmdExit.Text = "Exit";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // cmdIDelete
            // 
            this.cmdIDelete.FlatAppearance.BorderSize = 0;
            this.cmdIDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIDelete.Image = global::Markspen_SMBS_V1.Properties.Resources.delete;
            this.cmdIDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdIDelete.Location = new System.Drawing.Point(128, 200);
            this.cmdIDelete.Name = "cmdIDelete";
            this.cmdIDelete.Size = new System.Drawing.Size(116, 52);
            this.cmdIDelete.TabIndex = 32;
            this.cmdIDelete.Text = "Delete";
            this.cmdIDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdIDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdExit);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.cmdIDelete);
            this.groupBox1.Controls.Add(this.gdAddUnit);
            this.groupBox1.Controls.Add(this.CmdUnitAdd);
            this.groupBox1.Controls.Add(this.txtWholeSalePrice);
            this.groupBox1.Controls.Add(this.txtUnitName);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 274);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // frmAddUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 284);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddUnits";
            this.Text = "Add Units - Markspen Labels";
            ((System.ComponentModel.ISupportInitialize)(this.gdAddUnit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtWholeSalePrice;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Button CmdUnitAdd;
        private System.Windows.Forms.DataGridView gdAddUnit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdIDelete;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}