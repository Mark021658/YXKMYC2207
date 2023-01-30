using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibraryExt
{
    public partial class DevListBox : ListBox
    {
        public ListBoxItem mouseItem;
        private ListBoxItemCollection m_Items;

        public DevListBox() : base()
        {
            InitializeComponent();

            m_Items = new ListBoxItemCollection(this);

            base.DrawMode = DrawMode.OwnerDrawVariable;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 双缓冲
            this.SetStyle(ControlStyles.ResizeRedraw, true); // 调整大小时重绘
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); // 开启控件透明
        }

        public new ListBoxItemCollection Items
        {
            get { return m_Items; }
        }

        internal ListBox.ObjectCollection OldItemSource
        {
            get { return base.Items; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // you can set SeletedItem background
            if (this.Focused && this.SelectedItem != null)
            {
            }

            for (int i = 0; i < Items.Count; i++)
            {
                Rectangle bounds = this.GetItemRectangle(i);

                if (mouseItem == Items[i])
                {
                    Color leftColor = Color.FromArgb(200, 192, 224, 248);
                    using (SolidBrush brush = new SolidBrush(leftColor))
                    {
                        g.FillRectangle(brush, new Rectangle(bounds.X, bounds.Y, bounds.Width, bounds.Height));
                    }

                    Color rightColor = Color.FromArgb(252, 233, 161);
                    using (SolidBrush brush = new SolidBrush(rightColor))
                    {
                        g.FillRectangle(brush, new Rectangle(bounds.Width - 40, bounds.Y, 40, bounds.Height));
                    }
                }

                int fontLeft = bounds.Left + 40 + 15;
                System.Drawing.Font font = new System.Drawing.Font("微软雅黑", 9);
                g.DrawString(Items[i].No, font, new SolidBrush(Color.FromArgb(128, 128, 128)), fontLeft, bounds.Top + 5);
                g.DrawString(Items[i].Name, font, new SolidBrush(this.ForeColor), fontLeft, bounds.Top + 20);
                g.DrawString(Items[i].Desc, font, new SolidBrush(Color.FromArgb(128, 128, 128)), fontLeft, bounds.Top + 35);

                if (Items[i].Image != null)
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                    g.DrawImage(Items[i].Image, new Rectangle(bounds.X + 5, (bounds.Height - 32) / 2 + bounds.Top, 32, 32));
                }
                //g.DrawImage(Properties.Resources.error, new Rectangle(bounds.Width - 28, (bounds.Height - 16) / 2 + bounds.Top, 16, 16));
            }
            base.OnPaint(e);
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            if (Items.Count > 0 && e.Index >= 0 && e.Index < Items.Count)
            {
                ListBoxItem item = Items[e.Index];
                e.ItemHeight = 54;
            }

        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            for (int i = 0; i < Items.Count; i++)
            {
                Rectangle bounds = this.GetItemRectangle(i);
                Rectangle deleteBounds = new Rectangle(bounds.Width - 28, (bounds.Height - 16) / 2 + bounds.Top, 16, 16);

                if (bounds.Contains(e.X, e.Y))
                {
                    if (Items[i] != mouseItem)
                    {
                        mouseItem = Items[i];
                    }

                    if (deleteBounds.Contains(e.X, e.Y))
                    {
                        mouseItem.IsFocus = true;
                        this.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        mouseItem.IsFocus = false;
                        this.Cursor = Cursors.Arrow;
                    }

                    this.Invalidate();
                    break;
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            /*
            if (mouseItem.IsFocus)
            {
                ListBoxItem deleteItem = mouseItem;
                if (MessageBox.Show("confirm to delete", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Items.Remove(deleteItem);
                }
            }
            */
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.mouseItem = null;
            this.Invalidate();
        }
    }
}
