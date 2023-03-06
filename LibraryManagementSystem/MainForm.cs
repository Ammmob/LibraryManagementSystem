using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{

    public partial class MainForm : Form
    {
        /*按照类别查找
        按照书号查找
        按照书名查找
        按照作者查找
        */
        private Dictionary<string, string> searchDict = new Dictionary<string, string> {
            {"按照书名查找","Bname"},{"按照书号查找","Bid" },{"按照作者查找","Bauthor" } ,{"按照类别查找","Btype" } };
    
        private Image headImage;
        private string state;
        private string uname;
        private string uid { get; }
        private string borrowBid;
        private string userCondition;
        private DataRow borrowDr;
        private DataRow userDr;
        private Table tableBooks;
        private Table tableBorrow;
        private Table tableUsers;
        public static List<string> booksColName { get; } = new List<string> { "Bid", "Bname", "Bauthor", "Bpbr", "Bnum", "Btype" };
        public static List<string> borrowColName { get; } = new List<string> { "Bid","Uid","Bdate","Ddate","Bstate"};
        public static List<string> usersColName { get; } = new List<string> { "Uid", "Uname", "Upsd", "Ustate" };
        private string city = "青岛";
        public MainForm(string uid,string state)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userCondition = SqlHelper.ConditionMake("Uid", uid);
            userDr = SqlHelper.SelectRows("Users", userCondition)[0];
            this.uid = uid;
            this.state = state;
            this.uname = (string)userDr["Uname"];

            //tbpMain
            tbxCity.Text = city;
            DisplayWeather();
            
           
            

            // tbpQuerry
            tableBooks = new Table(uid,"Books", this.state);
            tbpQuerry.Controls.Add(tableBooks);
            cbxSearch.SelectedIndex = 0;

            //tbpBorrow
            btnBorrow.Enabled = false;
            btnReturn.Enabled = false;

            // tbpAccount
            tableBorrow = new Table(uid, "Borrow", this.state);
            tableBorrow.Visible = false;
            tableUsers = new Table(uid, "Users", this.state);
            tableUsers.Visible = false;

            btnReturnInfo.Visible = false;
            tbpAccount.Controls.Add(tableBorrow);
            tbpAccount.Controls.Add(tableUsers);
            if (headImage == null)
            {
                try
                {
                    headImage = Image.FromFile("..\\..\\res\\users\\" + uid + ".jpg");

                }
                catch
                {
                    headImage = Image.FromFile("..\\..\\res\\0.jpg");
                }
            }
            pbxHead.Image = headImage;
            tbxName.Text = uname;
            tbxName.Hide();
            lblAccount.Text = "账号：" + uid;
            lblName.Text = "昵称：" + uname;
            lblIdentity.Text = "身份：" + state;


        }

        private void DisplayWeather()
        {
            if (tbxCity.Text == "")
            {
                return;
            }
            cn.com.webxml.www.WeatherWebService weather = new cn.com.webxml.www.WeatherWebService();
            city = tbxCity.Text;
            string[] s = new string[23];//准备一个数组存放结果
            s = weather.getWeatherbyCityName(city);
            lblWeather.Text = "";
            lblWeather.Text += s[0] + " " + s[1] + "\r\n";
            lblWeather.Text += s[5] + "\r\n";
            lblWeather.Text += s[6] + "\r\n";
            lblWeather.Text += s[7] + "\r\n";
        }

        public void SetInfoVisible(bool visible)
        {
            pbxHead.Visible = visible;
            lblAccount.Visible = visible;
            lblIdentity.Visible = visible;
            lblName.Visible = visible;
            btnEditPsd.Visible = visible;
            btnEditName.Visible = visible;
            btnEditHead.Visible = visible;
            btnBorrowRecord.Visible = visible;
            btnReturnInfo.Visible = !visible;
            if (state == "管理员")
            {
                btnUsersManage.Visible = visible;
                btnStateChange.Visible = visible;
            }
           
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (state != "管理员")
            {
                btnSave.Visible = false;
                btnUsersManage.Visible = false;
                btnStateChange.Visible = false;
            }
            
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (key == "")
            {
                tableBooks.Reset();
                return;
            }
            
            string method = cbxSearch.Text;
            string column = searchDict[method];
            
            
            string condition ="where " + column + " like '%";
            for(int i = 0; i < key.Length; i++)
            {
                condition += key[i] + "%";
            }
            condition += "'";
            Debug.WriteLine(condition);
            tableBooks.Select(condition);
            tableBooks.TableInit();

        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            tableBooks.Save();

        }

        private void tbxBid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void setBookInfo()
        {
            string info = "书名：" + borrowDr["Bname"] + "\r\n" +
               "作者：" + borrowDr["Bauthor"] + "\r\n" +
               "出版社：" + borrowDr["Bpbr"] + "\r\n" +
               "分类：" + borrowDr["Btype"] + "\r\n" +
               "库存数量：" + borrowDr["Bnum"];
            lblInfo.Text = info;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string bid = tbxBid.Text;
            if (bid == "")
            {
                return;
            }
            string condition = SqlHelper.ConditionMake("Bid", bid);
            DataRowCollection drc = SqlHelper.SelectRows("Books", condition);
            if (drc == null || drc.Count == 0)
            {
                MessageBox.Show("请输入正确的书号！");
                return;
            }

            btnBorrow.Enabled = true;
            btnReturn.Enabled = true;
            borrowDr = drc[0];
            borrowBid = (string)borrowDr["Bid"];
            setBookInfo();
            Image img;
    
            try
            {
                img = Image.FromFile("..\\..\\res\\books\\" + bid + ".jpg");

            }
            catch
            {
                img = Image.FromFile("..\\..\\res\\0.jpg");
            }

            pbxBook.Image = img;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(borrowDr["Bnum"]);
            string condition = SqlHelper.ConditionMake(new string[] { "Bid", "Uid" }, new string[] { borrowBid, uid });
            DataRowCollection drc = SqlHelper.SelectRows("Borrow", condition);
            if (state == "拉黑用户")
            {
                MessageBox.Show("由于用户存在借阅书籍逾期未还，暂时被管理员拉黑，在此期间您无法再次借阅书籍！");
                return;
            }
            if (drc != null && drc.Count > 0)
            {
                if (MessageBox.Show("您已借阅此书，是否续借5天？","续借确认",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRow dr = drc[0];
                    dr["Ddate"] = ((DateTime)dr["Ddate"]).AddDays(5);
                    SqlHelper.SqlModify("Borrow", borrowColName, dr.ItemArray, condition);
                    MessageBox.Show("续借成功！");
                }
            }
            else
            {
                if (num == 0)
                {
                    MessageBox.Show("此书库存不足！无法借阅。");
                }
                else if (MessageBox.Show("确认借阅该书") == DialogResult.OK)
                {
                    DateTime now = DateTime.Now;
                    DateTime deadline = now.AddDays(15);
                    object[] values = new object[5];
                    values[0] = borrowBid;
                    values[1] = uid;
                    values[2] = now.ToString();
                    values[3] = deadline.ToString();
                    values[4] = "未还";
                    borrowDr["Bnum"] = (int)borrowDr["Bnum"] - 1;
                    SqlHelper.SqlInsert("Borrow", values);
                    condition = SqlHelper.ConditionMake("Bid", borrowBid);
                    SqlHelper.SqlModify("Books", booksColName, borrowDr.ItemArray, condition);
                    setBookInfo();

                }
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string condition;
            DataRowCollection drc;
            DataRow dr;
            condition = SqlHelper.ConditionMake(new string[] {"Bid","Uid"}, new string[] {borrowBid , uid});
            drc = SqlHelper.SelectRows("Borrow",condition);
            if (drc == null || drc.Count == 0)
            {
                MessageBox.Show("您并未借阅过此书！");
                return;
            }
            dr = drc[0];
            if ((string)dr["Bstate"] == "已还")
            {
                MessageBox.Show("您已归还此书！");
                return;
            }
            
            SqlHelper.SqlDelete("Borrow",condition);

            condition = SqlHelper.ConditionMake("Bid",borrowBid);
            borrowDr["Bnum"] = (int)borrowDr["Bnum"] + 1;
            SqlHelper.SqlModify("Books", booksColName, borrowDr.ItemArray, condition);
            setBookInfo();
            MessageBox.Show("归还成功！");
        }

        private void tbpQuerry_Enter(object sender, EventArgs e)
        {
            tableBooks.Reset();
        }


        private void btnEditName_Click(object sender, EventArgs e)
        {
            tbxName.Show();
     
        }

        private void tbxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxName.Hide();
                string newname = tbxName.Text;
                if (newname == "")
                {
                    MessageBox.Show("昵称不能为空！");
                }
                else if (newname != uname)
                {
                    uname = newname;
                    userDr["Uname"] = uname;
                    lblName.Text = "昵称：" + uname;
                    SqlHelper.SqlModify("Users", usersColName, userDr.ItemArray, userCondition);
                }
            }
        }

        private void btnEditPsd_Click(object sender, EventArgs e)
        {
            string psd = (string)userDr["Upsd"];
            EditPsdForm epf = new EditPsdForm(psd);
            epf.ShowDialog();
            if (EditPsdForm.password != psd)
            {
                // check 密码只有数字字母
                userDr["Upsd"] = EditPsdForm.password;
                SqlHelper.SqlModify("Users", usersColName, userDr.ItemArray, userCondition);
                MessageBox.Show("修改密码成功！");
            }
        }

        private void btnStateChange_Click(object sender, EventArgs e)
        {
            StateChangeForm scf = new StateChangeForm(uid);
            scf.ShowDialog();
        }

        private void btnUsersManage_Click(object sender, EventArgs e)
        {
            SetInfoVisible(false);
            tableUsers.Visible = true;
        }

        private void btnBorrowRecord_Click(object sender, EventArgs e)
        {
            SetInfoVisible(false);
            
            tableBorrow.Visible = true;
        }

        private void btnReturnInfo_Click(object sender, EventArgs e)
        {
            SetInfoVisible(true);
            tableUsers.Visible = false;
            tableBorrow.Visible = false;
        }

        private void tbpAccount_Enter(object sender, EventArgs e)
        {
            tableBorrow.Reset();
            tableUsers.Reset();
        }

        private void btnEditHead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "所有图像文件|*.bmp;*.pcx;*.png;*.jpg;*.gif;" +
                "*.tif;*.ico;*.dxf;*.cgm;*.cdr;*.wmf;*.eps;*.emf|" +
                "位图(*.bmp;*.jpg;*.png;...)|*.bmp;*.pcx;*.png;*.jpg;*.gif;*.tif;*.ico|" +
                "矢量图(*.wmf;*.eps;*.emf;..)|*.dxf;*.cgm;*.cdr;*.wmf;*.eps;*.emf";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                pbxHead.Image = Image.FromFile(ofd.FileName);
            }
            
           
        }

        private void btnReflash_Click(object sender, EventArgs e)
        {
            DisplayWeather();
        }

        private void pbxHead_Click(object sender, EventArgs e)
        {
            btnEditHead.PerformClick();
        }
    }
}
