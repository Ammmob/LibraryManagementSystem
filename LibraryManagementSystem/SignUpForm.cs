using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private bool check()
        {
            string condition = SqlHelper.ConditionMake("Sid", Sid);
            if (Sid.Length!=11||!SqlHelper.Contain("Students", condition))
            {
                MessageBox.Show("学号不存在！");
                return false;
            }

            if(SqlHelper.Contain("US", condition))
            {
                MessageBox.Show("学号已注册");
                return false;
            }
            return true;
        }

        private string UidGenarate()
        {
            string id = "";
            Random rd = new Random();
            string condition = SqlHelper.ConditionMake("Uid", id);
            for(int i = 0; i < 6; i++)
            {
                id += rd.Next(10);
            }
            while (SqlHelper.Contain("Users",condition))
            {
                id = "";
                for (int i = 0; i < 6; i++)
                {
                    id += rd.Next(10);
                }
            }
            return id;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            if (Uname == "" || Sid == "" || Upsd == "" || Upsdc == "")
            {
                Debug.WriteLine("有内容未填！");
                return;
            }

            if (check())
            {
                if (Upsd == Upsdc)
                {
                    Uid = UidGenarate();
                    MessageBox.Show("注册成功！\r\n" +
                        "您的用户ID是:"+ Uid);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("两次密码不符！");
                }
            }
        }

        private void tbxUname_TextChanged(object sender, EventArgs e)
        {
            Uname = tbxUname.Text;
        }

        private void tbxSid_TextChanged(object sender, EventArgs e)
        {
            Sid = tbxSid.Text;
        }

        private void tbxUpsd_TextChanged(object sender, EventArgs e)
        {
            Upsd = tbxUpsd.Text;
        }

        private void tbxUpsdc_TextChanged(object sender, EventArgs e)
        {
            Upsdc = tbxUpsdc.Text;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        public string Uid { get; private set; } = "";
        public string Uname { get; private set; } = "";
        public string Sid { get; private set; } = "";
        public string Upsd { get; private set; } = "";
        public string Upsdc { get; private set; } = "";

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
