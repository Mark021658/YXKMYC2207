using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;

namespace YT.Suofeiya.Scan
{

    /// <summary>
    /// 通过tcp与扫码枪通讯
    /// 由长连接改为短连接
    /// </summary>
    public class TcpAdapter : IScanCommunicate
    {
        private readonly string _ip;
        private readonly int _port;


        public TcpAdapter(AcquisitionDeviceEntity scan)
        {
            _ip = scan.IP;
            _port = scan.Port;
        }

        /// <summary>
        /// 测试是否能连接上
        /// </summary>
        /// <returns></returns>
        public bool Connect()
        {
            bool isConnect = false;
            TcpClient tcpClient = new TcpClient();
            try
            {                
                IAsyncResult ar = tcpClient.BeginConnect(_ip, _port, null, null);
                bool sucess = ar.AsyncWaitHandle.WaitOne(1000,true);
                        
                if (sucess)
                {
                    NetworkStream stream = tcpClient.GetStream();
                    stream.Close();
                    isConnect = true;
                }
                    
                //tcpClient.Connect(ip, port);
                //isConnect = true;
                //stream = tcpClient.GetStream();
            }
            catch(Exception e)
            {
                isConnect = false;
            }
            finally
            {
                tcpClient.Close();
            }
            
            return isConnect;
        }

        /// <summary>
        /// 打开
        /// </summary>
        /// <returns></returns>
        public bool Open()
        {
            bool result = true;
            try
            {
                result = Connect();
                // 如果未连接这里会报错，如果未连接? 怎么处理。
                //Task t1 = Task.Factory.StartNew(delegate { ReadForLoop(); });
            }
            catch(Exception e)
            {
                result = false;
            }

            return result;
        }

        public void Close()
        {

        }

        /// <summary>
        /// 触发扫码并等待回应
        /// </summary>
        /// <returns></returns>
        public string Scan()
        {
            string result;
            try
            {
                TcpClient tcpClient = new TcpClient(_ip, _port);
                //tcpClient.ReceiveTimeout = 3000;
                NetworkStream stream = tcpClient.GetStream();

                // Buffer to store the response bytes.
                Byte[] data = new Byte[256];

                //发送 T 触发扫码
                stream.Write(new byte[] { 0x54 }, 0, 1);

                stream.Flush();
                Int32 bytes = stream.Read(data, 0, data.Length); 
                String responseData = System.Text.Encoding.UTF8.GetString(data, 0, bytes);


                stream.Close();
                tcpClient.Close();
                result = responseData;
                Console.WriteLine("Received: {0}", responseData);
            }
            catch(Exception e)
            {
                result = null;
            }

            return result;
        }

    }


}
