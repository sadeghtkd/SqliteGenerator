using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteGen
{
    public class Table
    {
        public string name;
        public List<Field> fields = new List<Field>();

        public override string ToString()
        {
            string cols = "";
            int c = 0;
            foreach (var item in fields)
            {
                c++;
                cols += item.name + (c < fields.Count ?  "," : "");
            }
            return this.name +" ("+cols+")";
        }

        public string getNameUpperCase()
        {
            return Util.FirstCharToUpper(this.name);
        }
        public Field getPkField()
        {
            foreach (var item in fields)
            {
                if (item.isPK)
                    return item;
            }
            return new Field();
        }
    }

    public class Field
    {
        public string name;
        public string dataType;
        public bool isPK;
        public bool allowNull;
        public bool autoincrement;

        public override string ToString()
        {
            return this.name+"\t"+this.dataType;
        }

        public string getColumnName()
        {
            return "COLUMN_" + getNameUpperCase();
        }
        public string getNameUpperCase()
        {
           return Util.FirstCharToUpper(this.name);
        }
        public string getJavaType()
        {
            if (dataType == "text")
                return "String";
            else if (dataType == "integer")
                return "int";
            else if (dataType == "float")
                return "float";
            else
                return "";
        }        
        public string getInitValue()
        {
            if (dataType == "text")
                return "\"\"";
            else if (dataType == "integer")
                return "0";
            else if (dataType == "float")
                return "0.0";
            else
                return "";
        }

        public string getColumnDeclare()
        {
            return "    public static final String " + getColumnName() + " = \"" + this.name + "\";";
        }
        public string getVarDeclare()
        {
            return "    private "+getJavaType()+" "+this.name+" = "+getInitValue()+" ;";
        }
        public string getReadParcel()
        {
            return "        " + this.name + " = in.read" + Util.FirstCharToUpper(getJavaType()) + "() ;";
        }
        public string getWriteParcel()
        {
            return "        out.write" + Util.FirstCharToUpper(getJavaType()) + "(" + this.name + ");";
        }
        public string getGetFunc()
        {
            return "    public " + getJavaType() + " get" + getNameUpperCase() + "(){" + Environment.NewLine
                    + "        return " + this.name + ";" + Environment.NewLine + "    }";
        }
        public string getSetFunc()
        {
            return "    public void set" + getNameUpperCase() + "(" + getJavaType() + " " + this.name + "){" + Environment.NewLine
                    + "        this." + this.name + " = " + this.name + " ;" + Environment.NewLine + "    }";
        }
        public string getContentValue()
        {
            return "        values.put(" + getColumnName() + " , p.get" + getNameUpperCase() + "() );";
        }
        public string getFillObj(int index)
        {
            return "        obj.set" + getNameUpperCase() + "(cursor.get" + Util.FirstCharToUpper(getJavaType()) + "(" + index + ") );";
        }
        public string getSqlDeclare()
        {
            return " " + dataType + " " + (isPK ? "primary key " : " ") + " " + (autoincrement ? "autoincrement " : " ") + " " + (allowNull ? " " : "not null ");
        }
    }
}
