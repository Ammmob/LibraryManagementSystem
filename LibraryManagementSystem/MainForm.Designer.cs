namespace LibraryManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbpAccount = new System.Windows.Forms.TabPage();
            this.btnEditHead = new System.Windows.Forms.Button();
            this.btnReturnInfo = new System.Windows.Forms.Button();
            this.btnStateChange = new System.Windows.Forms.Button();
            this.btnUsersManage = new System.Windows.Forms.Button();
            this.btnBorrowRecord = new System.Windows.Forms.Button();
            this.btnEditPsd = new System.Windows.Forms.Button();
            this.btnEditName = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.pbxHead = new System.Windows.Forms.PictureBox();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbpBorrow = new System.Windows.Forms.TabPage();
            this.pbxBook = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxBid = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.tbpQuerry = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.tbpMain = new System.Windows.Forms.TabPage();
            this.btnReflash = new System.Windows.Forms.Button();
            this.lblWeather = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHead)).BeginInit();
            this.tbpBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBook)).BeginInit();
            this.tbpQuerry.SuspendLayout();
            this.tbpMain.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpAccount
            // 
            this.tbpAccount.Controls.Add(this.btnEditHead);
            this.tbpAccount.Controls.Add(this.btnReturnInfo);
            this.tbpAccount.Controls.Add(this.btnStateChange);
            this.tbpAccount.Controls.Add(this.btnUsersManage);
            this.tbpAccount.Controls.Add(this.btnBorrowRecord);
            this.tbpAccount.Controls.Add(this.btnEditPsd);
            this.tbpAccount.Controls.Add(this.btnEditName);
            this.tbpAccount.Controls.Add(this.tbxName);
            this.tbpAccount.Controls.Add(this.pbxHead);
            this.tbpAccount.Controls.Add(this.lblIdentity);
            this.tbpAccount.Controls.Add(this.lblAccount);
            this.tbpAccount.Controls.Add(this.lblName);
            this.tbpAccount.Location = new System.Drawing.Point(4, 28);
            this.tbpAccount.Name = "tbpAccount";
            this.tbpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAccount.Size = new System.Drawing.Size(1153, 586);
            this.tbpAccount.TabIndex = 3;
            this.tbpAccount.Text = "账户管理";
            this.tbpAccount.UseVisualStyleBackColor = true;
            this.tbpAccount.Enter += new System.EventHandler(this.tbpAccount_Enter);
            // 
            // btnEditHead
            // 
            this.btnEditHead.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditHead.Location = new System.Drawing.Point(329, 233);
            this.btnEditHead.Name = "btnEditHead";
            this.btnEditHead.Size = new System.Drawing.Size(143, 42);
            this.btnEditHead.TabIndex = 11;
            this.btnEditHead.Text = "修改头像";
            this.btnEditHead.UseVisualStyleBackColor = true;
            this.btnEditHead.Click += new System.EventHandler(this.btnEditHead_Click);
            // 
            // btnReturnInfo
            // 
            this.btnReturnInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturnInfo.Location = new System.Drawing.Point(28, 17);
            this.btnReturnInfo.Name = "btnReturnInfo";
            this.btnReturnInfo.Size = new System.Drawing.Size(88, 44);
            this.btnReturnInfo.TabIndex = 10;
            this.btnReturnInfo.Text = "返回";
            this.btnReturnInfo.UseVisualStyleBackColor = true;
            this.btnReturnInfo.Click += new System.EventHandler(this.btnReturnInfo_Click);
            // 
            // btnStateChange
            // 
            this.btnStateChange.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStateChange.Location = new System.Drawing.Point(768, 76);
            this.btnStateChange.Name = "btnStateChange";
            this.btnStateChange.Size = new System.Drawing.Size(170, 58);
            this.btnStateChange.TabIndex = 9;
            this.btnStateChange.Text = "修改权限";
            this.btnStateChange.UseVisualStyleBackColor = true;
            this.btnStateChange.Click += new System.EventHandler(this.btnStateChange_Click);
            // 
            // btnUsersManage
            // 
            this.btnUsersManage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUsersManage.Location = new System.Drawing.Point(768, 173);
            this.btnUsersManage.Name = "btnUsersManage";
            this.btnUsersManage.Size = new System.Drawing.Size(170, 58);
            this.btnUsersManage.TabIndex = 8;
            this.btnUsersManage.Text = "账户信息";
            this.btnUsersManage.UseVisualStyleBackColor = true;
            this.btnUsersManage.Click += new System.EventHandler(this.btnUsersManage_Click);
            // 
            // btnBorrowRecord
            // 
            this.btnBorrowRecord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBorrowRecord.Location = new System.Drawing.Point(571, 173);
            this.btnBorrowRecord.Name = "btnBorrowRecord";
            this.btnBorrowRecord.Size = new System.Drawing.Size(170, 58);
            this.btnBorrowRecord.TabIndex = 7;
            this.btnBorrowRecord.Text = "借书记录";
            this.btnBorrowRecord.UseVisualStyleBackColor = true;
            this.btnBorrowRecord.Click += new System.EventHandler(this.btnBorrowRecord_Click);
            // 
            // btnEditPsd
            // 
            this.btnEditPsd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditPsd.Location = new System.Drawing.Point(571, 76);
            this.btnEditPsd.Name = "btnEditPsd";
            this.btnEditPsd.Size = new System.Drawing.Size(170, 58);
            this.btnEditPsd.TabIndex = 6;
            this.btnEditPsd.Text = "修改密码";
            this.btnEditPsd.UseVisualStyleBackColor = true;
            this.btnEditPsd.Click += new System.EventHandler(this.btnEditPsd_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditName.BackgroundImage")));
            this.btnEditName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditName.Location = new System.Drawing.Point(499, 173);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(39, 39);
            this.btnEditName.TabIndex = 5;
            this.btnEditName.UseVisualStyleBackColor = true;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxName.Location = new System.Drawing.Point(345, 173);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(148, 35);
            this.tbxName.TabIndex = 4;
            this.tbxName.WordWrap = false;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxName_KeyDown);
            // 
            // pbxHead
            // 
            this.pbxHead.Location = new System.Drawing.Point(93, 67);
            this.pbxHead.Name = "pbxHead";
            this.pbxHead.Size = new System.Drawing.Size(169, 208);
            this.pbxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHead.TabIndex = 0;
            this.pbxHead.TabStop = false;
            this.pbxHead.Click += new System.EventHandler(this.pbxHead_Click);
            // 
            // lblIdentity
            // 
            this.lblIdentity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIdentity.Location = new System.Drawing.Point(283, 125);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(201, 39);
            this.lblIdentity.TabIndex = 3;
            this.lblIdentity.Text = "身份：";
            this.lblIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccount.Location = new System.Drawing.Point(283, 76);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(201, 39);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "账户：";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(283, 173);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(201, 39);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "昵称：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbpBorrow
            // 
            this.tbpBorrow.Controls.Add(this.pbxBook);
            this.tbpBorrow.Controls.Add(this.btnReturn);
            this.tbpBorrow.Controls.Add(this.btnBorrow);
            this.tbpBorrow.Controls.Add(this.lblInfo);
            this.tbpBorrow.Controls.Add(this.btnFind);
            this.tbpBorrow.Controls.Add(this.tbxBid);
            this.tbpBorrow.Controls.Add(this.lblHint);
            this.tbpBorrow.Location = new System.Drawing.Point(4, 28);
            this.tbpBorrow.Name = "tbpBorrow";
            this.tbpBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBorrow.Size = new System.Drawing.Size(1153, 586);
            this.tbpBorrow.TabIndex = 2;
            this.tbpBorrow.Text = "图书借还";
            this.tbpBorrow.UseVisualStyleBackColor = true;
            // 
            // pbxBook
            // 
            this.pbxBook.Location = new System.Drawing.Point(236, 140);
            this.pbxBook.Name = "pbxBook";
            this.pbxBook.Size = new System.Drawing.Size(251, 369);
            this.pbxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBook.TabIndex = 6;
            this.pbxBook.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("宋体", 10F);
            this.btnReturn.Location = new System.Drawing.Point(704, 513);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 39);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "归还";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("宋体", 10F);
            this.btnBorrow.Location = new System.Drawing.Point(573, 513);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(90, 39);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "借阅";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.Location = new System.Drawing.Point(510, 186);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(352, 280);
            this.lblInfo.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.Location = new System.Drawing.Point(669, 64);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(143, 38);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxBid
            // 
            this.tbxBid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxBid.Location = new System.Drawing.Point(388, 64);
            this.tbxBid.Multiline = true;
            this.tbxBid.Name = "tbxBid";
            this.tbxBid.Size = new System.Drawing.Size(251, 38);
            this.tbxBid.TabIndex = 1;
            this.tbxBid.WordWrap = false;
            this.tbxBid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxBid_KeyDown);
            // 
            // lblHint
            // 
            this.lblHint.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHint.Location = new System.Drawing.Point(236, 64);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(146, 38);
            this.lblHint.TabIndex = 0;
            this.lblHint.Text = "请输入书号";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpQuerry
            // 
            this.tbpQuerry.Controls.Add(this.btnSave);
            this.tbpQuerry.Controls.Add(this.btnSearch);
            this.tbpQuerry.Controls.Add(this.cbxSearch);
            this.tbpQuerry.Controls.Add(this.tbxSearch);
            this.tbpQuerry.Location = new System.Drawing.Point(4, 28);
            this.tbpQuerry.Name = "tbpQuerry";
            this.tbpQuerry.Padding = new System.Windows.Forms.Padding(3);
            this.tbpQuerry.Size = new System.Drawing.Size(1153, 586);
            this.tbpQuerry.TabIndex = 1;
            this.tbpQuerry.Text = "图书查询";
            this.tbpQuerry.Enter += new System.EventHandler(this.tbpQuerry_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSave.Location = new System.Drawing.Point(873, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSearch.Location = new System.Drawing.Point(743, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 43);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxSearch
            // 
            this.cbxSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Items.AddRange(new object[] {
            "按照书名查找",
            "按照类别查找",
            "按照书号查找",
            "按照作者查找"});
            this.cbxSearch.Location = new System.Drawing.Point(126, 69);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(186, 32);
            this.cbxSearch.TabIndex = 2;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.tbxSearch.Location = new System.Drawing.Point(334, 63);
            this.tbxSearch.Multiline = true;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(376, 38);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.WordWrap = false;
            this.tbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyDown);
            // 
            // tbpMain
            // 
            this.tbpMain.Controls.Add(this.btnReflash);
            this.tbpMain.Controls.Add(this.lblWeather);
            this.tbpMain.Controls.Add(this.tbxCity);
            this.tbpMain.Controls.Add(this.lblCity);
            this.tbpMain.Controls.Add(this.lblTitle);
            this.tbpMain.Location = new System.Drawing.Point(4, 28);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMain.Size = new System.Drawing.Size(1153, 586);
            this.tbpMain.TabIndex = 0;
            this.tbpMain.Text = "主界面";
            this.tbpMain.UseVisualStyleBackColor = true;
            // 
            // btnReflash
            // 
            this.btnReflash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReflash.BackgroundImage")));
            this.btnReflash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReflash.Location = new System.Drawing.Point(901, 174);
            this.btnReflash.Name = "btnReflash";
            this.btnReflash.Size = new System.Drawing.Size(36, 35);
            this.btnReflash.TabIndex = 4;
            this.btnReflash.UseVisualStyleBackColor = true;
            this.btnReflash.Click += new System.EventHandler(this.btnReflash_Click);
            // 
            // lblWeather
            // 
            this.lblWeather.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWeather.Location = new System.Drawing.Point(734, 226);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(222, 148);
            this.lblWeather.TabIndex = 3;
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxCity.Location = new System.Drawing.Point(819, 174);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(76, 35);
            this.tbxCity.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCity.Location = new System.Drawing.Point(706, 178);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(130, 24);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "所在城市：";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("华文彩云", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(166, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(824, 74);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "欢迎登录图书管理系统！";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbpMain);
            this.tbControl.Controls.Add(this.tbpQuerry);
            this.tbControl.Controls.Add(this.tbpBorrow);
            this.tbControl.Controls.Add(this.tbpAccount);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(0, 0);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(1161, 618);
            this.tbControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 618);
            this.Controls.Add(this.tbControl);
            this.Name = "MainForm";
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tbpAccount.ResumeLayout(false);
            this.tbpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHead)).EndInit();
            this.tbpBorrow.ResumeLayout(false);
            this.tbpBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBook)).EndInit();
            this.tbpQuerry.ResumeLayout(false);
            this.tbpQuerry.PerformLayout();
            this.tbpMain.ResumeLayout(false);
            this.tbpMain.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpAccount;
        private System.Windows.Forms.TabPage tbpBorrow;
        private System.Windows.Forms.TabPage tbpQuerry;
        private System.Windows.Forms.TabPage tbpMain;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxBid;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pbxBook;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.PictureBox pbxHead;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnEditPsd;
        private System.Windows.Forms.Button btnStateChange;
        private System.Windows.Forms.Button btnUsersManage;
        private System.Windows.Forms.Button btnBorrowRecord;
        private System.Windows.Forms.Button btnReturnInfo;
        private System.Windows.Forms.Button btnEditHead;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReflash;
        private System.Windows.Forms.Label lblWeather;
    }
}

