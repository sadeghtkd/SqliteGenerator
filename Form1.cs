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
    public partial class Form1 : Form
    {
        string sqliteHelperTemplate = System.IO.File.ReadAllText(Application.StartupPath + "\\SqliteHelperTemplate.java");
        string datasourceTemplate = System.IO.File.ReadAllText(Application.StartupPath + "\\DataSourceTemplate.java");
        string entityTemplate = System.IO.File.ReadAllText(Application.StartupPath + "\\EntityTemplate.java");
        List<Table> tables = new List<Table>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            FrmAddTable frm = new FrmAddTable();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(frm.table);
                tables.Add(frm.table);
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    genSqliteHelper();
                    genEntity();
                    genDatasource();
                    MessageBox.Show("Classes generated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void genSqliteHelper()
        {
            string createTemplate = "";
            string onCreateTemp = "";
            string onUpgradeTemp = "";
            int i = 0;
            foreach (var tb in tables)
            {
                i++;
                createTemplate += Environment.NewLine + "    private static final String DATABASE_CREATE" + i + " = \"create table \"" + Environment.NewLine +
                    "+ DataSource" + tb.getNameUpperCase() + ".TABLE_Name + \"(\" ";
                int c = 0;
                foreach (var field in tb.fields)
                {
                    c++;
                    createTemplate += Environment.NewLine+ " +  DataSource"+tb.getNameUpperCase()+"."+field.getColumnName()+" + \" " +field.getSqlDeclare();
                    if (c < tb.fields.Count)
                        createTemplate += " ,\"";
                    else
                        createTemplate += " \" + ";
                }
                createTemplate += Environment.NewLine + "\");\";";
                onCreateTemp += Environment.NewLine + "    database.execSQL(DATABASE_CREATE" + i + ");";
                onUpgradeTemp += Environment.NewLine + "    db.execSQL(\"DROP TABLE IF EXISTS \" + DataSource" + tb.getNameUpperCase() + ".TABLE_Name);";
            }
            sqliteHelperTemplate = string.Format(sqliteHelperTemplate, txtPackage.Text, createTemplate, txtDBName.Text, onCreateTemp, onUpgradeTemp);
            System.IO.File.WriteAllText(folderBrowserDialog1.SelectedPath + "\\MySqliteHelper.java", sqliteHelperTemplate, UTF8Encoding.UTF8);
        }

        void genEntity()
        {
            foreach (var tb in tables)
            {
                string declareTemp = "";
                string readParcelTemp = "";
                string getsetFuncTemp = "";
                string writeParcelTemp = "";
                foreach (var field in tb.fields)
                {
                    declareTemp +=Environment.NewLine + field.getVarDeclare();
                    readParcelTemp += Environment.NewLine + field.getReadParcel();
                    getsetFuncTemp += Environment.NewLine + field.getGetFunc()+
                                      Environment.NewLine + field.getSetFunc()  ;
                    writeParcelTemp += Environment.NewLine + field.getWriteParcel();

                }
                string entity = string.Format(entityTemplate, txtPackage.Text, tb.getNameUpperCase(), declareTemp, readParcelTemp, getsetFuncTemp, writeParcelTemp);
                System.IO.File.WriteAllText(folderBrowserDialog1.SelectedPath + "\\"+tb.getNameUpperCase()+".java", entity, UTF8Encoding.UTF8);
            }
        }

        void genDatasource()
        {
            foreach (var tb in tables)
            {
                string declareTemp = "";
                string allColumnsTemp = "";
                string contentValsTemp = "";
                string cursorTemp = "";
                int c = 0;
                foreach (var field in tb.fields)
                {
                    c++;
                    declareTemp += Environment.NewLine + field.getColumnDeclare();
                    allColumnsTemp += field.getColumnName() + (c < tb.fields.Count ? "," : "");
                    contentValsTemp += Environment.NewLine + field.getContentValue();
                    cursorTemp += Environment.NewLine + field.getFillObj(c-1);
                }

                string datasource = string.Format(datasourceTemplate ,txtPackage.Text, tb.getNameUpperCase(), declareTemp, allColumnsTemp, contentValsTemp, tb.getPkField().getColumnName(), tb.getPkField().getJavaType(), cursorTemp, tb.getPkField().getNameUpperCase() + "()");
                System.IO.File.WriteAllText(folderBrowserDialog1.SelectedPath + "\\DataSource" + tb.getNameUpperCase() + ".java", datasource, UTF8Encoding.UTF8);
            }
        }

    }
}
