using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Alarm;
using YT.Suofeiya.Alarm.Dto;
using YT.Suofeiya.Procedure;
using YT.Suofeiya.UI;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageDevAlarm : UserControlBase
    {
        private readonly IAlarmAppService _alarmAppService;

        private readonly IProcedureAppService _processNameAppService;

        Dictionary<string, int> dicName = new Dictionary<string, int>();

        Dictionary<int, string> dicPoint = new Dictionary<int, string>();

        public PageDevAlarm()
        {
            InitializeComponent();

            _alarmAppService = IocManager.Instance.Resolve<IAlarmAppService>();

            _processNameAppService = IocManager.Instance.Resolve<IProcedureAppService>();

            foreach (var item in _processNameAppService.GetPointName())
            {
                cbProcessName.Items.Add(item.PointName);
                dicName.Add(item.PointName, item.AcquisitionPointNo);
                dicPoint.Add(item.AcquisitionPointNo, item.PointName);
            }
            cbProcessName.Items.Add("所有");
            //cbProcessName.SelectedIndex = 2;
            //cbProcessName.DataSource = _processNameAppService.GetProcessName();

            dgvAlarm.AutoGenerateColumns = false;

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void butQuery_Click(object sender, EventArgs e)
        {
            List<AlarmHistoryDto> dtos = _alarmAppService.GetAll(dateTimePicker1.Value);

            chart1.Series[0].Points.Clear();

            foreach (int point in dicPoint.Keys)
            {
                chart1.Series[0].Points.AddXY(dicPoint[point], dtos.Count(a => a.AcquisitionPointNo == point));
            }

            if (!dicName.ContainsKey(cbProcessName.Text))
            {

            }
            else
            {
                int pointNo = dicName[cbProcessName.Text];
                dtos = dtos.Where(q => q.AcquisitionPointNo == pointNo).ToList();
            }

            chart2.Series[0].Points.Clear();

            foreach (var item in dtos.GroupBy(q => q.FaultName))
            {
                chart2.Series[0].Points.AddXY(item.Key, dtos.Count(a => a.FaultName == item.Key));
            }

            dgvAlarm.DataSource = dtos;
        }

        private void cbProcessName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonSplitContainer2_Panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void dgvAlarm_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
    }
}
