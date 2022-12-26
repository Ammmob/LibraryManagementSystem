using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class Table : UserControl
    {
        private string name;
        private string state;
        private DataTable dt;
        private string uid;
        private List<string> columnNameList = new List<string>();
        public Table(string uid,string name,string state)
        {
            InitializeComponent();
            this.uid = uid;
            this.name = name;
            this.state = state;
            dt = SqlHelper.Select(name);
            bs.DataSource = dt;
            dgv.DataSource = bs;
            bn.BindingSource = bs;
            foreach(DataColumn col in dt.Columns)
            {
                columnNameList.Add(col.ColumnName);
            }
            PermissionControl();
            Reset();
        }

        public void Save()
        {
            DataTable cdt = dt.GetChanges();
          

            if (cdt == null)
            {
                return;
            }

            foreach (DataRow dr in cdt.Rows)
            {
                string condition;
                Debug.WriteLine(dr.RowState);
                if (dr.RowState == DataRowState.Added)
                {
       
                    SqlHelper.SqlInsert(name, dr.ItemArray);
                }
                else if (dr.RowState == DataRowState.Deleted)
                {
                    condition = SqlHelper.ConditionMake(columnNameList[0], (string)dr[0, DataRowVersion.Original]);
                    SqlHelper.SqlDelete(name, condition);
                }
                else if (dr.RowState == DataRowState.Modified)
                {
                    condition = SqlHelper.ConditionMake(columnNameList[0], (string)dr[0, DataRowVersion.Original]);
                    SqlHelper.SqlModify(name, columnNameList, dr.ItemArray, condition);
                }
            }
            Reset();
        }

        public void Reset()
        {
            if (name == "Borrow"&&state!="管理员")
            {
                string condition = SqlHelper.ConditionMake("Uid", uid);
                dt = SqlHelper.Select(name, condition);
            }
            else
            {
                dt = SqlHelper.Select(name);
            }
           
            TableInit();
            bs.DataSource = dt;
        }

        public void Select(string condition,string selected="*")
        {
            dt = SqlHelper.Select(name, condition, selected);
            bs.DataSource = dt;
        }

        public void TableInit()
        {
            if (name == "Users")
            {
                
                dt.Columns.RemoveAt(2);
                dt.Columns["Uid"].ColumnName = "账户";
                dt.Columns["Uname"].ColumnName = "昵称";
                dt.Columns["Ustate"].ColumnName = "身份";
                dt.Columns.Add("学号");
                string condition;
                foreach(DataRow dr in dt.Rows)
                {
                    condition = SqlHelper.ConditionMake("Uid", (string)dr["账户"]);
                    DataRow sdr = SqlHelper.SelectRows("US", condition)[0];
                    dr["学号"] = sdr["Sid"];
                   
                }
            }
            else if (name == "Books")
            {
                dt.Columns["Bid"].ColumnName = "书号";
                dt.Columns["Bname"].ColumnName = "书名";
                dt.Columns["Bauthor"].ColumnName = "作者";
                dt.Columns["Bpbr"].ColumnName = "出版社";
                dt.Columns["Bnum"].ColumnName = "库存数量";
                dt.Columns["Btype"].ColumnName = "类型";
            }
            else if (name == "Borrow")
            {
                dt.Columns["Bid"].ColumnName = "书号";
                dt.Columns["Uid"].ColumnName = "账户";
                dt.Columns["Bdate"].ColumnName = "借出日期";
                dt.Columns["Ddate"].ColumnName = "截止日期";
                dt.Columns["Bstate"].ColumnName = "状态";
            }
        }

        private  void PermissionControl()
        {
            if (state != "管理员"||name=="Borrow"||name=="Users")
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.ReadOnly = true;
            }
        }

        private void Table_Load(object sender, EventArgs e)
        {
            int width =((TabPage)Parent).Width;
            int height = ((TabPage)Parent).Height;
            Size = new System.Drawing.Size((int)(0.75 * width), (int)(0.75 * height));
            Location = new Point((width-this.Width)/2, (int)(0.2*height));
            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        }
    }
}
