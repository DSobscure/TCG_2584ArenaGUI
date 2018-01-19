using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaGUI
{
    public class RemoteConnector
    {
        public event Action<string> OnMessage;

        private TcpClient tcpClient = new TcpClient();
        SslStream sslStream;

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
                sslStream = new SslStream(
                tcpClient.GetStream(),
                false,
                new RemoteCertificateValidationCallback(ValidateServerCertificate),
                null
                );
                sslStream.AuthenticateAsClient(ip);
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
            if (message.Trim().Length < 1)
                return;
            try
            {
                byte[] data = Encoding.Default.GetBytes(message);
                sslStream.Write(data, 0, data.Length);
                sslStream.Flush();
                OnMessage?.Invoke($"<<{message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainLoop()
        {
            byte[] receiveBuffer = new byte[512];

            while (true)
            {
                try
                {
                    int readCount = sslStream.Read(receiveBuffer, 0, 512);
                    if (readCount == 0)
                    {
                        OnMessage?.Invoke("Connection closed");
                        break;
                    }
                    string result = Encoding.Default.GetString(receiveBuffer, 0, readCount);
                    OnMessage?.Invoke(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    OnMessage?.Invoke("Connection closed");
                    break;
                }
            }
            sslStream.Close();
        }

        private bool ValidateServerCertificate(
              object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
