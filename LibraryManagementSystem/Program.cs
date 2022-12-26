using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm login = new LoginForm();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                MainForm mainForm = new MainForm(LoginForm.id, LoginForm.state);
                Application.Run(mainForm);
            }
            //MainForm mainForm = new MainForm("000000", "管理员");
            //Application.Run(mainForm);

        }


    }
}
