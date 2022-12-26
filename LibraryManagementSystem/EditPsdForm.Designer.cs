namespace LibraryManagementSystem
{
    partial class EditPsdForm
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
            this.tbxOld = new System.Windows.Forms.TextBox();
            this.tbxNew = new System.Windows.Forms.TextBox();
            this.lblHintOld = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(103, 253);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 33);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxOld
            // 
            this.tbxOld.Location = new System.Drawing.Point(107, 92);
            this.tbxOld.Name = "tbxOld";
            this.tbxOld.PasswordChar = '●';
            this.tbxOld.Size = new System.Drawing.Size(204, 28);
            this.tbxOld.TabIndex = 2;
            // 
            // tbxNew
            // 
            this.tbxNew.Location = new System.Drawing.Point(103, 183);
            this.tbxNew.Name = "tbxNew";
            this.tbxNew.PasswordChar = '●';
            this.tbxNew.Size = new System.Drawing.Size(204, 28);
            this.tbxNew.TabIndex = 3;
            // 
            // lblHintOld
            // 
            this.lblHintOld.AutoSize = true;
            this.lblHintOld.Location = new System.Drawing.Point(104, 53);
            this.lblHintOld.Name = "lblHintOld";
            this.lblHintOld.Size = new System.Drawing.Size(152, 18);
            this.lblHintOld.TabIndex = 4;
            this.lblHintOld.Text = "请输入原始密码：";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(104, 147);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(134, 18);
            this.lblNew.TabIndex = 5;
            this.lblNew.Text = "请输入新密码：";
            // 
            // EditPsdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 354);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblHintOld);
            this.Controls.Add(this.tbxNew);
            this.Controls.Add(this.tbxOld);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "EditPsdForm";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxOld;
        private System.Windows.Forms.TextBox tbxNew;
        private System.Windows.Forms.Label lblHintOld;
        private System.Windows.Forms.Label lblNew;
    }
}