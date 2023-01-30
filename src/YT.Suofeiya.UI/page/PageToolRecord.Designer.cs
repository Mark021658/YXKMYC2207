namespace YT.Suofeiya.UI.Page
{
    partial class PageToolRecord
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.dgvToolRecord = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonHeaderGroup5 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.butQuery = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDateTimePicker2 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbProcessName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToolRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup5.Panel)).BeginInit();
            this.kryptonHeaderGroup5.Panel.SuspendLayout();
            this.kryptonHeaderGroup5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProcessName)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecHeaderGroup1});
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.dgvToolRecord);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(551, 449);
            this.kryptonHeaderGroup1.TabIndex = 11;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "刀具更换记录";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::YT.Suofeiya.UI.Properties.Resources.详细分类;
            // 
            // buttonSpecHeaderGroup1
            // 
            this.buttonSpecHeaderGroup1.Image = global::YT.Suofeiya.UI.Properties.Resources.导出;
            this.buttonSpecHeaderGroup1.Text = "导出";
            this.buttonSpecHeaderGroup1.UniqueName = "5B9333C574E34B46CAA71306E47CFC45";
            // 
            // dgvToolRecord
            // 
            this.dgvToolRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvToolRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToolRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvToolRecord.MultiSelect = false;
            this.dgvToolRecord.Name = "dgvToolRecord";
            this.dgvToolRecord.ReadOnly = true;
            this.dgvToolRecord.RowTemplate.Height = 23;
            this.dgvToolRecord.Size = new System.Drawing.Size(549, 417);
            this.dgvToolRecord.TabIndex = 0;
            // 
            // kryptonHeaderGroup5
            // 
            this.kryptonHeaderGroup5.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonHeaderGroup5.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup5.Location = new System.Drawing.Point(551, 0);
            this.kryptonHeaderGroup5.Name = "kryptonHeaderGroup5";
            // 
            // kryptonHeaderGroup5.Panel
            // 
            this.kryptonHeaderGroup5.Panel.Controls.Add(this.butQuery);
            this.kryptonHeaderGroup5.Panel.Controls.Add(this.kryptonDateTimePicker2);
            this.kryptonHeaderGroup5.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonHeaderGroup5.Panel.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonHeaderGroup5.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonHeaderGroup5.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup5.Panel.Controls.Add(this.cbProcessName);
            this.kryptonHeaderGroup5.Size = new System.Drawing.Size(181, 449);
            this.kryptonHeaderGroup5.TabIndex = 10;
            this.kryptonHeaderGroup5.ValuesPrimary.Heading = "查询";
            this.kryptonHeaderGroup5.ValuesPrimary.Image = global::YT.Suofeiya.UI.Properties.Resources.查询;
            // 
            // butQuery
            // 
            this.butQuery.Location = new System.Drawing.Point(31, 310);
            this.butQuery.Name = "butQuery";
            this.butQuery.Size = new System.Drawing.Size(130, 25);
            this.butQuery.TabIndex = 19;
            this.butQuery.Values.Text = "查询";
            this.butQuery.Click += new System.EventHandler(this.butQuery_Click);
            // 
            // kryptonDateTimePicker2
            // 
            this.kryptonDateTimePicker2.CalendarTodayDate = new System.DateTime(2020, 10, 16, 0, 0, 0, 0);
            this.kryptonDateTimePicker2.Location = new System.Drawing.Point(31, 263);
            this.kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            this.kryptonDateTimePicker2.Size = new System.Drawing.Size(130, 21);
            this.kryptonDateTimePicker2.TabIndex = 18;
            this.kryptonDateTimePicker2.ValueNullable = new System.DateTime(2021, 5, 14, 0, 0, 0, 0);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(31, 217);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel3.TabIndex = 17;
            this.kryptonLabel3.Values.Text = "终止日期";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.CalendarTodayDate = new System.DateTime(2020, 10, 16, 0, 0, 0, 0);
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(31, 170);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(130, 21);
            this.kryptonDateTimePicker1.TabIndex = 16;
            this.kryptonDateTimePicker1.ValueNullable = new System.DateTime(2021, 5, 14, 0, 0, 0, 0);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(31, 124);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "开始日期";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(31, 31);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "设备名称";
            // 
            // cbProcessName
            // 
            this.cbProcessName.DropDownWidth = 121;
            this.cbProcessName.IntegralHeight = false;
            this.cbProcessName.Location = new System.Drawing.Point(31, 76);
            this.cbProcessName.Name = "cbProcessName";
            this.cbProcessName.Size = new System.Drawing.Size(130, 21);
            this.cbProcessName.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbProcessName.TabIndex = 12;
            this.cbProcessName.Text = "所有";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "AcquisitionPointNo";
            this.Column1.HeaderText = "设备号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ToolNo";
            this.Column2.HeaderText = "刀具号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ToolName";
            this.Column6.HeaderText = "刀具名";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ChangeTime";
            this.Column3.HeaderText = "更换时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Remarks";
            this.Column4.HeaderText = "备注";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OperaterName";
            this.Column5.HeaderText = "维护人员";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // PageToolRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.kryptonHeaderGroup5);
            this.Name = "PageToolRecord";
            this.Size = new System.Drawing.Size(732, 449);
            this.Load += new System.EventHandler(this.PageToolRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToolRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup5.Panel)).EndInit();
            this.kryptonHeaderGroup5.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup5.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup5)).EndInit();
            this.kryptonHeaderGroup5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbProcessName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvToolRecord;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbProcessName;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton butQuery;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
