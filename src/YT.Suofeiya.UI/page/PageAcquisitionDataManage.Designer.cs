
namespace YT.Suofeiya.UI.Page
{
    partial class PageAcquisitionDataManage
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
            this.kcb_pointNo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton_save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktb_words = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_startAddr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktb_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquisitionPointNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Words = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcb_dataType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.kcb_dataType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataId,
            this.DataType,
            this.AcquisitionPointNo,
            this.StartAddr,
            this.Words});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowTemplate.Height = 23;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(591, 580);
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
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(597, 617);
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
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(599, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kcb_dataType);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kcb_pointNo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonRefresh);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kButton_save);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_words);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_startAddr);
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
            this.kryptonRefresh.Location = new System.Drawing.Point(159, 165);
            this.kryptonRefresh.Name = "kryptonRefresh";
            this.kryptonRefresh.Size = new System.Drawing.Size(118, 40);
            this.kryptonRefresh.TabIndex = 13;
            this.kryptonRefresh.Values.Text = "刷新";
            this.kryptonRefresh.Click += new System.EventHandler(this.kryptonRefresh_Click);
            // 
            // kButton_save
            // 
            this.kButton_save.Location = new System.Drawing.Point(22, 165);
            this.kButton_save.Name = "kButton_save";
            this.kButton_save.Size = new System.Drawing.Size(118, 40);
            this.kButton_save.TabIndex = 12;
            this.kButton_save.Values.Text = "保存";
            this.kButton_save.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ktb_words
            // 
            this.ktb_words.Location = new System.Drawing.Point(107, 99);
            this.ktb_words.Name = "ktb_words";
            this.ktb_words.Size = new System.Drawing.Size(170, 23);
            this.ktb_words.TabIndex = 9;
            // 
            // ktb_startAddr
            // 
            this.ktb_startAddr.Location = new System.Drawing.Point(107, 73);
            this.ktb_startAddr.Name = "ktb_startAddr";
            this.ktb_startAddr.Size = new System.Drawing.Size(170, 23);
            this.ktb_startAddr.TabIndex = 8;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(22, 102);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "字数";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(22, 76);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "起始地址";
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
            // dataId
            // 
            this.dataId.DataPropertyName = "Id";
            this.dataId.HeaderText = "ID";
            this.dataId.Name = "dataId";
            this.dataId.ReadOnly = true;
            this.dataId.Width = 50;
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "数据类型";
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            // 
            // AcquisitionPointNo
            // 
            this.AcquisitionPointNo.DataPropertyName = "AcquisitionPointNo";
            this.AcquisitionPointNo.HeaderText = "采集点编号";
            this.AcquisitionPointNo.Name = "AcquisitionPointNo";
            this.AcquisitionPointNo.ReadOnly = true;
            // 
            // StartAddr
            // 
            this.StartAddr.DataPropertyName = "StartAddr";
            this.StartAddr.HeaderText = "起始地址";
            this.StartAddr.Name = "StartAddr";
            this.StartAddr.ReadOnly = true;
            this.StartAddr.Width = 200;
            // 
            // Words
            // 
            this.Words.DataPropertyName = "Words";
            this.Words.HeaderText = "字数";
            this.Words.Name = "Words";
            this.Words.ReadOnly = true;
            // 
            // kcb_dataType
            // 
            this.kcb_dataType.DropDownWidth = 170;
            this.kcb_dataType.IntegralHeight = false;
            this.kcb_dataType.Location = new System.Drawing.Point(107, 127);
            this.kcb_dataType.Name = "kcb_dataType";
            this.kcb_dataType.Size = new System.Drawing.Size(170, 21);
            this.kcb_dataType.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcb_dataType.TabIndex = 15;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(22, 128);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel5.TabIndex = 16;
            this.kryptonLabel5.Values.Text = "数据类型";
            // 
            // PageAcquisitionDataManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "PageAcquisitionDataManage";
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
            ((System.ComponentModel.ISupportInitialize)(this.kcb_dataType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton_save;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_words;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_startAddr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcb_pointNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquisitionPointNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Words;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcb_dataType;
    }
}
