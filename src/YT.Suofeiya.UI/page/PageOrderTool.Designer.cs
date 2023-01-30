namespace YT.Suofeiya.UI.Page
{
    partial class PageOrderTool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnQuery = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvProcess = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquisitionPointNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonHeaderGroup3);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonHeaderGroup2);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1158, 584);
            this.kryptonSplitContainer1.SplitterDistance = 96;
            this.kryptonSplitContainer1.SplitterWidth = 1;
            this.kryptonSplitContainer1.TabIndex = 2;
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeaderGroup3.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.btnQuery);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(1158, 96);
            this.kryptonHeaderGroup3.TabIndex = 13;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "查询";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::YT.Suofeiya.UI.Properties.Resources.查询;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(84, 18);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(126, 21);
            this.kryptonDateTimePicker1.TabIndex = 10;
            this.kryptonDateTimePicker1.ValueNullable = new System.DateTime(2021, 5, 31, 9, 56, 39, 0);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 19);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "日期";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(267, 14);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(90, 25);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Values.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.dgvProcess);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(1158, 487);
            this.kryptonHeaderGroup2.TabIndex = 4;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "加工信息";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::YT.Suofeiya.UI.Properties.Resources.分布图;
            // 
            // dgvProcess
            // 
            this.dgvProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DoorId,
            this.AcquisitionPointNo,
            this.ToolNo,
            this.ToolName,
            this.DistanceX,
            this.DistanceY,
            this.DistanceZ,
            this.UpdateTime});
            this.dgvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcess.Location = new System.Drawing.Point(0, 0);
            this.dgvProcess.MultiSelect = false;
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.ReadOnly = true;
            this.dgvProcess.RowTemplate.Height = 23;
            this.dgvProcess.Size = new System.Drawing.Size(1156, 455);
            this.dgvProcess.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // DoorId
            // 
            this.DoorId.DataPropertyName = "DoorId";
            this.DoorId.HeaderText = "工件ID";
            this.DoorId.Name = "DoorId";
            this.DoorId.ReadOnly = true;
            // 
            // AcquisitionPointNo
            // 
            this.AcquisitionPointNo.DataPropertyName = "AcquisitionPointNo";
            this.AcquisitionPointNo.HeaderText = "采集点";
            this.AcquisitionPointNo.Name = "AcquisitionPointNo";
            this.AcquisitionPointNo.ReadOnly = true;
            this.AcquisitionPointNo.Width = 50;
            // 
            // ToolNo
            // 
            this.ToolNo.DataPropertyName = "ToolNo";
            this.ToolNo.HeaderText = "刀具号";
            this.ToolNo.Name = "ToolNo";
            this.ToolNo.ReadOnly = true;
            // 
            // ToolName
            // 
            this.ToolName.DataPropertyName = "ToolName";
            this.ToolName.HeaderText = "刀具名称";
            this.ToolName.Name = "ToolName";
            this.ToolName.ReadOnly = true;
            // 
            // DistanceX
            // 
            this.DistanceX.DataPropertyName = "DistanceX";
            this.DistanceX.HeaderText = "X轴运行距离(毫米)";
            this.DistanceX.Name = "DistanceX";
            this.DistanceX.ReadOnly = true;
            this.DistanceX.Width = 120;
            // 
            // DistanceY
            // 
            this.DistanceY.DataPropertyName = "DistanceY";
            this.DistanceY.HeaderText = "Y轴运行距离(毫米)";
            this.DistanceY.Name = "DistanceY";
            this.DistanceY.ReadOnly = true;
            this.DistanceY.Width = 120;
            // 
            // DistanceZ
            // 
            this.DistanceZ.DataPropertyName = "DistanceZ";
            this.DistanceZ.HeaderText = "Z轴运行距离(毫米)";
            this.DistanceZ.Name = "DistanceZ";
            this.DistanceZ.ReadOnly = true;
            this.DistanceZ.Width = 120;
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.UpdateTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.UpdateTime.HeaderText = "更新时间";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            // 
            // PageOrderTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Name = "PageOrderTool";
            this.Size = new System.Drawing.Size(1158, 584);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnQuery;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquisitionPointNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
    }
}
