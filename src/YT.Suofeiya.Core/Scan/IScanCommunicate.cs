using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Scan
{
    /// <summary>
    /// 扫码枪通讯
    /// </summary>
    public interface IScanCommunicate
    {
        bool Open();
        void Close();
        string Scan();
    }
}
