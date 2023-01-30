namespace YT.SuZhou.UI.Pages
{
    partial class PageSysRole
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("管理员");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("普通用户");
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.buttonSpecHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.buttonSpecHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.NodeTargert = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.NodeSource = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.buttonSpecHeaderGroup4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecHeaderGroup1,
            this.buttonSpecHeaderGroup4,
            this.buttonSpecHeaderGroup2,
            this.buttonSpecHeaderGroup3});
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.NodeTargert);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(347, 425);
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "用户组权限";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::YT.SuZhou.UI.Properties.Resources.权限;
            // 
            // buttonSpecHeaderGroup1
            // 
            this.buttonSpecHeaderGroup1.Image = global::YT.SuZhou.UI.Properties.Resources.新建;
            this.buttonSpecHeaderGroup1.Text = "新建";
            this.buttonSpecHeaderGroup1.UniqueName = "2304AE764E1F49A8C8BE50FAA61E2638";
            // 
            // buttonSpecHeaderGroup2
            // 
            this.buttonSpecHeaderGroup2.Image = global::YT.SuZhou.UI.Properties.Resources.删除;
            this.buttonSpecHeaderGroup2.Text = "删除";
            this.buttonSpecHeaderGroup2.UniqueName = "498A9AC489924E774780D692925794AE";
            // 
            // buttonSpecHeaderGroup3
            // 
            this.buttonSpecHeaderGroup3.Image = global::YT.SuZhou.UI.Properties.Resources.保存;
            this.buttonSpecHeaderGroup3.Text = "保存";
            this.buttonSpecHeaderGroup3.UniqueName = "F3C5471ECCE24EBF828F5DFBE8562F32";
            // 
            // NodeTargert
            // 
            this.NodeTargert.AllowDrop = true;
            this.NodeTargert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NodeTargert.Location = new System.Drawing.Point(0, 0);
            this.NodeTargert.Name = "NodeTargert";
            treeNode1.Name = "节点0";
            treeNode1.Text = "管理员";
            treeNode2.Name = "节点3";
            treeNode2.Text = "普通用户";
            this.NodeTargert.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.NodeTargert.Size = new System.Drawing.Size(345, 393);
            this.NodeTargert.TabIndex = 0;
            this.NodeTargert.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NodeTargert_AfterSelect);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(347, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.NodeSource);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(353, 425);
            this.kryptonHeaderGroup2.TabIndex = 1;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "菜单";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::YT.SuZhou.UI.Properties.Resources.菜单;
            // 
            // NodeSource
            // 
            this.NodeSource.AllowDrop = true;
            this.NodeSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NodeSource.Location = new System.Drawing.Point(0, 0);
            this.NodeSource.Name = "NodeSource";
            this.NodeSource.Size = new System.Drawing.Size(351, 393);
            this.NodeSource.TabIndex = 1;
            // 
            // buttonSpecHeaderGroup4
            // 
            this.buttonSpecHeaderGroup4.Image = global::YT.SuZhou.UI.Properties.Resources.编辑;
            this.buttonSpecHeaderGroup4.Text = "编辑";
            this.buttonSpecHeaderGroup4.UniqueName = "90C4154090F140DDCC88AD11A7CA9C37";
            // 
            // PageSysRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "PageSysRole";
            this.Load += new System.EventHandler(this.PageSysRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView NodeTargert;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView NodeSource;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup4;
    }
}
