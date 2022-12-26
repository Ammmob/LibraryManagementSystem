namespace LibraryManagementSystem
{
    partial class StateChangeForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUid = new System.Windows.Forms.Label();
            this.tbxUid = new System.Windows.Forms.TextBox();
            this.lblSet = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(90, 286);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(79, 41);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 41);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUid
            // 
            this.lblUid.Location = new System.Drawing.Point(87, 94);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(62, 36);
            this.lblUid.TabIndex = 2;
            this.lblUid.Text = "账号";
            this.lblUid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxUid
            // 
            this.tbxUid.Location = new System.Drawing.Point(159, 100);
            this.tbxUid.Name = "tbxUid";
            this.tbxUid.Size = new System.Drawing.Size(133, 28);
            this.tbxUid.TabIndex = 3;
            // 
            // lblSet
            // 
            this.lblSet.Location = new System.Drawing.Point(87, 190);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(62, 39);
            this.lblSet.TabIndex = 4;
            this.lblSet.Text = "设置为";
            this.lblSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxState
            // 
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "普通用户",
            "管理员",
            "拉黑用户"});
            this.cbxState.Location = new System.Drawing.Point(155, 197);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(137, 26);
            this.cbxState.TabIndex = 5;
            // 
            // StateChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 436);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.tbxUid);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "StateChangeForm";
            this.Text = "修改权限";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.TextBox tbxUid;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.ComboBox cbxState;
    }
}