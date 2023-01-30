namespace YT.Suofeiya.UI.Page
{
    partial class PageOuterOrder
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
            this.buttonSpecHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.refreshBtn = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.taskInfoDgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandingMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LockRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HingeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HingeRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SculptureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BottomWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EyeRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskInfoDgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecHeaderGroup2,
            this.refreshBtn});
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonSplitContainer2);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(1158, 584);
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "外部订单列表";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::YT.Suofeiya.UI.Properties.Resources.详细分类;
            // 
            // buttonSpecHeaderGroup2
            // 
            this.buttonSpecHeaderGroup2.Image = global::YT.Suofeiya.UI.Properties.Resources.删除;
            this.buttonSpecHeaderGroup2.Text = "撤单";
            this.buttonSpecHeaderGroup2.UniqueName = "C68D8C8C64D44A486A8D80F5D341CE06";
            this.buttonSpecHeaderGroup2.Visible = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::YT.Suofeiya.UI.Properties.Resources.查询;
            this.refreshBtn.Text = "刷新";
            this.refreshBtn.UniqueName = "4ca6e3f9ef374e088a6791e5217022b9";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // kryptonSplitContainer2
            // 
            this.kryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer2.Name = "kryptonSplitContainer2";
            this.kryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer2.Panel1
            // 
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.taskInfoDgv);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonSplitContainer2_Panel2_Paint_1);
            this.kryptonSplitContainer2.Panel2Collapsed = true;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1156, 552);
            this.kryptonSplitContainer2.SplitterDistance = 184;
            this.kryptonSplitContainer2.TabIndex = 1;
            // 
            // taskInfoDgv
            // 
            this.taskInfoDgv.ColumnHeadersHeight = 28;
            this.taskInfoDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CreateTime,
            this.ProcessCode,
            this.DoorLength,
            this.DoorWidth,
            this.DoorHeight,
            this.BandingMaterial,
            this.LockType,
            this.LockRule,
            this.HingeType,
            this.HingeRule,
            this.TopWorkType,
            this.SculptureType,
            this.LabelType,
            this.LabelRule,
            this.BottomWorkType,
            this.Eye,
            this.EyeRule,
            this.DirectMark,
            this.DoorTypeCode});
            this.taskInfoDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskInfoDgv.Location = new System.Drawing.Point(0, 0);
            this.taskInfoDgv.Name = "taskInfoDgv";
            this.taskInfoDgv.ReadOnly = true;
            this.taskInfoDgv.RowTemplate.Height = 23;
            this.taskInfoDgv.Size = new System.Drawing.Size(1156, 552);
            this.taskInfoDgv.TabIndex = 0;
            this.taskInfoDgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskInfoDgv_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "订单ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // ProcessCode
            // 
            this.ProcessCode.DataPropertyName = "ProcessCode";
            this.ProcessCode.HeaderText = "条码";
            this.ProcessCode.Name = "ProcessCode";
            this.ProcessCode.ReadOnly = true;
            // 
            // DoorLength
            // 
            this.DoorLength.DataPropertyName = "DoorLength";
            this.DoorLength.HeaderText = "工件长度";
            this.DoorLength.Name = "DoorLength";
            this.DoorLength.ReadOnly = true;
            // 
            // DoorWidth
            // 
            this.DoorWidth.DataPropertyName = "DoorWidth";
            this.DoorWidth.HeaderText = "工件宽度";
            this.DoorWidth.Name = "DoorWidth";
            this.DoorWidth.ReadOnly = true;
            // 
            // DoorHeight
            // 
            this.DoorHeight.DataPropertyName = "DoorHeight";
            this.DoorHeight.HeaderText = "工件厚度";
            this.DoorHeight.Name = "DoorHeight";
            this.DoorHeight.ReadOnly = true;
            // 
            // BandingMaterial
            // 
            this.BandingMaterial.DataPropertyName = "BandingMaterial";
            this.BandingMaterial.HeaderText = "封边边材";
            this.BandingMaterial.Name = "BandingMaterial";
            this.BandingMaterial.ReadOnly = true;
            // 
            // LockType
            // 
            this.LockType.DataPropertyName = "LockType";
            this.LockType.HeaderText = "锁型号";
            this.LockType.Name = "LockType";
            this.LockType.ReadOnly = true;
            // 
            // LockRule
            // 
            this.LockRule.DataPropertyName = "LockRule";
            this.LockRule.HeaderText = "锁规则";
            this.LockRule.Name = "LockRule";
            this.LockRule.ReadOnly = true;
            // 
            // HingeType
            // 
            this.HingeType.DataPropertyName = "HingeType";
            this.HingeType.HeaderText = "铰链型号";
            this.HingeType.Name = "HingeType";
            this.HingeType.ReadOnly = true;
            // 
            // HingeRule
            // 
            this.HingeRule.DataPropertyName = "HingeRule";
            this.HingeRule.HeaderText = "铰链规则";
            this.HingeRule.Name = "HingeRule";
            this.HingeRule.ReadOnly = true;
            // 
            // TopWorkType
            // 
            this.TopWorkType.DataPropertyName = "TopWorkType";
            this.TopWorkType.HeaderText = "顶部加工类型";
            this.TopWorkType.Name = "TopWorkType";
            this.TopWorkType.ReadOnly = true;
            // 
            // SculptureType
            // 
            this.SculptureType.DataPropertyName = "SculptureType";
            this.SculptureType.HeaderText = "雕刻类型";
            this.SculptureType.Name = "SculptureType";
            this.SculptureType.ReadOnly = true;
            // 
            // LabelType
            // 
            this.LabelType.DataPropertyName = "LabelType";
            this.LabelType.HeaderText = "门标类型";
            this.LabelType.Name = "LabelType";
            this.LabelType.ReadOnly = true;
            // 
            // LabelRule
            // 
            this.LabelRule.DataPropertyName = "LabelRule";
            this.LabelRule.HeaderText = "门标规则";
            this.LabelRule.Name = "LabelRule";
            this.LabelRule.ReadOnly = true;
            // 
            // BottomWorkType
            // 
            this.BottomWorkType.DataPropertyName = "BottomWorkType";
            this.BottomWorkType.HeaderText = "底部加工类型";
            this.BottomWorkType.Name = "BottomWorkType";
            this.BottomWorkType.ReadOnly = true;
            // 
            // Eye
            // 
            this.Eye.DataPropertyName = "Eye";
            this.Eye.HeaderText = "猫眼";
            this.Eye.Name = "Eye";
            this.Eye.ReadOnly = true;
            // 
            // EyeRule
            // 
            this.EyeRule.DataPropertyName = "EyeRule";
            this.EyeRule.HeaderText = "猫眼规则";
            this.EyeRule.Name = "EyeRule";
            this.EyeRule.ReadOnly = true;
            // 
            // DirectMark
            // 
            this.DirectMark.DataPropertyName = "DirectMark";
            this.DirectMark.HeaderText = "门向标志";
            this.DirectMark.Name = "DirectMark";
            this.DirectMark.ReadOnly = true;
            // 
            // DoorTypeCode
            // 
            this.DoorTypeCode.DataPropertyName = "DoorTypeCode";
            this.DoorTypeCode.HeaderText = "门扇类型编码";
            this.DoorTypeCode.Name = "DoorTypeCode";
            this.DoorTypeCode.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonHeaderGroup1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 584);
            this.panel2.TabIndex = 2;
            // 
            // PageOuterOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PageOuterOrder";
            this.Size = new System.Drawing.Size(1158, 584);
            this.Load += new System.EventHandler(this.PageOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskInfoDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView taskInfoDgv;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup refreshBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoorLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoorWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoorHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandingMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn LockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LockRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn HingeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn HingeRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SculptureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn BottomWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eye;
        private System.Windows.Forms.DataGridViewTextBoxColumn EyeRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoorTypeCode;
    }
}
