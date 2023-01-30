namespace YT.Suofeiya.UI
{
    partial class FormToolChange
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
            this.okBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbProcedureNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbToolNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbToolName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbOperatorName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbRemarks = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.clearCb = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.clearCb);
            this.kryptonPanel1.Controls.Add(this.tbRemarks);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.tbOperatorName);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.tbID);
            this.kryptonPanel1.Controls.Add(this.tbProcedureNo);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.tbToolNo);
            this.kryptonPanel1.Controls.Add(this.tbToolName);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.cancelBtn);
            this.kryptonPanel1.Controls.Add(this.okBtn);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(415, 413);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(190, 376);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 25);
            this.okBtn.TabIndex = 0;
            this.okBtn.Values.Text = "确定";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(303, 376);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 25);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Values.Text = "取消";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(44, 30);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(22, 20);
            this.kryptonLabel4.TabIndex = 40;
            this.kryptonLabel4.Values.Text = "ID";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(44, 73);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel2.TabIndex = 32;
            this.kryptonLabel2.Values.Text = "采集点";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(156, 30);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(178, 23);
            this.tbID.TabIndex = 39;
            // 
            // tbProcedureNo
            // 
            this.tbProcedureNo.Location = new System.Drawing.Point(156, 73);
            this.tbProcedureNo.Name = "tbProcedureNo";
            this.tbProcedureNo.ReadOnly = true;
            this.tbProcedureNo.Size = new System.Drawing.Size(178, 23);
            this.tbProcedureNo.TabIndex = 31;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(44, 159);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel3.TabIndex = 36;
            this.kryptonLabel3.Values.Text = "名称";
            // 
            // tbToolNo
            // 
            this.tbToolNo.Location = new System.Drawing.Point(156, 116);
            this.tbToolNo.Name = "tbToolNo";
            this.tbToolNo.ReadOnly = true;
            this.tbToolNo.Size = new System.Drawing.Size(178, 23);
            this.tbToolNo.TabIndex = 33;
            // 
            // tbToolName
            // 
            this.tbToolName.Location = new System.Drawing.Point(156, 159);
            this.tbToolName.Name = "tbToolName";
            this.tbToolName.ReadOnly = true;
            this.tbToolName.Size = new System.Drawing.Size(178, 23);
            this.tbToolName.TabIndex = 35;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(44, 116);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel5.TabIndex = 34;
            this.kryptonLabel5.Values.Text = "序号";
            // 
            // tbOperatorName
            // 
            this.tbOperatorName.Location = new System.Drawing.Point(156, 212);
            this.tbOperatorName.Name = "tbOperatorName";
            this.tbOperatorName.Size = new System.Drawing.Size(178, 23);
            this.tbOperatorName.TabIndex = 41;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(44, 212);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel1.TabIndex = 42;
            this.kryptonLabel1.Values.Text = "操作人员";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(44, 267);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel6.TabIndex = 43;
            this.kryptonLabel6.Values.Text = "备注";
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(156, 264);
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(178, 83);
            this.tbRemarks.TabIndex = 44;
            // 
            // clearCb
            // 
            this.clearCb.Location = new System.Drawing.Point(44, 376);
            this.clearCb.Name = "clearCb";
            this.clearCb.Size = new System.Drawing.Size(101, 20);
            this.clearCb.TabIndex = 45;
            this.clearCb.Values.Text = "清除使用次数";
            // 
            // FormToolChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 413);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FormToolChange";
            this.Text = "维修记录";
            this.Load += new System.EventHandler(this.FormToolChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton okBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox clearCb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbRemarks;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbOperatorName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbProcedureNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbToolNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbToolName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
    }
}