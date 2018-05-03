using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLiteGen
{
    public partial class FrmAddTable : Form
    {
        public Table table = new Table();
        public FrmAddTable()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Field f = new Field();
            f.name = txtColName.Text;
            f.dataType = cmbDataType.Text;
            f.allowNull = chkAllowNull.Checked;
            f.isPK = chkIsPK.Checked;
            f.autoincrement = chkAutoinc.Checked;
            table.fields.Add(f);
            listBox1.Items.Add(f);
            txtColName.Text = "";
            cmbDataType.SelectedIndex = 0;
            chkIsPK.Checked = false;
            chkAutoinc.Checked = false;
            txtColName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            table.name = txtTableName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
