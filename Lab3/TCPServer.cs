using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
        }

        bool isConnect = false;
        TcpListener listener;
        Socket socket;
        Thread thdUDPsever;

        private void listen_Click(object sender, EventArgs e)
        {
            if (!isConnect)
            {
                CheckForIllegalCrossThreadCalls = false;
                thdUDPsever = new Thread(new ThreadStart(StartUnsafeThread));
                thdUDPsever.Start();
                listen.Text = "Disconnect";
                isConnect = true;
            }
            else
            {
                isConnect = false;
                listen.Text = "Listen";
                thdUDPsever.Abort();
            }
        }
        
        public void StartUnsafeThread()
        {
            int serverPort = int.Parse(port.Text.Trim());
            listener = new TcpListener(IPAddress.Any, serverPort);

            // 1. listen
            listener.Start();
            socket = listener.AcceptSocket();
            IPEndPoint ipEndPoint = (IPEndPoint)socket.RemoteEndPoint;

            // 2. receive
            richTextBox1.Text += ipEndPoint.Address.ToString() + ":" + ipEndPoint.Port.ToString() + " is connecting" + "\r\n";
            while (socket.Connected)
            {
                byte[] data = new byte[1024];
                socket.Receive(data);
                string str = Encoding.UTF8.GetString(data);
                mess.Items.Add(new ListViewItem(str));
            }
            socket.Close();
            listener.Stop();
        }
    }
}
