using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abp.Dependency;
using ComponentFactory.Krypton.Toolkit;


namespace YT.SuZhou.UI.Pages
{
    public partial class PageOrderOperate : UserControlBase
    {


        //private int maxPlaceOderNumber = 1000;

        public PageOrderOperate()
        {
            InitializeComponent();
            //_orderAppService = IocManager.Instance.Resolve<IOrderAppService>();

            dgvOrderOperate.AutoGenerateColumns = false;
            //dgvOrderOperate.DataSource = _orderAppService.GetByStatus(EnumOrderStatus.Not);          
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> idList = new List<string>();
                //表格选中的行
                foreach (DataGridViewRow row in dgvOrderOperate.Rows)
                {
                    if (row.Cells[0].Value as bool? == true)
                    {
                        idList.Add(row.Cells[2].Value.ToString());
                    }
                }


                if (idList.Count <= 0)
                {
                    KryptonMessageBox.Show("请选择订单!");
                    return;
                }

                /*
                //根据选择的订单下载到plc
                if (rbtnDown.Checked == true)
                {
                    var task = Task.Factory.StartNew<int>(() => { return _orderAppService.PostOrder(idList); });

                    FormProgress form = IocManager.Instance.Resolve<FormProgress>();
                    form.ShowDialog();
                }
                // 撤销订单
                else if (rbtnRemove.Checked == true)
                {
                    //_orderAppService.CancelOneOrder(idList);
                    _orderAppService.CancelOrder(idList);                    
                }
                */

                //_orderAppService.CancelBatch(idList,EnumOderOperate.CancelManual);
                string strMessage = String.Format("取消订单成功");
                KryptonMessageBox.Show(strMessage);
            }
            catch(Exception ex)
            {
                KryptonMessageBox.Show(ex.ToString());
            }

        }

        private void cbSlectedMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSlectedMode.SelectedIndex == 0)
            {
                foreach (DataGridViewRow row in dgvOrderOperate.Rows)
                {
                    row.Cells[0].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvOrderOperate.Rows)
                {
                    row.Cells[0].Value = false;
                }
            }

            //dgvOrderOperate.DataSource = _orderAppService.GetByStatus(EnumOrderStatus.Not);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //dgvOrderOperate.DataSource = _orderAppService.GetByStatus(EnumOrderStatus.Not);
        }
    }
}
