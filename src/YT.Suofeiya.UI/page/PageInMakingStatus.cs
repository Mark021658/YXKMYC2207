using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT.SuZhou.Core.Status;
using Abp.Events.Bus.Handlers;
using YT.SuZhou.Core.StatusManager;
using Abp.Dependency;

namespace YT.SuZhou.UI.Pages
{
    public partial class PageInMakingStatus : UserControlBase
    {
        private readonly StatusManager _statusManager;

        List<DevStatusControl> listDevStatus = new List<DevStatusControl>();
        List<InOutControl> listInOutStatus = new List<InOutControl>();

        public PageInMakingStatus()
        {
            InitializeComponent();

            propertyGrid.SelectedObject = new KryptonStatusProxy(new StatusEntity());

            _statusManager = IocManager.Instance.Resolve<StatusManager>();


            //查找所有显示的设备
            foreach (Control control in kryptonSplitContainer1.Panel2.Controls)
            {
                if (control.GetType().Name == "DevStatusControl")
                {
                    DevStatusControl devStatusControl = control as DevStatusControl;
                    listDevStatus.Add(devStatusControl);
                    //委托，添加控件点击事件
                    devStatusControl.Tag = null;
                    devStatusControl.UserControlBtnClicked += BtnClickHandle;
                }
            }

            foreach (var control in kryptonSplitContainer1.Panel2.Controls)
            {
                if (control.GetType().Name == "InOutControl")
                {
                    listInOutStatus.Add(control as InOutControl);
                }
            }
        }

        //控件点击事件
        private void BtnClickHandle(object sender, EventArgs e)
        {
            try
            {
                Control control = sender as Control;
                if(control.Tag != null)
                {
                    propertyGrid.SelectedObject = new KryptonStatusProxy(control.Tag as StatusEntity);
                }

            }
            catch(Exception ex)
            {

            }

        }

        //每秒钟刷新一次
        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<int, StatusEntity> dicStatus = _statusManager.GetCurStatus();
            //Dictionary<int, WorkpieceProcessTime>  dicProcess = _workpieceProcess.GetProcessTime();
            try
            {
                //状态更新
                foreach (DevStatusControl devStatusControl in listDevStatus)
                {
                    //int devNo = Convert.ToInt16(devStatusControl.Tag.ToString());
                    int devNo = devStatusControl.Number;
                    if (dicStatus.ContainsKey(devNo))
                    {
                        int status = dicStatus[devNo].StateWord;
                        string strTime = "00:00:00";

                        // 如果超过5秒没有更新，则初始化
                        if (dicStatus[devNo].UpdateTime < DateTime.Now.AddSeconds(-5))
                        {
                            strTime = "断线";
                            dicStatus[devNo].StateWord = 0;
                        }
                        else
                        {

                        }


                        devStatusControl.SetStatus(status, strTime);
                        devStatusControl.Tag = dicStatus[devNo];
                    }
                }

                //进出状态更新
                foreach (InOutControl inOutControl in listInOutStatus)
                {
                    int devNo = inOutControl.Number;
                    if (dicStatus.ContainsKey(devNo))
                    {
                        int status = dicStatus[devNo].StateWord;
                        bool isEnable = false;
                        //请求进料
                        if (inOutControl.InOut)
                        {
                            isEnable = (status & (1 << 3)) > 0;
                        }
                        else
                        {
                            isEnable = (status & (1 << 6)) > 0;
                        }
                        inOutControl.SetStatus(isEnable);
                    }
                }
            }
            catch
            {

            }
        }
        /*
        public void HandleEvent(StatusEventData eventData)
        {
            Console.WriteLine("A task is completed by id = " + 1);
        }
        */

        public class KryptonStatusProxy
        {
            private readonly StatusEntity _statusEntity;

            public KryptonStatusProxy(StatusEntity statusEntity)
            {
                _statusEntity = statusEntity;
            }

            [Category("设备序号")]
            [Description("对应小plc的序列号")]
            public int DevNo
            {
                get { return _statusEntity.AcquisitionPointNo; }
            }

            [Category("更新时间")]
            [Description("最近一次的更新时间")]
            public DateTime CreateTime
            {
                get { return _statusEntity.UpdateTime; }
            }

            [Category("状态")]
            [Description("状态字")]
            public int StateWord
            {
                get { return _statusEntity.StateWord; }
            }

            [Category("状态")]
            [Description("手/自动")]
            public bool StateManual
            {
                get { return _statusEntity.StateIsConnect; }
            }

            [Category("状态")]
            [Description("就绪")]
            //[DefaultValue(false)]
            public bool StateIsReady
            {
                get { return _statusEntity.StateIsReady; }
            }

            [Category("状态")]
            [Description("查找数据")]
            //[DefaultValue(false)]
            public bool StateSearchData
            {
                get { return _statusEntity.StateSearchData; }
            }

            [Category("状态")]
            [Description("请求进料")]
            //[DefaultValue(false)]
            public bool StateRequestFeed
            {
                get { return _statusEntity.StateRequestFeed; }
            }

            [Category("状态")]
            [Description("工件已进入")]
            //[DefaultValue(false)]
            public bool StateHasEntered
            {
                get { return _statusEntity.StateHasEntered; }
            }

            [Category("状态")]
            [Description("加工中")]
            //[DefaultValue(false)]
            public bool StateProcessing
            {
                get { return _statusEntity.StateProcessing; }
            }

            [Category("状态")]
            [Description("请求出料")]
            //[DefaultValue(false)]
            public bool StateAllowDischarge
            {
                get { return _statusEntity.StateAllowDischarge; }
            }

            [Category("状态")]
            [Description("工件已出")]
            //[DefaultValue(false)]
            public bool StateHasGoneOut
            {
                get { return _statusEntity.StateHasGoneOut; }
            }


            [Category("刀具字")]
            [Description("刀具字")]
            public int ToolsUsed
            {
                get { return 0; }
            }

        }
    }
}
