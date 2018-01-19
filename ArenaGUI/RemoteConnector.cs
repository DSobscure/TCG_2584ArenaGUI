using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ArenaGUI
{
    public class RemoteConnector
    {
        public event Action<string> OnMessage;

        private TcpClient tcpClient = new TcpClient();

        private string ip;
        private int port;

        public RemoteConnector(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        public bool Connect()
        {
            try
            {
                tcpClient.Connect(ip, port);
                Task.Run(() => MainLoop());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void SendMessage(string message)
        {
            try
            {
                using (NetworkStream stream = tcpClient.GetStream())
                {
                    byte[] data = Encoding.Default.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    OnMessage?.Invoke($"<<{message}");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainLoop()
        {
            SendMessage("help");
            byte[] receiveBuffer = new byte[512];

            while (true)
            {
                try
                {
                    using (var networkStream = tcpClient.GetStream())
                    {
                        int readCount = networkStream.Read(receiveBuffer, 0, 512);
                        if (readCount == 0)
                        {
                            OnMessage?.Invoke("Connection closed");
                            break;
                        }
                        string result = Encoding.Default.GetString(receiveBuffer, 0, readCount);
                        OnMessage?.Invoke(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    OnMessage?.Invoke("Connection closed");
                    break;
                }
            }
        }
    }
}
