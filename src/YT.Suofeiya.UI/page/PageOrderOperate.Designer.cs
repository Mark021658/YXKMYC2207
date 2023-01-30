namespace YT.SuZhou.UI.Pages
{
    partial class PageOrderOperate
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
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbSlectedMode = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnExcute = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvOrderOperate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkpieceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thinkness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlassThinkness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lockset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocksetRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoleRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SilentSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoofSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlatDoor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SealSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlidingDoorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlidingDoorArc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sculpture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSlectedMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderOperate)).BeginInit();
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
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonButton1);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.cbSlectedMode);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.btnExcute);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonGroupBox2);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(700, 425);
            this.kryptonSplitContainer1.SplitterDistance = 107;
            this.kryptonSplitContainer1.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(30, 30);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "选择";
            // 
            // cbSlectedMode
            // 
            this.cbSlectedMode.DropDownWidth = 121;
            this.cbSlectedMode.Items.AddRange(new object[] {
            "全选",
            "全不选"});
            this.cbSlectedMode.Location = new System.Drawing.Point(90, 29);
            this.cbSlectedMode.Name = "cbSlectedMode";
            this.cbSlectedMode.Size = new System.Drawing.Size(121, 21);
            this.cbSlectedMode.TabIndex = 14;
            this.cbSlectedMode.SelectedIndexChanged += new System.EventHandler(this.cbSlectedMode_SelectedIndexChanged);
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(409, 25);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(90, 25);
            this.btnExcute.TabIndex = 11;
            this.btnExcute.Values.Text = "撤 单";
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.dgvOrderOperate);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(700, 313);
            this.kryptonGroupBox2.TabIndex = 13;
            this.kryptonGroupBox2.Values.Heading = "列表";
            // 
            // dgvOrderOperate
            // 
            this.dgvOrderOperate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Id,
            this.WorkpieceID,
            this.ProductionNo,
            this.OrderDate,
            this.No,
            this.Texture,
            this.Height,
            this.Width,
            this.Thinkness,
            this.GlassThinkness,
            this.Hinge,
            this.Lockset,
            this.LocksetRule,
            this.OpenDirection,
            this.HoleRule,
            this.SilentSlot,
            this.RoofSlot,
            this.FlatDoor,
            this.DoorType,
            this.SealSlot,
            this.SlidingDoorType,
            this.SlidingDoorArc,
            this.Sculpture,
            this.Cave,
            this.Reserved,
            this.Status,
            this.InsertType});
            this.dgvOrderOperate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderOperate.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderOperate.Name = "dgvOrderOperate";
            this.dgvOrderOperate.RowTemplate.Height = 23;
            this.dgvOrderOperate.Size = new System.Drawing.Size(696, 289);
            this.dgvOrderOperate.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(543, 25);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 16;
            this.kryptonButton1.Values.Text = "刷 新";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // WorkpieceID
            // 
            this.WorkpieceID.DataPropertyName = "WorkpieceID";
            this.WorkpieceID.HeaderText = "产品条码";
            this.WorkpieceID.Name = "WorkpieceID";
            // 
            // ProductionNo
            // 
            this.ProductionNo.DataPropertyName = "ProductionNo";
            this.ProductionNo.HeaderText = "生产总编号";
            this.ProductionNo.Name = "ProductionNo";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "下单日期";
            this.OrderDate.Name = "OrderDate";
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "序号";
            this.No.Name = "No";
            // 
            // Texture
            // 
            this.Texture.DataPropertyName = "Texture";
            this.Texture.HeaderText = "材质";
            this.Texture.Name = "Texture";
            // 
            // Height
            // 
            this.Height.DataPropertyName = "Height";
            this.Height.HeaderText = "高";
            this.Height.Name = "Height";
            // 
            // Width
            // 
            this.Width.DataPropertyName = "Width";
            this.Width.HeaderText = "宽";
            this.Width.Name = "Width";
            // 
            // Thinkness
            // 
            this.Thinkness.DataPropertyName = "Thinkness";
            this.Thinkness.HeaderText = "厚";
            this.Thinkness.Name = "Thinkness";
            // 
            // GlassThinkness
            // 
            this.GlassThinkness.DataPropertyName = "GlassThinkness";
            this.GlassThinkness.HeaderText = "玻璃厚度";
            this.GlassThinkness.Name = "GlassThinkness";
            // 
            // Hinge
            // 
            this.Hinge.DataPropertyName = "Hinge";
            this.Hinge.HeaderText = "合页";
            this.Hinge.Name = "Hinge";
            // 
            // Lockset
            // 
            this.Lockset.DataPropertyName = "Lockset";
            this.Lockset.HeaderText = "锁具";
            this.Lockset.Name = "Lockset";
            // 
            // LocksetRule
            // 
            this.LocksetRule.DataPropertyName = "LocksetRule";
            this.LocksetRule.HeaderText = "锁规则";
            this.LocksetRule.Name = "LocksetRule";
            // 
            // OpenDirection
            // 
            this.OpenDirection.DataPropertyName = "OpenDirection";
            this.OpenDirection.HeaderText = "门扇开向";
            this.OpenDirection.Name = "OpenDirection";
            // 
            // HoleRule
            // 
            this.HoleRule.DataPropertyName = "HoleRule";
            this.HoleRule.HeaderText = "油漆孔规则";
            this.HoleRule.Name = "HoleRule";
            // 
            // SilentSlot
            // 
            this.SilentSlot.DataPropertyName = "SilentSlot";
            this.SilentSlot.HeaderText = "是否开静音槽";
            this.SilentSlot.Name = "SilentSlot";
            // 
            // RoofSlot
            // 
            this.RoofSlot.DataPropertyName = "RoofSlot";
            this.RoofSlot.HeaderText = "是否开门顶玻璃槽";
            this.RoofSlot.Name = "RoofSlot";
            // 
            // FlatDoor
            // 
            this.FlatDoor.DataPropertyName = "FlatDoor";
            this.FlatDoor.HeaderText = "是否是平板门";
            this.FlatDoor.Name = "FlatDoor";
            // 
            // DoorType
            // 
            this.DoorType.DataPropertyName = "DoorType";
            this.DoorType.HeaderText = "门型";
            this.DoorType.Name = "DoorType";
            // 
            // SealSlot
            // 
            this.SealSlot.DataPropertyName = "SealSlot";
            this.SealSlot.HeaderText = "是否开密封槽";
            this.SealSlot.Name = "SealSlot";
            // 
            // SlidingDoorType
            // 
            this.SlidingDoorType.DataPropertyName = "SlidingDoorType";
            this.SlidingDoorType.HeaderText = "推拉门结构";
            this.SlidingDoorType.Name = "SlidingDoorType";
            // 
            // SlidingDoorArc
            // 
            this.SlidingDoorArc.DataPropertyName = "SlidingDoorArc";
            this.SlidingDoorArc.HeaderText = "推拉门凸弧/凹弧";
            this.SlidingDoorArc.Name = "SlidingDoorArc";
            // 
            // Sculpture
            // 
            this.Sculpture.DataPropertyName = "Sculpture";
            this.Sculpture.HeaderText = "是否雕刻";
            this.Sculpture.Name = "Sculpture";
            // 
            // Cave
            // 
            this.Cave.DataPropertyName = "Cave";
            this.Cave.HeaderText = "是否掏洞";
            this.Cave.Name = "Cave";
            // 
            // Reserved
            // 
            this.Reserved.DataPropertyName = "Reserved";
            this.Reserved.HeaderText = "预留列";
            this.Reserved.Name = "Reserved";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            // 
            // InsertType
            // 
            this.InsertType.DataPropertyName = "InsertType";
            this.InsertType.HeaderText = "插入方式";
            this.InsertType.Name = "InsertType";
            // 
            // PageOrderOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Name = "PageOrderOperate";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbSlectedMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderOperate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExcute;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvOrderOperate;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbSlectedMode;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkpieceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thinkness;
        private System.Windows.Forms.DataGridViewTextBoxColumn GlassThinkness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lockset;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocksetRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoleRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn SilentSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoofSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlatDoor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SealSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlidingDoorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlidingDoorArc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sculpture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertType;
    }
}
