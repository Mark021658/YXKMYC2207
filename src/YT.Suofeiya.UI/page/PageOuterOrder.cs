using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Abp.Dependency;
using ClosedXML.Excel;
using YT.Suofeiya.Order.Dto;
using YT.Suofeiya.Order;
using YT.Suofeiya.EntityFrameworkCore.Repositories;
using Abp.Domain.Repositories;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageOuterOrder : UserControlBase
    {
        private readonly IOrderAppService _orderAppService;
        private readonly IRepository<OuterTaskInfoEntity> _secondTaskInfoRepository;
        private readonly IRepository<MyTaskInfoEntity> _myTaskInfoRepository;

        public PageOuterOrder()
        {
            InitializeComponent();
            _myTaskInfoRepository = IocManager.Instance.Resolve<IRepository<MyTaskInfoEntity>>();
            
            //_excelAppService = IocManager.Instance.Resolve<IExcelAppService>();
            taskInfoDgv.AutoGenerateColumns = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            
        }

        private void PageOrder_Load(object sender, EventArgs e)
        {

        }

        
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void refresh()
        {
            try
            {
                taskInfoDgv.DataSource = Abp.Threading.AsyncHelper.RunSync(_myTaskInfoRepository.GetAllListAsync);

                //OrderStatisticsDto statisticsDto = Abp.Threading.AsyncHelper.RunSync(_orderAppService.GetOrderStatisticsAsync);

                //totalNumLb.Text = statisticsDto.TotalNum.ToString();
                //totalHourLb.Text = statisticsDto.RemainingTime.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void taskInfoDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (taskInfoDgv.CurrentRow == null) return;


        }

        private void kryptonSplitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonSplitContainer2_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
