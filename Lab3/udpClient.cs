using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class udpClient : Form
    {
        public udpClient()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(port.Text.Trim());
            UdpClient udpClient = new UdpClient();
            Byte[] sendBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP.Text.Trim()), Port);
            udpClient.Send(sendBytes, sendBytes.Length, endPoint);
            richTextBox1.Clear();
        }
    }
}
