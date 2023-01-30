using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Abp.Dependency;
using YT.SuZhou.Menu;

namespace YT.SuZhou.UI.Pages
{
    public partial class PageSysRole : UserControlBase
    {
        /// <summary>
        /// 正在拖拽的节点
        /// </summary>
        private TreeNode DragNode = null;

        /// <summary>
        /// 树形节点移动方向
        /// </summary>
        private MoveTreeView MoveTo = MoveTreeView.NoMove;

        /// <summary>
        /// 当鼠标拖拽某相进入控件区域内时
        /// </summary>
        private void TreeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }



        private readonly IMenuAppService _menuAppService;

        public PageSysRole()
        {
            InitializeComponent();

            _menuAppService = IocManager.Instance.Resolve<IMenuAppService>();
        }

        private void PageSysRole_Load(object sender, EventArgs e)
        {
            var menuRoot = _menuAppService.GetMenu();

            for (int i = 0; i < menuRoot.Nodes.Count; i++)
            {
                MenuDto primaryNode = menuRoot.Nodes[i];
                NodeSource.Nodes.Add(primaryNode.Name);
                foreach (MenuDto secondaryNode in primaryNode.Nodes)
                {
                    NodeSource.Nodes[i].Nodes.Add(secondaryNode.Name);
                }
            }
            NodeSource.AllowDrop = true;
            NodeSource.ItemDrag += new ItemDragEventHandler(TreeView_ItemDrag);
            NodeSource.DragEnter += new DragEventHandler(TreeView_DragEnter);
            NodeSource.DragDrop += new DragEventHandler(TreeView_DragDrop);

            NodeTargert.AllowDrop = true;
            NodeTargert.ItemDrag += new ItemDragEventHandler(TreeView_ItemDrag);
            NodeTargert.DragEnter += new DragEventHandler(TreeView_DragEnter);
            NodeTargert.DragDrop += new DragEventHandler(TreeView_DragDrop);
        }


        /// <summary>
        /// 当鼠标拖拽某节点时（两个控件的该事件都指向这个方法）
        /// </summary>
        private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is TreeNode && e.Button == System.Windows.Forms.MouseButtons.Left &&
                e.Item != null && sender is KryptonTreeView)
            {
                KryptonTreeView trv = sender as KryptonTreeView;
                TreeNode node = e.Item as TreeNode;
                if (node.Parent != null)
                {
                    int value = 0;
                    MoveTo = (MoveTreeView)value;
                    DragNode = node;
                    NodeSource = trv;
                    trv.DoDragDrop(node, DragDropEffects.Move);
                }
            }
        }

        /// <summary>
        /// 拖拽完成时发生的事件（两个控件的该事件都指向这个方法）
        /// </summary>
        private void TreeView_DragDrop(object sender, DragEventArgs e)
        {
            if (sender != null && sender is KryptonTreeView)
            {
                KryptonTreeView trv = sender as KryptonTreeView;

                MoveTreeView move = (MoveTreeView)1;
                if (move == MoveTo) { DragNode = null; NodeSource = null; }
                else
                {
                    Point p = trv.PointToClient(new Point(e.X, e.Y));
                    TreeNode node = trv.GetNodeAt(p);
                    //string path = GetClientPath(DragNode, DragNode.Text);
                    NodeSource.Nodes.Remove(DragNode);
                    node.Nodes.Add(DragNode);
                }
                
            }
        }

        /// <summary>
        /// 属性节点移动方向
        /// </summary>
        public enum MoveTreeView
        {
            /// <summary>
            /// 未移动
            /// </summary>
            NoMove = -1,
            /// <summary>
            /// 上传（客户端拖拽到服务器端）
            /// </summary>
            ClientToServer = 0,
            /// <summary>
            /// 下载（服务器端拖拽到客户端）
            /// </summary>
            ServerToClient = 1
        }

        private void NodeTargert_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
