namespace SQLiteGen
{
    partial class FrmAddTable
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
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkAllowNull = new System.Windows.Forms.CheckBox();
            this.chkIsPK = new System.Windows.Forms.CheckBox();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkAutoinc = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(82, 12);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(100, 20);
            this.txtTableName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutoinc);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.chkAllowNull);
            this.groupBox1.Controls.Add(this.chkIsPK);
            this.groupBox1.Controls.Add(this.cmbDataType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtColName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 255);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Define Columns";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 186);
            this.listBox1.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(273, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkAllowNull
            // 
            this.chkAllowNull.AutoSize = true;
            this.chkAllowNull.Location = new System.Drawing.Point(195, 43);
            this.chkAllowNull.Name = "chkAllowNull";
            this.chkAllowNull.Size = new System.Drawing.Size(72, 17);
            this.chkAllowNull.TabIndex = 5;
            this.chkAllowNull.Text = "Allow Null";
            this.chkAllowNull.UseVisualStyleBackColor = true;
            // 
            // chkIsPK
            // 
            this.chkIsPK.AutoSize = true;
            this.chkIsPK.Location = new System.Drawing.Point(195, 15);
            this.chkIsPK.Name = "chkIsPK";
            this.chkIsPK.Size = new System.Drawing.Size(81, 17);
            this.chkIsPK.TabIndex = 2;
            this.chkIsPK.Text = "Primary Key";
            this.chkIsPK.UseVisualStyleBackColor = true;
            // 
            // cmbDataType
            // 
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Items.AddRange(new object[] {
            "text",
            "integer",
            "float"});
            this.cmbDataType.Location = new System.Drawing.Point(89, 39);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(100, 21);
            this.cmbDataType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Type :";
            // 
            // txtColName
            // 
            this.txtColName.Location = new System.Drawing.Point(89, 13);
            this.txtColName.Name = "txtColName";
            this.txtColName.Size = new System.Drawing.Size(100, 20);
            this.txtColName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Column name :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(209, 295);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkAutoinc
            // 
            this.chkAutoinc.AutoSize = true;
            this.chkAutoinc.Location = new System.Drawing.Point(272, 15);
            this.chkAutoinc.Name = "chkAutoinc";
            this.chkAutoinc.Size = new System.Drawing.Size(97, 17);
            this.chkAutoinc.TabIndex = 3;
            this.chkAutoinc.Text = "Auto increment";
            this.chkAutoinc.UseVisualStyleBackColor = true;
            // 
            // FrmAddTable
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 323);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddTable";
            this.Text = "Create Table";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkAllowNull;
        private System.Windows.Forms.CheckBox chkIsPK;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkAutoinc;
    }
}