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
    public partial class EditPsdForm : Form
    {
        public static string password;
        public EditPsdForm(string password)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            EditPsdForm.password = password;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbxOld.Text == password)
            {
                password = tbxNew.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("原始密码输入错误！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
