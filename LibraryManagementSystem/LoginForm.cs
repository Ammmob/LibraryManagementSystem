using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public static string state { get; private set; }
        public static string id;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
          
        }

        private string check(string account,string password)
        {

            string condition = SqlHelper.ConditionMake("Uid", account);
            DataRowCollection drc = SqlHelper.SelectRows("Users", condition);
            if (drc == null||drc.Count==0)
            {
                MessageBox.Show("账户不存在！");
                Debug.WriteLine("账户不存在!");
                return "";
            }
            DataRow dr = drc[0];

            if ((string)dr["Upsd"] == password)
            {
                return (string)dr["Ustate"];
            }

            MessageBox.Show("用户名或密码错误！");
            Debug.WriteLine("密码错误 " + (string)dr["Upsd"] + " " + password);
            return "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = tbxAccount.Text;
            string password = tbxPassword.Text;
            if (account == "" || password == "")
                return;
            state = check(account, password);
            if (state != "")
            {
                id = tbxAccount.Text;
                this.DialogResult = DialogResult.OK;
            }
         
        }


        private void lblSignUp_MouseHover(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.DarkBlue;
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.Black;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm suf = new SignUpForm();
            suf.ShowDialog();
            if (suf.DialogResult == DialogResult.OK)
            {
                SqlHelper.SqlInsert("Users", new object[] { suf.Uid, suf.Uname, suf.Upsd, "普通用户" });
                SqlHelper.SqlInsert("US", new object[] { suf.Uid, suf.Sid });
            }
            
        }
    }
}
