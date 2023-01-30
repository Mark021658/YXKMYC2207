
namespace YT.Suofeiya.UI.Page
{
    partial class PageAlarmManage
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
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pointId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquisitionPointNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaultNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kcb_pointNo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton_save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktb_name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_alarmType = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_faultNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktb_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcb_pointNo)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pointId,
            this.AcquisitionPointNo,
            this.FaultNo,
            this.AlarmType,
            this.AName});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(2, 2);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowTemplate.Height = 23;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(603, 580);
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_RowEnter);
            // 
            // pointId
            // 
            this.pointId.DataPropertyName = "Id";
            this.pointId.HeaderText = "ID";
            this.pointId.Name = "pointId";
            this.pointId.ReadOnly = true;
            this.pointId.Width = 50;
            // 
            // AcquisitionPointNo
            // 
            this.AcquisitionPointNo.DataPropertyName = "AcquisitionPointNo";
            this.AcquisitionPointNo.HeaderText = "采集点编号";
            this.AcquisitionPointNo.Name = "AcquisitionPointNo";
            this.AcquisitionPointNo.ReadOnly = true;
            // 
            // FaultNo
            // 
            this.FaultNo.DataPropertyName = "FaultNo";
            this.FaultNo.HeaderText = "预警编号";
            this.FaultNo.Name = "FaultNo";
            this.FaultNo.ReadOnly = true;
            // 
            // AlarmType
            // 
            this.AlarmType.DataPropertyName = "AlarmType";
            this.AlarmType.HeaderText = "预警类型";
            this.AlarmType.Name = "AlarmType";
            this.AlarmType.ReadOnly = true;
            // 
            // AName
            // 
            this.AName.DataPropertyName = "Name";
            this.AName.HeaderText = "名称";
            this.AName.Name = "AName";
            this.AName.ReadOnly = true;
            this.AName.Width = 200;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.AutoSize = true;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonDataGridView1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(608, 616);
            this.kryptonHeaderGroup1.TabIndex = 1;
            this.kryptonHeaderGroup1.ToolTipValues.Heading = "列表";
            this.kryptonHeaderGroup1.ToolTipValues.Image = null;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "列表";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::YT.Suofeiya.UI.Properties.Resources.详细分类;
            this.kryptonHeaderGroup1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonHeaderGroup1_Paint);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(612, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kcb_pointNo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonRefresh);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kButton_save);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_name);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_alarmType);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_faultNo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_ID);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(318, 618);
            this.kryptonHeaderGroup2.TabIndex = 2;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "编辑";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::YT.Suofeiya.UI.Properties.Resources.编辑;
            // 
            // kcb_pointNo
            // 
            this.kcb_pointNo.DropDownWidth = 170;
            this.kcb_pointNo.IntegralHeight = false;
            this.kcb_pointNo.Location = new System.Drawing.Point(107, 49);
            this.kcb_pointNo.Name = "kcb_pointNo";
            this.kcb_pointNo.Size = new System.Drawing.Size(170, 21);
            this.kcb_pointNo.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcb_pointNo.TabIndex = 14;
            // 
            // kryptonRefresh
            // 
            this.kryptonRefresh.Location = new System.Drawing.Point(159, 227);
            this.kryptonRefresh.Name = "kryptonRefresh";
            this.kryptonRefresh.Size = new System.Drawing.Size(118, 40);
            this.kryptonRefresh.TabIndex = 13;
            this.kryptonRefresh.Values.Text = "刷新";
            this.kryptonRefresh.Click += new System.EventHandler(this.kryptonRefresh_Click);
            // 
            // kButton_save
            // 
            this.kButton_save.Location = new System.Drawing.Point(22, 227);
            this.kButton_save.Name = "kButton_save";
            this.kButton_save.Size = new System.Drawing.Size(118, 40);
            this.kButton_save.TabIndex = 12;
            this.kButton_save.Values.Text = "保存";
            this.kButton_save.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ktb_name
            // 
            this.ktb_name.Location = new System.Drawing.Point(107, 125);
            this.ktb_name.Name = "ktb_name";
            this.ktb_name.Size = new System.Drawing.Size(170, 23);
            this.ktb_name.TabIndex = 10;
            // 
            // ktb_alarmType
            // 
            this.ktb_alarmType.Location = new System.Drawing.Point(107, 99);
            this.ktb_alarmType.Name = "ktb_alarmType";
            this.ktb_alarmType.Size = new System.Drawing.Size(170, 23);
            this.ktb_alarmType.TabIndex = 9;
            // 
            // ktb_faultNo
            // 
            this.ktb_faultNo.Location = new System.Drawing.Point(107, 73);
            this.ktb_faultNo.Name = "ktb_faultNo";
            this.ktb_faultNo.Size = new System.Drawing.Size(170, 23);
            this.ktb_faultNo.TabIndex = 8;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(22, 128);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel5.TabIndex = 6;
            this.kryptonLabel5.Values.Text = "名称";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(22, 102);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "预警类型";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(22, 76);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "预警编号";
            // 
            // ktb_ID
            // 
            this.ktb_ID.Location = new System.Drawing.Point(107, 20);
            this.ktb_ID.Name = "ktb_ID";
            this.ktb_ID.ReadOnly = true;
            this.ktb_ID.Size = new System.Drawing.Size(170, 23);
            this.ktb_ID.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(22, 23);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(22, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "ID";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(22, 50);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "采集点编号";
            this.kryptonLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // PageAlarmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "PageAlarmManage";
            this.Size = new System.Drawing.Size(1024, 618);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcb_pointNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton_save;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_alarmType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_faultNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquisitionPointNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaultNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcb_pointNo;
    }
}
