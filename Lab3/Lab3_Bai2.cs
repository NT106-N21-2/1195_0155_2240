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
    public partial class Lab3_Bai2 : Form
    {
        public Lab3_Bai2()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPsever = new Thread(new ThreadStart(StartUnsafeThread));
            thdUDPsever.Start();
        }
        IPAddress ip;

        public void StartUnsafeThread()
        {
            int byteRecieve = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            listView1.Items.Add(new ListViewItem("New client connected"));
            while(clientSocket.Connected)
            {
                string text = "";
                do
                {
                    byteRecieve = clientSocket.Receive(recv);
                    text += Encoding.UTF8.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                listView1.Items.Add(new ListViewItem(text));
            }
            listenerSocket.Close();
        }
    }
}
