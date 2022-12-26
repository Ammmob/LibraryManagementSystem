namespace LibraryManagementSystem
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUname = new System.Windows.Forms.Label();
            this.tbxUname = new System.Windows.Forms.TextBox();
            this.tbxSid = new System.Windows.Forms.TextBox();
            this.lblSid = new System.Windows.Forms.Label();
            this.tbxUpsd = new System.Windows.Forms.TextBox();
            this.lblUpsd = new System.Windows.Forms.Label();
            this.tbxUpsdc = new System.Windows.Forms.TextBox();
            this.lblUpsdc = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUname
            // 
            this.lblUname.Location = new System.Drawing.Point(123, 94);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(74, 28);
            this.lblUname.TabIndex = 0;
            this.lblUname.Text = "用户名";
            this.lblUname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxUname
            // 
            this.tbxUname.Location = new System.Drawing.Point(203, 94);
            this.tbxUname.Multiline = true;
            this.tbxUname.Name = "tbxUname";
            this.tbxUname.Size = new System.Drawing.Size(185, 28);
            this.tbxUname.TabIndex = 1;
            this.tbxUname.WordWrap = false;
            this.tbxUname.TextChanged += new System.EventHandler(this.tbxUname_TextChanged);
            // 
            // tbxSid
            // 
            this.tbxSid.Location = new System.Drawing.Point(203, 152);
            this.tbxSid.Multiline = true;
            this.tbxSid.Name = "tbxSid";
            this.tbxSid.Size = new System.Drawing.Size(185, 28);
            this.tbxSid.TabIndex = 3;
            this.tbxSid.WordWrap = false;
            this.tbxSid.TextChanged += new System.EventHandler(this.tbxSid_TextChanged);
            // 
            // lblSid
            // 
            this.lblSid.Location = new System.Drawing.Point(123, 152);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(74, 28);
            this.lblSid.TabIndex = 2;
            this.lblSid.Text = "学号";
            this.lblSid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxUpsd
            // 
            this.tbxUpsd.Location = new System.Drawing.Point(203, 214);
            this.tbxUpsd.Multiline = true;
            this.tbxUpsd.Name = "tbxUpsd";
            this.tbxUpsd.PasswordChar = '●';
            this.tbxUpsd.Size = new System.Drawing.Size(185, 28);
            this.tbxUpsd.TabIndex = 5;
            this.tbxUpsd.WordWrap = false;
            this.tbxUpsd.TextChanged += new System.EventHandler(this.tbxUpsd_TextChanged);
            // 
            // lblUpsd
            // 
            this.lblUpsd.Location = new System.Drawing.Point(123, 214);
            this.lblUpsd.Name = "lblUpsd";
            this.lblUpsd.Size = new System.Drawing.Size(74, 28);
            this.lblUpsd.TabIndex = 4;
            this.lblUpsd.Text = "密码";
            this.lblUpsd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxUpsdc
            // 
            this.tbxUpsdc.Location = new System.Drawing.Point(203, 281);
            this.tbxUpsdc.Multiline = true;
            this.tbxUpsdc.Name = "tbxUpsdc";
            this.tbxUpsdc.PasswordChar = '●';
            this.tbxUpsdc.Size = new System.Drawing.Size(185, 28);
            this.tbxUpsdc.TabIndex = 7;
            this.tbxUpsdc.WordWrap = false;
            this.tbxUpsdc.TextChanged += new System.EventHandler(this.tbxUpsdc_TextChanged);
            // 
            // lblUpsdc
            // 
            this.lblUpsdc.Location = new System.Drawing.Point(123, 281);
            this.lblUpsdc.Name = "lblUpsdc";
            this.lblUpsdc.Size = new System.Drawing.Size(90, 28);
            this.lblUpsdc.TabIndex = 6;
            this.lblUpsdc.Text = "确认密码";
            this.lblUpsdc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(126, 335);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(112, 46);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "注册";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(276, 335);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 46);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 478);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.tbxUpsdc);
            this.Controls.Add(this.lblUpsdc);
            this.Controls.Add(this.tbxUpsd);
            this.Controls.Add(this.lblUpsd);
            this.Controls.Add(this.tbxSid);
            this.Controls.Add(this.lblSid);
            this.Controls.Add(this.tbxUname);
            this.Controls.Add(this.lblUname);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.TextBox tbxUname;
        private System.Windows.Forms.TextBox tbxSid;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.TextBox tbxUpsd;
        private System.Windows.Forms.Label lblUpsd;
        private System.Windows.Forms.TextBox tbxUpsdc;
        private System.Windows.Forms.Label lblUpsdc;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnReturn;
    }
}