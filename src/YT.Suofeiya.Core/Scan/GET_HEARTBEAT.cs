using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Scan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GET_HEARTBEAT
    {
        public UInt16 status;

        public ushort[] toUShortArr()
        {
            ushort[] ushorts = new ushort[30];
            ushorts[0] = this.status;
            return ushorts;
        }
    }
}
