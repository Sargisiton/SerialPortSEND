using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace SerialPortSend
{
    
    public partial class Form1 : Form
    {
        private SerialPort comport;
        private Boolean sending;
        string port_name = "";
        string message = "";
        protected delegate void ShowBlockMethod(Byte[] content);
        public Form1()
        {
            InitializeComponent();
        }
        private SerialPort CreateComport(SerialPort port) 
        {
            if (port== null) 
            {
                port = new SerialPort(port_name, 9600, Parity.None,8, StopBits.One);//設定PORT
            }
            return port;
        }// 檢查當comport變數沒有指向任何一個SerialPort執行個體時則產生一個執行個體。
        private Boolean OpenComport(SerialPort port) 
        {
            try 
            {
                if ((port != null) && (!port.IsOpen))
                {
                    port.Open();
                    MessageBox.Show("Opened");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error Code:{0}", ex.ToString()));
                return false;
            }
        }
        // 檢查當變數指向一個執行個體 (也就是不為 Nothing/Null) 
        //且此執行個體的 IsOpen屬性為False (也就是序列埠還沒被開啟)時，則開啟序列埠
        private void CloseComport(SerialPort port) 
        {
            try
            {
                if ((port != null) && (port.IsOpen) && (!sending))
                {
                    port.Close();
                    MessageBox.Show("Closed");
                }
            }
            catch (Exception ex)
            {
                //這邊你可以自訂發生例外的處理程序
                MessageBox.Show(String.Format("Error Code:{0}", ex.ToString()));
            }
        }
        private void SendData(Object port)
        {
            //Byte[] ASCIIbytes = Encoding.ASCII.GetBytes(message);
            Byte[] buffer = new Byte[1024];
            /*for (int i = 0; ASCIIbytes[i]!='\0'&&i<1024; i++)
            {
                buffer[i] = ASCIIbytes[i];
            }*/
            for (int j = 0; j < 3; j++)
            {
                Int32 length = 0;
                switch (j)
                {
                    case 0:
                        length = 256;
                        break;
                    case 1:
                        length = 512;
                        break;
                    case 2:
                        length = 1024;
                        break;
                    default:
                        break;
                }
                Array.Resize(ref buffer, length);
                buffer[0] = Encoding.ASCII.GetBytes("S")[0];
                buffer[buffer.Length - 1] = Encoding.ASCII.GetBytes("E")[0];
                for (int i = 1; i <= buffer.Length - 2; i++)
                {
                    buffer[i] = Encoding.ASCII.GetBytes((i % 10).ToString())[0];
                }
                sending = true;
                try
                {
                    (port as SerialPort).Write(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    CloseComport((port as SerialPort));
                    MessageBox.Show(String.Format("Error Code:{0}", ex.ToString()));
                }
                finally
                {
                    sending = false;
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            comport = CreateComport(comport);
            if (!sending && OpenComport(comport))
            {
                Thread t = new Thread(SendData);
                t.IsBackground = true;
                t.Start(comport as Object);
            }
        }

        private void ClosePortButton_Click(object sender, EventArgs e)
        {
            CloseComport(comport);
        }

        private void EnterPortButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PortSet:" + PortName.Text);
            port_name = PortName.Text;
        }

        private void MessageEnterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageSet:" + Message.Text);
            message = Message.Text;
        }
    }
   
}
