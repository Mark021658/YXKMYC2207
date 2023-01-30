
namespace YT.Suofeiya.UI.Page
{
    partial class PageAcquisitionPointManage
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
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton_save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktb_pointDesc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_pointType = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_pointIndex = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_pointName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktb_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktb_pointNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pointId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquisitionPointNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquisitionIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquisitionDeviceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcb_deviceNo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcb_deviceNo)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pointId,
            this.AcquisitionPointNo,
            this.PointName,
            this.AcquisitionIndex,
            this.AcquisitionDeviceNo,
            this.ProcedureType,
            this.PointDesc});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowTemplate.Height = 23;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(693, 580);
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_RowEnter);
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
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(699, 617);
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
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(703, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kcb_deviceNo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonRefresh);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kButton_save);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_pointDesc);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_pointType);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_pointIndex);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_pointName);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_ID);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_pointNo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup2.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonHeaderGroup2_Panel_Paint);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(318, 618);
            this.kryptonHeaderGroup2.TabIndex = 2;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "编辑";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::YT.Suofeiya.UI.Properties.Resources.编辑;
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
            // ktb_pointDesc
            // 
            this.ktb_pointDesc.Location = new System.Drawing.Point(107, 177);
            this.ktb_pointDesc.Name = "ktb_pointDesc";
            this.ktb_pointDesc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ktb_pointDesc.Size = new System.Drawing.Size(170, 23);
            this.ktb_pointDesc.TabIndex = 11;
            // 
            // ktb_pointType
            // 
            this.ktb_pointType.Location = new System.Drawing.Point(107, 151);
            this.ktb_pointType.Name = "ktb_pointType";
            this.ktb_pointType.Size = new System.Drawing.Size(170, 23);
            this.ktb_pointType.TabIndex = 10;
            // 
            // ktb_pointIndex
            // 
            this.ktb_pointIndex.Location = new System.Drawing.Point(107, 99);
            this.ktb_pointIndex.Name = "ktb_pointIndex";
            this.ktb_pointIndex.Size = new System.Drawing.Size(170, 23);
            this.ktb_pointIndex.TabIndex = 9;
            // 
            // ktb_pointName
            // 
            this.ktb_pointName.Location = new System.Drawing.Point(107, 73);
            this.ktb_pointName.Name = "ktb_pointName";
            this.ktb_pointName.Size = new System.Drawing.Size(170, 23);
            this.ktb_pointName.TabIndex = 8;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(22, 180);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel6.TabIndex = 7;
            this.kryptonLabel6.Values.Text = "描述";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(22, 154);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel5.TabIndex = 6;
            this.kryptonLabel5.Values.Text = "类型";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(22, 102);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "采集点顺序";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(22, 76);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "采集点名称";
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
            // ktb_pointNo
            // 
            this.ktb_pointNo.Location = new System.Drawing.Point(107, 47);
            this.ktb_pointNo.Name = "ktb_pointNo";
            this.ktb_pointNo.Size = new System.Drawing.Size(170, 23);
            this.ktb_pointNo.TabIndex = 1;
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
            // pointId
            // 
            this.pointId.DataPropertyName = "Id";
            this.pointId.HeaderText = "ID";
            this.pointId.Name = "pointId";
            this.pointId.Width = 50;
            // 
            // AcquisitionPointNo
            // 
            this.AcquisitionPointNo.DataPropertyName = "AcquisitionPointNo";
            this.AcquisitionPointNo.HeaderText = "采集点编号";
            this.AcquisitionPointNo.Name = "AcquisitionPointNo";
            this.AcquisitionPointNo.Width = 90;
            // 
            // PointName
            // 
            this.PointName.DataPropertyName = "PointName";
            this.PointName.HeaderText = "采集点名称";
            this.PointName.Name = "PointName";
            this.PointName.Width = 200;
            // 
            // AcquisitionIndex
            // 
            this.AcquisitionIndex.DataPropertyName = "AcquisitionIndex";
            this.AcquisitionIndex.HeaderText = "采集点顺序";
            this.AcquisitionIndex.Name = "AcquisitionIndex";
            this.AcquisitionIndex.Width = 90;
            // 
            // AcquisitionDeviceNo
            // 
            this.AcquisitionDeviceNo.DataPropertyName = "AcquisitionDeviceNo";
            this.AcquisitionDeviceNo.HeaderText = "设备编号";
            this.AcquisitionDeviceNo.Name = "AcquisitionDeviceNo";
            this.AcquisitionDeviceNo.Width = 60;
            // 
            // ProcedureType
            // 
            this.ProcedureType.DataPropertyName = "ProcedureType";
            this.ProcedureType.HeaderText = "类型";
            this.ProcedureType.Name = "ProcedureType";
            this.ProcedureType.Width = 60;
            // 
            // PointDesc
            // 
            this.PointDesc.DataPropertyName = "PointDesc";
            this.PointDesc.HeaderText = "描述";
            this.PointDesc.Name = "PointDesc";
            // 
            // kcb_deviceNo
            // 
            this.kcb_deviceNo.DropDownWidth = 170;
            this.kcb_deviceNo.IntegralHeight = false;
            this.kcb_deviceNo.Location = new System.Drawing.Point(107, 127);
            this.kcb_deviceNo.Name = "kcb_deviceNo";
            this.kcb_deviceNo.Size = new System.Drawing.Size(170, 21);
            this.kcb_deviceNo.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcb_deviceNo.TabIndex = 14;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(22, 128);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel7.TabIndex = 15;
            this.kryptonLabel7.Values.Text = "设备编号";
            // 
            // PageAcquisitionPointManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "PageAcquisitionPointManage";
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
            ((System.ComponentModel.ISupportInitialize)(this.kcb_deviceNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_pointNo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton_save;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_pointDesc;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_pointType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_pointIndex;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_pointName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquisitionPointNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquisitionIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquisitionDeviceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointDesc;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcb_deviceNo;
    }
}
