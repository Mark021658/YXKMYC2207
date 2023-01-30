using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YT.Suofeiya.UI
{
    public class TextBoxAppender : AppenderSkeleton
    {
        private TextBox _textBox;
        public string FormName { get; set; }
        public string TextBoxName { get; set; }


        // 递归查询控件
        private Control GetControls1(Control fatherControl, string controlName)
        {
            Control.ControlCollection sonControls = fatherControl.Controls;
            //遍历所有控件
            foreach (Control control in sonControls)
            {
                if (control.Name == controlName)
                {
                    return control;
                }
                else
                {
                    if (control.Controls != null)
                        return GetControls1(control, controlName);
                    else
                        return null;
                }
            }

            return null;
        }

        delegate void delOneStr(string message);

        protected override void Append(LoggingEvent loggingEvent)
        {

            if (_textBox == null)
            {
                if (String.IsNullOrEmpty(FormName) ||
                    String.IsNullOrEmpty(TextBoxName))
                    return;

                Form form = Application.OpenForms[FormName];
                if (form == null)
                    return;

                //遍历所有控件
                Control[] array = form.Controls.Find(TextBoxName, true);

                if (array.Length > 0)
                {
                    _textBox = array[0] as TextBox;
                }

                if (_textBox == null)
                    return;

                form.FormClosing += (s, e) => _textBox = null;

            }



            delOneStr dd = new delOneStr(updateTextBox);
            _textBox.BeginInvoke(dd, loggingEvent.RenderedMessage);

            //_textBox.AppendText(loggingEvent.RenderedMessage + Environment.NewLine);
            //_textBox.ScrollToCaret();//滚动条滚到到最新插入行
        }

        public void updateTextBox(string message)
        {
            StringBuilder builder;
            int n = 10;
            if (_textBox.Lines.Length > n)
            {
                builder = new StringBuilder(_textBox.Text);
                int end = _textBox.GetFirstCharIndexFromLine(n);
                builder.Remove(0, end);
                builder.Append(message + Environment.NewLine);
                _textBox.Clear();
                _textBox.AppendText(builder.ToString());
            }
            else
            {
                _textBox.AppendText(message + Environment.NewLine);
            }
        }
    }
}
