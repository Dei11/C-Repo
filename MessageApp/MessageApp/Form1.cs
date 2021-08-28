using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace MessageApp
{
    public partial class Form1 : Form
    {
        Socket skt;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            skt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            boxIP.Text = GetLocalIp();
            FboxIP.Text = GetLocalIp();
        }

        private string GetLocalIp()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(boxIP.Text), Convert.ToInt32(boxPort.Text));
            skt.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(FboxIP.Text), Convert.ToInt32(FboxPort.Text));
            skt.Connect(epRemote);

            buffer = new byte[1500];
            skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {

            byte[] receivedData = new byte[1500];
            receivedData = (byte[])aResult.AsyncState;

            ASCIIEncoding aEncoding = new ASCIIEncoding();
            string receivedMessage = aEncoding.GetString(receivedData);

            listMessage.Items.Add("Firend: " + receivedMessage);

            buffer = new byte[1500];
            skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }

            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);

            skt.Send(sendingMessage);

            listMessage.Items.Add("Me: " + textMessage.Text);
            textMessage.Text = "";
        }
    }
}