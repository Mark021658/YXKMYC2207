
namespace YT.Suofeiya.UI.Page
{
    partial class PageAcquisitionDeviceManage
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
            this.deviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquisitionDeviceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquisitionDeviceIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommunicationMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kcb_communicationBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktb_deviceName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_Desc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButton_save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktb_port = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_ip = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_deviceIndex = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktb_deviceNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.kcb_communicationBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceId,
            this.AcquisitionDeviceNo,
            this.AcquisitionDeviceIndex,
            this.CommunicationMode,
            this.deviceName,
            this.IP,
            this.Port,
            this.Desc});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowTemplate.Height = 23;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(693, 580);
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_RowEnter);
            // 
            // deviceId
            // 
            this.deviceId.DataPropertyName = "Id";
            this.deviceId.HeaderText = "ID";
            this.deviceId.Name = "deviceId";
            this.deviceId.ReadOnly = true;
            this.deviceId.Width = 50;
            // 
            // AcquisitionDeviceNo
            // 
            this.AcquisitionDeviceNo.DataPropertyName = "AcquisitionDeviceNo";
            this.AcquisitionDeviceNo.HeaderText = "编号";
            this.AcquisitionDeviceNo.Name = "AcquisitionDeviceNo";
            this.AcquisitionDeviceNo.ReadOnly = true;
            this.AcquisitionDeviceNo.Width = 50;
            // 
            // AcquisitionDeviceIndex
            // 
            this.AcquisitionDeviceIndex.DataPropertyName = "AcquisitionDeviceIndex";
            this.AcquisitionDeviceIndex.HeaderText = "顺序";
            this.AcquisitionDeviceIndex.Name = "AcquisitionDeviceIndex";
            this.AcquisitionDeviceIndex.ReadOnly = true;
            this.AcquisitionDeviceIndex.Width = 50;
            // 
            // CommunicationMode
            // 
            this.CommunicationMode.DataPropertyName = "CommunicationMode";
            this.CommunicationMode.HeaderText = "通讯模式";
            this.CommunicationMode.Name = "CommunicationMode";
            this.CommunicationMode.ReadOnly = true;
            // 
            // deviceName
            // 
            this.deviceName.DataPropertyName = "name";
            this.deviceName.HeaderText = "名称";
            this.deviceName.Name = "deviceName";
            this.deviceName.ReadOnly = true;
            this.deviceName.Width = 125;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Width = 125;
            // 
            // Port
            // 
            this.Port.DataPropertyName = "Port";
            this.Port.HeaderText = "端口";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            this.Port.Width = 50;
            // 
            // Desc
            // 
            this.Desc.DataPropertyName = "Desc";
            this.Desc.HeaderText = "描述";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
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
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kcb_communicationBox);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel8);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_deviceName);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_Desc);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonRefresh);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kButton_save);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_port);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_ip);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_deviceIndex);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ktb_deviceNo);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel6);
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
            // kcb_communicationBox
            // 
            this.kcb_communicationBox.DropDownWidth = 170;
            this.kcb_communicationBox.IntegralHeight = false;
            this.kcb_communicationBox.Location = new System.Drawing.Point(117, 49);
            this.kcb_communicationBox.Name = "kcb_communicationBox";
            this.kcb_communicationBox.Size = new System.Drawing.Size(170, 21);
            this.kcb_communicationBox.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcb_communicationBox.TabIndex = 20;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(22, 131);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "名称";
            this.kryptonLabel8.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel8_Paint);
            // 
            // ktb_deviceName
            // 
            this.ktb_deviceName.Location = new System.Drawing.Point(117, 128);
            this.ktb_deviceName.Name = "ktb_deviceName";
            this.ktb_deviceName.Size = new System.Drawing.Size(170, 23);
            this.ktb_deviceName.TabIndex = 17;
            // 
            // ktb_Desc
            // 
            this.ktb_Desc.Location = new System.Drawing.Point(117, 210);
            this.ktb_Desc.Name = "ktb_Desc";
            this.ktb_Desc.Size = new System.Drawing.Size(170, 23);
            this.ktb_Desc.TabIndex = 15;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(22, 213);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel7.TabIndex = 14;
            this.kryptonLabel7.Values.Text = "描述";
            // 
            // kryptonRefresh
            // 
            this.kryptonRefresh.Location = new System.Drawing.Point(159, 288);
            this.kryptonRefresh.Name = "kryptonRefresh";
            this.kryptonRefresh.Size = new System.Drawing.Size(118, 40);
            this.kryptonRefresh.TabIndex = 13;
            this.kryptonRefresh.Values.Text = "刷新";
            this.kryptonRefresh.Click += new System.EventHandler(this.kryptonRefresh_Click);
            // 
            // kButton_save
            // 
            this.kButton_save.Location = new System.Drawing.Point(22, 288);
            this.kButton_save.Name = "kButton_save";
            this.kButton_save.Size = new System.Drawing.Size(118, 40);
            this.kButton_save.TabIndex = 12;
            this.kButton_save.Values.Text = "保存";
            this.kButton_save.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ktb_port
            // 
            this.ktb_port.Location = new System.Drawing.Point(117, 183);
            this.ktb_port.Name = "ktb_port";
            this.ktb_port.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ktb_port.Size = new System.Drawing.Size(170, 23);
            this.ktb_port.TabIndex = 11;
            // 
            // ktb_ip
            // 
            this.ktb_ip.Location = new System.Drawing.Point(117, 157);
            this.ktb_ip.Name = "ktb_ip";
            this.ktb_ip.Size = new System.Drawing.Size(170, 23);
            this.ktb_ip.TabIndex = 10;
            // 
            // ktb_deviceIndex
            // 
            this.ktb_deviceIndex.Location = new System.Drawing.Point(117, 99);
            this.ktb_deviceIndex.Name = "ktb_deviceIndex";
            this.ktb_deviceIndex.Size = new System.Drawing.Size(170, 23);
            this.ktb_deviceIndex.TabIndex = 9;
            // 
            // ktb_deviceNo
            // 
            this.ktb_deviceNo.Location = new System.Drawing.Point(117, 73);
            this.ktb_deviceNo.Name = "ktb_deviceNo";
            this.ktb_deviceNo.Size = new System.Drawing.Size(170, 23);
            this.ktb_deviceNo.TabIndex = 8;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(22, 186);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel6.TabIndex = 7;
            this.kryptonLabel6.Values.Text = "端口";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(22, 160);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(21, 20);
            this.kryptonLabel5.TabIndex = 6;
            this.kryptonLabel5.Values.Text = "IP";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(22, 102);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "采集设备顺序";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(22, 76);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "采集设备编号";
            // 
            // ktb_ID
            // 
            this.ktb_ID.Location = new System.Drawing.Point(117, 20);
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
            this.kryptonLabel1.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "通讯模式";
            this.kryptonLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // PageAcquisitionDeviceManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "PageAcquisitionDeviceManage";
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
            ((System.ComponentModel.ISupportInitialize)(this.kcb_communicationBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButton_save;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_port;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_ip;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_deviceIndex;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_deviceNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_Desc;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktb_deviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquisitionDeviceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquisitionDeviceIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommunicationMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcb_communicationBox;
    }
}
