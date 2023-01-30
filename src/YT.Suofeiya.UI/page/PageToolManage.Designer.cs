
namespace YT.Suofeiya.UI.Page
{
    partial class PageToolManage
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
            this.ktb_presettingCount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcb_pointNo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton_save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktb_wornPartType = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_toolName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_toolNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktb_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktb_xAddr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_yAddr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_zAddr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pointId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquisitionPointNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WornPartType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresettingCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceX_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceY_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceZ_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ToolNo,
            this.ToolName,
            this.WornPartType,
            this.PresettingCount,
            this.DistanceX_Addr,
            this.DistanceY_Addr,
            this.DistanceZ_Addr});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowTemplate.Height = 23;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(908, 586);
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
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(914, 623);
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
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(918, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_zAddr);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_yAddr);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_xAddr);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel9);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel8);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_presettingCount);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kcb_pointNo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonRefresh);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kButton_save);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_wornPartType);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_toolName);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_toolNo);
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
            // ktb_presettingCount
            // 
            this.ktb_presettingCount.Location = new System.Drawing.Point(128, 151);
            this.ktb_presettingCount.Name = "ktb_presettingCount";
            this.ktb_presettingCount.Size = new System.Drawing.Size(170, 23);
            this.ktb_presettingCount.TabIndex = 16;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(22, 154);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(100, 20);
            this.kryptonLabel6.TabIndex = 15;
            this.kryptonLabel6.Values.Text = "维修时限(次/天)";
            // 
            // kcb_pointNo
            // 
            this.kcb_pointNo.DropDownWidth = 170;
            this.kcb_pointNo.IntegralHeight = false;
            this.kcb_pointNo.Location = new System.Drawing.Point(128, 49);
            this.kcb_pointNo.Name = "kcb_pointNo";
            this.kcb_pointNo.Size = new System.Drawing.Size(170, 21);
            this.kcb_pointNo.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcb_pointNo.TabIndex = 14;
            // 
            // kryptonRefresh
            // 
            this.kryptonRefresh.Location = new System.Drawing.Point(180, 345);
            this.kryptonRefresh.Name = "kryptonRefresh";
            this.kryptonRefresh.Size = new System.Drawing.Size(118, 40);
            this.kryptonRefresh.TabIndex = 13;
            this.kryptonRefresh.Values.Text = "刷新";
            this.kryptonRefresh.Click += new System.EventHandler(this.kryptonRefresh_Click);
            // 
            // kButton_save
            // 
            this.kButton_save.Location = new System.Drawing.Point(22, 345);
            this.kButton_save.Name = "kButton_save";
            this.kButton_save.Size = new System.Drawing.Size(118, 40);
            this.kButton_save.TabIndex = 12;
            this.kButton_save.Values.Text = "保存";
            this.kButton_save.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ktb_wornPartType
            // 
            this.ktb_wornPartType.Location = new System.Drawing.Point(128, 125);
            this.ktb_wornPartType.Name = "ktb_wornPartType";
            this.ktb_wornPartType.Size = new System.Drawing.Size(170, 23);
            this.ktb_wornPartType.TabIndex = 10;
            // 
            // ktb_toolName
            // 
            this.ktb_toolName.Location = new System.Drawing.Point(128, 99);
            this.ktb_toolName.Name = "ktb_toolName";
            this.ktb_toolName.Size = new System.Drawing.Size(170, 23);
            this.ktb_toolName.TabIndex = 9;
            // 
            // ktb_toolNo
            // 
            this.ktb_toolNo.Location = new System.Drawing.Point(128, 73);
            this.ktb_toolNo.Name = "ktb_toolNo";
            this.ktb_toolNo.Size = new System.Drawing.Size(170, 23);
            this.ktb_toolNo.TabIndex = 8;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(22, 128);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel5.TabIndex = 6;
            this.kryptonLabel5.Values.Text = "类型";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(22, 102);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "刀具名称";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(22, 76);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "刀具编号";
            // 
            // ktb_ID
            // 
            this.ktb_ID.Location = new System.Drawing.Point(128, 20);
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
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(22, 180);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(95, 20);
            this.kryptonLabel7.TabIndex = 17;
            this.kryptonLabel7.Values.Text = "X轴行程地址位";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(22, 206);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(95, 20);
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "Y轴行程地址位";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(22, 232);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(95, 20);
            this.kryptonLabel9.TabIndex = 19;
            this.kryptonLabel9.Values.Text = "Z轴行程地址位";
            // 
            // ktb_xAddr
            // 
            this.ktb_xAddr.Location = new System.Drawing.Point(128, 177);
            this.ktb_xAddr.Name = "ktb_xAddr";
            this.ktb_xAddr.Size = new System.Drawing.Size(170, 23);
            this.ktb_xAddr.TabIndex = 20;
            this.ktb_xAddr.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // ktb_yAddr
            // 
            this.ktb_yAddr.Location = new System.Drawing.Point(128, 203);
            this.ktb_yAddr.Name = "ktb_yAddr";
            this.ktb_yAddr.Size = new System.Drawing.Size(170, 23);
            this.ktb_yAddr.TabIndex = 21;
            // 
            // ktb_zAddr
            // 
            this.ktb_zAddr.Location = new System.Drawing.Point(128, 229);
            this.ktb_zAddr.Name = "ktb_zAddr";
            this.ktb_zAddr.Size = new System.Drawing.Size(170, 23);
            this.ktb_zAddr.TabIndex = 22;
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
            // ToolNo
            // 
            this.ToolNo.DataPropertyName = "ToolNo";
            this.ToolNo.HeaderText = "刀具编号";
            this.ToolNo.Name = "ToolNo";
            this.ToolNo.ReadOnly = true;
            // 
            // ToolName
            // 
            this.ToolName.DataPropertyName = "ToolName";
            this.ToolName.HeaderText = "刀具名称";
            this.ToolName.Name = "ToolName";
            this.ToolName.ReadOnly = true;
            this.ToolName.Width = 200;
            // 
            // WornPartType
            // 
            this.WornPartType.DataPropertyName = "WornPartType";
            this.WornPartType.HeaderText = "类型";
            this.WornPartType.Name = "WornPartType";
            this.WornPartType.ReadOnly = true;
            this.WornPartType.Width = 50;
            // 
            // PresettingCount
            // 
            this.PresettingCount.DataPropertyName = "PresettingCount";
            this.PresettingCount.HeaderText = "维修时限(次/天)";
            this.PresettingCount.Name = "PresettingCount";
            this.PresettingCount.ReadOnly = true;
            this.PresettingCount.Width = 120;
            // 
            // DistanceX_Addr
            // 
            this.DistanceX_Addr.DataPropertyName = "DistanceX_Addr";
            this.DistanceX_Addr.HeaderText = "X轴行程地址位";
            this.DistanceX_Addr.Name = "DistanceX_Addr";
            this.DistanceX_Addr.ReadOnly = true;
            // 
            // DistanceY_Addr
            // 
            this.DistanceY_Addr.DataPropertyName = "DistanceY_Addr";
            this.DistanceY_Addr.HeaderText = "Y轴行程地址位";
            this.DistanceY_Addr.Name = "DistanceY_Addr";
            this.DistanceY_Addr.ReadOnly = true;
            // 
            // DistanceZ_Addr
            // 
            this.DistanceZ_Addr.DataPropertyName = "DistanceZ_Addr";
            this.DistanceZ_Addr.HeaderText = "Z轴行程地址位";
            this.DistanceZ_Addr.Name = "DistanceZ_Addr";
            this.DistanceZ_Addr.ReadOnly = true;
            // 
            // PageToolManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "PageToolManage";
            this.Size = new System.Drawing.Size(1239, 618);
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_wornPartType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_toolName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_toolNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcb_pointNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_presettingCount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_yAddr;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_xAddr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_zAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquisitionPointNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WornPartType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresettingCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceX_Addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceY_Addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceZ_Addr;
    }
}
