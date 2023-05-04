using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class TCPClient : Form
    {
        public TCPClient()
        {
            InitializeComponent();
        }

        TcpClient server1;
        TcpClient server2;
        Stream stream1;
        Stream stream2;

        private void connect_Click(object sender, EventArgs e)
        {
            //Kết nối đến server 1
            string server1ip = IP1.Text.Trim();
            int server1port = int.Parse(Port1.Text.Trim());
            server1 = new TcpClient();
            server1.Connect(server1ip, server1port);
            stream1 = server1.GetStream();

            //Kết nối đến server 2
            string server2ip = IP2.Text.Trim();
            int server2port = int.Parse(Port2.Text.Trim());
            server2 = new TcpClient();
            server2.Connect(server2ip, server2port);
            stream2 = server2.GetStream();

            if (server1.Connected || server2.Connected)
                state.Text = "Connected";
            else state.Text = "Disconnected";
        }

        private void send_Click(object sender, EventArgs e)
        {
            Byte[] data = Encoding.UTF8.GetBytes(mess.Text);
            if(server1.Connected)
            {
                stream1.Write(data, 0, data.Length);
            }
            else if(!server1.Connected)
            {
                stream2.Write(data, 0, data.Length);
            }
        }
    }
}
