using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class StateChangeForm : Form
    {
        public string uid;
        public StateChangeForm(string uid)
        {
            InitializeComponent();
            this.uid = uid;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string tid = tbxUid.Text;
            if (tid == "")
            {
                return;
            }
            if (tid == uid)
            {
                MessageBox.Show("不能修改自己的权限！");
            }
            else
            {
                string condition = SqlHelper.ConditionMake("Uid", tid);
                DataRowCollection drc = SqlHelper.SelectRows("Users", condition);
                if (drc == null || drc.Count == 0)
                {
                    MessageBox.Show("用户不存在！");
                }
                else
                {
                    DataRow dr = drc[0];
                    if ((string)dr["Ustate"] != cbxState.Text)
                    {
                        dr["Ustate"] = cbxState.Text;
                        SqlHelper.SqlModify("Users", MainForm.usersColName, dr.ItemArray, condition);
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
