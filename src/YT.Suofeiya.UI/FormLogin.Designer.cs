namespace YT.Suofeiya.UI
{
    partial class FormLogin
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserTb = new System.Windows.Forms.TextBox();
            this.pwdTb = new System.Windows.Forms.TextBox();
            this.cancelBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.okBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.UserTb);
            this.kryptonPanel1.Controls.Add(this.pwdTb);
            this.kryptonPanel1.Controls.Add(this.cancelBtn);
            this.kryptonPanel1.Controls.Add(this.okBtn);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(427, 245);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(51, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "账号";
            // 
            // UserTb
            // 
            this.UserTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserTb.Location = new System.Drawing.Point(185, 47);
            this.UserTb.Name = "UserTb";
            this.UserTb.Size = new System.Drawing.Size(147, 26);
            this.UserTb.TabIndex = 6;
            this.UserTb.Text = "admin";
            // 
            // pwdTb
            // 
            this.pwdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwdTb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdTb.Location = new System.Drawing.Point(185, 101);
            this.pwdTb.Name = "pwdTb";
            this.pwdTb.PasswordChar = '●';
            this.pwdTb.Size = new System.Drawing.Size(147, 26);
            this.pwdTb.TabIndex = 5;
            this.pwdTb.Text = "123qwe";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(303, 172);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 45);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Values.Text = "取消";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(163, 172);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(104, 45);
            this.okBtn.TabIndex = 1;
            this.okBtn.Values.Text = "确认";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(106, 143);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(226, 23);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "用户名或密码错误，请核实！";
            this.kryptonLabel1.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 245);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户登陆";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton okBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserTb;
        private System.Windows.Forms.TextBox pwdTb;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}